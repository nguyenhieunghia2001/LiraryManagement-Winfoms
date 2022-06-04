using LiraryManagerment.Models;
using LiraryManagerment.Repositiorys;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LiraryManagerment.Views
{
    public partial class BorrowBookView : Form
    {
        DataTable dtBooks = new DataTable();
        DataTable dtBookSelect = new DataTable();
        DataTable dtBookFilter = new DataTable();
        BokkRepository bookRepo = new BokkRepository();
        int staffId;

        public BorrowBookView(int staffId)
        {
            InitializeComponent();
            this.staffId = staffId;
            dtBooks = tableBook();
            dtBookSelect = tableBook();
            dtBookFilter = tableBook();
        }

        private void btnSearchStaff_Click(object sender, EventArgs e)
        {
            var staffRepo = new ReaderRepository();
            var staff = staffRepo.getReaderbyEmail(txtStaffPhone.Text);

            if (staff != null)
            {
                txtStaffId.Text = staff.Id.ToString();
                txtStaffName.Text = staff.HoTen;
                txtStaffBOD.Text = staff.NgaySinh.ToString();
                txtAddress.Text = staff.DiaChi;
                txtDebt.Text = staff.TienNo.ToString();
            }
            else MessageBox.Show("Email không tồn tại!");
        }

        private void BorrowBookView_Load(object sender, EventArgs e)
        { 
            var books = bookRepo.getAllBook();

            var dt = tableBook();
            foreach (var book in books)
            {
                dt.Rows.Add(book.TacGia, book.TenSach, book.NamXb, book.TriGia, book.Id);
            }
            dtBooks = dt;
            dgBookList.DataSource = dt;
        }

        public DataTable tableBook()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Tên tác giả", typeof(string));
            dt.Columns.Add("Tên sách", typeof(string));
            dt.Columns.Add("Năm Xb", typeof(string));
            dt.Columns.Add("Trị giá", typeof(string));
            dt.Columns.Add("Mã sách", typeof(int));
            return dt;
        }

        private void btnChoise_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = this.dgBookList.SelectedRows[0];

            var tacgia = row.Cells["Tên tác giả"].Value;
            var tensach = row.Cells["Tên sách"].Value;
            var namxb = row.Cells["Năm Xb"].Value;
            var trigia = row.Cells["Trị giá"].Value;
            var masach = row.Cells["Mã sách"].Value;
            dtBookSelect.Rows.Add(tacgia, tensach, namxb, trigia, masach);

            for (var i = 0; i < dtBooks.Rows.Count; i++)
            {
                if (dtBooks.Rows[i]["Tên sách"] == tensach)
                {
                    dtBooks.Rows.RemoveAt(i);
                }
            }

            dgBookList.DataSource = dtBooks;
            dgBookSelected.DataSource = dtBookSelect;
        }

        private void btnDeleteSelect_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = this.dgBookSelected.SelectedRows[0];

            var tacgia = row.Cells["Tên tác giả"].Value;
            var tensach = row.Cells["Tên sách"].Value;
            var namxb = row.Cells["Năm Xb"].Value;
            var trigia = row.Cells["Trị giá"].Value;
            var masach = row.Cells["Mã sách"].Value;
            dtBooks.Rows.Add(tacgia, tensach, namxb, trigia, masach);

            for (var i = 0; i < dtBookSelect.Rows.Count; i++)
            {
                if (dtBookSelect.Rows[i]["Tên sách"] == tensach)
                {
                    dtBookSelect.Rows.RemoveAt(i);
                }
            }

            dgBookList.DataSource = dtBooks;
            dgBookSelected.DataSource = dtBookSelect;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dtBookFilter.Rows.Clear();
            var search = txtSearch.Text;
            if (string.IsNullOrEmpty(search))
            {
                dgBookList.DataSource = dtBooks;
                return;
            }

            for (var i = 0; i < dtBooks.Rows.Count; i++)
            {
                var row = dtBooks.Rows[i];
                var t = row["Tên sách"].ToString().ToLower();
                var t1 = row["Tên tác giả"].ToString().ToLower();
                var t2 = row.ItemArray[0];
                if (row["Tên sách"].ToString().ToLower().Contains(search.ToLower()) || row["Tên tác giả"].ToString().ToLower().Contains(search.ToLower()))
                {
                    dtBookFilter.Rows.Add(row.ItemArray[0], row.ItemArray[1], row.ItemArray[2], row.ItemArray[3], row.ItemArray[4]);
                }
            }
            dgBookList.DataSource = dtBookFilter;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                var readerId = txtStaffId.Text;

                if (string.IsNullOrEmpty(readerId) || dtBookSelect.Rows.Count == 0)
                {
                    MessageBox.Show("Vui lòng nhập thông tin đầy đủ!");
                    return;
                }

                var totalPrice = 0;
                for (var i = 0; i < dtBookSelect.Rows.Count; i++)
                {
                    totalPrice += int.Parse(dtBookSelect.Rows[i]["Trị giá"].ToString());
                    var t = int.Parse(dtBookSelect.Rows[i]["Mã sách"].ToString());
                }

                using (var db = new heroku_c5dfe82f5ebcccfContext())
                {
                    var borrow = new Phieumuon();
                    borrow.NhanVienId = (int)staffId;
                    borrow.DocGiaId = int.Parse(readerId);
                    borrow.SoLuong = dtBookSelect.Rows.Count;
                    borrow.DonGia = totalPrice;
                    borrow.NgayMuon = DateTime.Now;

                    var addBorrow = db.Phieumuon.Add(borrow);
                    db.SaveChanges();

                    for (var i = 0; i < dtBookSelect.Rows.Count; i++)
                    {
                        var bookId = int.Parse(dtBookSelect.Rows[i]["Mã sách"].ToString());
                        var borrowDetail = new Chitietphieumuon();
                        borrowDetail.PhieuMuonId = borrow.Id;
                        borrowDetail.SachId = bookId;
                        db.Chitietphieumuon.Add(borrowDetail);

                        //update lai số lượng sách 
                        var book = bookRepo.getBookBuId(bookId);
                        book.SoLuong = book.SoLuong - 1;

                        db.Entry(book).State = EntityState.Modified;
                        db.SaveChanges();
                    }

                    
                    db.SaveChanges();
                }
                MessageBox.Show("Mượn sách thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
