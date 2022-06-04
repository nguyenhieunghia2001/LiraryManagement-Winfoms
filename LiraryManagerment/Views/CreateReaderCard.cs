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
    public partial class CreateReaderCard : Form
    {
        List<string> typeReader = new List<string>() { "Thường", "VIP" };
        List<Nhanvien> lstNhanvien = new List<Nhanvien>();
        public CreateReaderCard()
        {
            InitializeComponent();
        }


        

        private void submit_Click(object sender, EventArgs e)
        {
            Docgia docgia = new Docgia();
            docgia.HoTen = tb_HoTen.Text;
            docgia.NgaySinh = dtp_NgaySinh.Value;
            docgia.Email = tb_Email.Text;
            docgia.DiaChi = tb_DiaChi.Text;
            docgia.TienNo = 0;
            docgia.LoaiDocGia = cbb_LoaiDocGia.Text;
            docgia.NgayLapThe = dtp_NgayLapThe.Value;
            docgia.NguoiLapTheId = ((Nhanvien)cbb_NguoiLap.SelectedValue).Id;
            using (var context =  new heroku_c5dfe82f5ebcccfContext())
            {
                var entity = context.Docgia;
                entity.Add(docgia);
                context.SaveChanges();
            }

            string message = "Lưu Thông Tin Thành Công";
            MessageBoxButtons messageButton = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show(message, "Thông Báo", messageButton);
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            tb_HoTen.Text = "";
            dtp_NgaySinh.Value = DateTime.Now;
            tb_Email.Text = "";
            tb_DiaChi.Text = "";
            cbb_LoaiDocGia.SelectedIndex = 0;
            dtp_NgayLapThe.Value = DateTime.Now;
        }

        private void CreateReaderCard_Load(object sender, EventArgs e)
        {
            cbb_LoaiDocGia.DataSource = typeReader;
            using(var db = new heroku_c5dfe82f5ebcccfContext())
            {
                lstNhanvien = db.Nhanvien.ToList();
            }
            cbb_NguoiLap.DataSource = lstNhanvien;
            cbb_NguoiLap.DisplayMember = "HoTen";
        }

        private void listDocGia_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ListReader child = new ListReader();
            child.Owner = this;
            child.Show();
        }
    }
}
