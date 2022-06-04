using LiraryManagerment.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LiraryManagerment.Views
{
    public partial class CreateStaff : Form
    {
        public CreateStaff()
        {
            InitializeComponent();
        }
        private void CreateStaff_Load(object sender, EventArgs e)
        {
            cs_cb_ChucVu.Items.Add("Giám Đốc");
            cs_cb_ChucVu.Items.Add("Phó Giám Đốc");
            cs_cb_ChucVu.Items.Add("Trưởng Phòng");
            cs_cb_ChucVu.Items.Add("Nhân Viên");

            cs_cb_BoPhan.Items.Add("Thủ Thư");
            cs_cb_BoPhan.Items.Add("Thủ Kho");
            cs_cb_BoPhan.Items.Add("Thủ Quỷ");
            cs_cb_BoPhan.Items.Add("Ban Giám Đốc");

            cs_cb_BangCap.Items.Add("Tú Tài");
            cs_cb_BangCap.Items.Add("Trung Cấp");
            cs_cb_BangCap.Items.Add("Cao Đẳng");
            cs_cb_BangCap.Items.Add("Đại Học");
            cs_cb_BangCap.Items.Add("Thạc Sỹ");
            cs_cb_BangCap.Items.Add("Tiến Sỹ");
        }
        private void cs_btn_XacNhan_Click(object sender, EventArgs e)
        {

            try {
                Nhanvien nhanvien = new Nhanvien();
                nhanvien.BangCap = cs_cb_BangCap.SelectedItem.ToString();
                nhanvien.BoPhan = cs_cb_BoPhan.SelectedItem.ToString();
                nhanvien.ChucVu = cs_cb_ChucVu.SelectedItem.ToString();
                nhanvien.HoTen = cs_tb_HovaTen.Text;
                nhanvien.DienThoai = cs_tb_SDT.Text;
                nhanvien.NgaySinh = cs_dtp_NgaySinh.Value;
                nhanvien.DiaChi = cs_tb_DiaChi.Text;
                nhanvien.TaoMoi = 1;
                nhanvien.DaXoa = 0;
                nhanvien.TenDangNhap = "user";
                nhanvien.MatKhau = "123456789";

                using(var content = new heroku_c5dfe82f5ebcccfContext())
                {
                    var entity = content.Nhanvien;
                    entity.Add(nhanvien);
                    content.SaveChanges();
                }

                string message = "Thêm nhân viên thành công!";
                string title = "Thông báo";
                MessageBox.Show(message, title);

            }
            catch(Exception ex)
            {
                MessageBox.Show(
                      "Thêm Không thành công",
                      "Thông báo",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Warning 
                 );
                throw new ArgumentOutOfRangeException("index parameter is out of range.", ex);
            }
        }

    }
}
