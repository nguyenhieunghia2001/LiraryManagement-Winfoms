using LiraryManagerment.Models;
using LiraryManagerment.Repositiorys;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFormsApp1.View;

namespace LiraryManagerment.Views.Login
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
            txtPwd.PasswordChar = '•';
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            StaffRepository repo = new StaffRepository();
            var userName = txtUserName.Text;
            var pwd = txtPwd.Text;

            var staff = repo.getStaffByUsername(userName);
            if (staff == null)
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác");
                return;
            }
            if (string.IsNullOrEmpty(staff.TenDangNhap) || string.IsNullOrEmpty(pwd))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                return;
            }
            if (userName != staff.TenDangNhap || pwd != staff.MatKhau)
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác");
                return;
            }

            this.Hide();
            var mainLayout = new MainLayout(staff.Id);
            mainLayout.Show();
        }
    }
}
