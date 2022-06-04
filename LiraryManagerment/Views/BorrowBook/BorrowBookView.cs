using LiraryManagerment.Models;
using LiraryManagerment.Repositiorys;
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
        public BorrowBookView()
        {
            InitializeComponent();
           
        }

        private void btnSearchStaff_Click(object sender, EventArgs e)
        {
            var staffRepo = new StaffRepository();
            var staffs = staffRepo.getAllStaff();

            var staff = staffs.Find(s => s.DienThoai == txtStaffPhone.Text);
            if (staff != null)
            {
                txtStaffId.Text = staff.Id.ToString();
                txtStaffName.Text = staff.HoTen;
                txtStaffBOD.Text = staff.NgaySinh.ToString();
                txtAddress.Text = staff.DiaChi;
                txtChucVu.Text = staff.ChucVu;
            }
            else MessageBox.Show("Số điện thoại không tồn tại!");
        }

        private void BorrowBookView_Load(object sender, EventArgs e)
        {
            var repo = new BokkRepository();
            var books = repo.getAllBook();

            var dt = tableBook();
            var i = 1;
            foreach (var book in books)
            {
                dt.Rows.Add(i, book.TacGia, book.TenSach, book.NamXb, book.TriGia);
            }
            dgBookList.DataSource = dt;
        }

        public DataTable tableBook ()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("STT", typeof(int));
            dt.Columns.Add("Tên tác giả", typeof(string));
            dt.Columns.Add("Tên sách", typeof(string));
            dt.Columns.Add("Năm Xb", typeof(string));
            dt.Columns.Add("Trị giá", typeof(string));
            return dt;
        }

        private void btnChoise_Click(object sender, EventArgs e)
        {

        }
    }
}
