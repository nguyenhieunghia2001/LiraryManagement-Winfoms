using LiraryManagerment.Models;
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
    public partial class ReciveNewBook : Form
    {
        Nhanvien NhanVien = new Nhanvien();
        int staffId;
        List<Loaisach> lstLoaisach = new List<Loaisach>();
        public ReciveNewBook(int staffId)
        {
            InitializeComponent();
            this.staffId = staffId;
        }

        private void ReciveNewBook_Load(object sender, EventArgs e)
        {

            using (var db = new heroku_c5dfe82f5ebcccfContext())
            {
                lstLoaisach = db.Loaisach.ToList();
                NhanVien = db.Nhanvien.Where(d => d.Id == staffId).FirstOrDefault();
            }
            tb_NguoiTiepNhan.Text = NhanVien.HoTen;
            cbb_LoaiSach.DataSource = lstLoaisach;
            cbb_LoaiSach.DisplayMember = "TenLoai";
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            //try
            //{
            Sach sach = new Sach();
            sach.TenSach = tb_TenSach.Text;
            sach.TacGia = tb_TacGia.Text;
            sach.NhaXuatBan = tb_NhaXuatBan.Text;
            sach.SoLuong = Int32.Parse(tb_SoLuong.Text);
            sach.NamXb = Int32.Parse(tb_NamXuatBan.Text);
            sach.TriGia = Int32.Parse(tb_TriGia.Text);
            Loaisach ls = (Loaisach)cbb_LoaiSach.SelectedValue;
            sach.NguoiTiepNhanId = staffId;
            sach.LoaiSachId = ls.Id;
            sach.TinhTrangId = 1;
            sach.NgayTao = dtp_NgayNhap.Value;
            using (var context = new heroku_c5dfe82f5ebcccfContext())
            {
                var entity = context.Sach;
                entity.Add(sach);
                context.SaveChanges();
            }

            string message = "Lưu Thông Tin Thành Công";
            MessageBoxButtons messageButton = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show(message, "Thông Báo", messageButton);
            //}
            //catch(Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            tb_TenSach.Text = "";
            tb_TacGia.Text = "";
            tb_NhaXuatBan.Text = "";
            tb_SoLuong.Text = "";
            tb_NamXuatBan.Text = "";
            tb_TriGia.Text = "";
            cbb_LoaiSach.SelectedIndex = 0;
            dtp_NgayNhap.Value = DateTime.Now;
        }
    }
}
