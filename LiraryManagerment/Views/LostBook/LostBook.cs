using LiraryManagerment.Models;
using LiraryManagerment.Repositiorys;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LiraryManagerment.Views.LostBook
{
    public partial class LostBook : Form
    {
        ReaderRepository readerRepo = new ReaderRepository();
        BokkRepository bokkRepo = new BokkRepository();
        StaffRepository staffRepo = new StaffRepository();
        int staffId;

        public LostBook(int staffId)
        {
            InitializeComponent();
            this.staffId = staffId;
        }

        private void LostBook_Load(object sender, EventArgs e)
        {
            var staff = staffRepo.getStaffById(staffId);
            txtStaff.Text = staff.HoTen.ToString();

            var books = bokkRepo.getAllBook();
            cbbBook.DataSource = books;
            cbbBook.DisplayMember = "TenSach";
            cbbBook.ValueMember = "Id";

            var readers = readerRepo.getAllReader();
            cbbReader.DataSource = readers;
            cbbReader.DisplayMember = "HoTen";
            cbbReader.ValueMember = "Id";
        }

        private void cbbBook_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cbbBook = sender as ComboBox;
            var bookId = (int)cbbBook.SelectedValue;
            var book = bokkRepo.getBookBuId(bookId);
            txtFine.Text = (book.TriGia * 120/100).ToString();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new heroku_c5dfe82f5ebcccfContext())
                {
                    var lostBook = new Matsach();
                    lostBook.DocGiaId = (int)cbbReader.SelectedValue;
                    lostBook.SachId = (int)cbbBook.SelectedValue;
                    lostBook.NhanVienId = staffId;
                    lostBook.TienPhat = int.Parse(txtFine.Text);
                    lostBook.NgayGhiNhan = dtpkCreate.Value;
                    db.Matsach.Add(lostBook);
                    db.SaveChanges();

                    MessageBox.Show("Ghi nhận mất sách thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
