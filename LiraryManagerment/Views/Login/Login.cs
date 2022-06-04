using LiraryManagerment.Models;
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
            lbErrorLogin.Text = "";
            var user = new Nhanvien()
            {
                Id = 1,
                TenDangNhap = "admin",
                MatKhau = "123456789",
                BangCap = "Cao Đẳng",
                BoPhan = "Thủ thư",
                ChucVu = "Thủ thư",
                DienThoai = "0212345678",
                HoTen = "Nguyen Hieu Nghia",
                NgaySinh = DateTime.Now,
            };


            var username = txtUserName.Text;
            var pwd = txtPwd.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(pwd))
            {
                lbErrorLogin.Text = "Vui lòng điền đầy đủ thông tin";
                return;
                //Tên đăng nhập hoặc mật khẩu không chính xác
            }
            if (username != user.TenDangNhap || pwd != user.MatKhau)
            {
                lbErrorLogin.Text = "Tên đăng nhập hoặc mật khẩu không chính xác";
                return;
            }

            this.Hide();
            var mainLayout = new MainLayout();
            mainLayout.Show();  
        }
    }
}
