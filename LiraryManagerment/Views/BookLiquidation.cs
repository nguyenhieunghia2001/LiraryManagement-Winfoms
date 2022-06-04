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
    public partial class BookLiquidation : Form
    {
        List<Sach> saches = new List<Sach>();
        List<Nhanvien> lstNhanvien = new List<Nhanvien>();

        public BookLiquidation()
        {
            InitializeComponent();
        }

        private void BookLiquidation_Load(object sender, EventArgs e)
        {
            using (var db = new heroku_c5dfe82f5ebcccfContext())
            {
                saches = db.Sach.ToList();
                lstNhanvien = db.Nhanvien.ToList();
            }
            cbb_NhanVien.DataSource = lstNhanvien;
            cbb_NhanVien.DisplayMember = "HoTen";
            bindingSaches(saches);
        }

        private void bindingSaches(List<Sach> saches)
        {
            DataTable table = new DataTable();
            table.Columns.Add("STT", typeof(int));
            table.Columns.Add("Mã sách", typeof(string));
            table.Columns.Add("Tên sách", typeof(string));
            table.Columns.Add("Thể loại", typeof(string));
            table.Columns.Add("Tác giả", typeof(string));
            table.Columns.Add("Tình trạng", typeof(string));
            int i = 1;
            Tinhtrangsach tinhtrangsach;
            Loaisach loaisach;
            using (var db = new heroku_c5dfe82f5ebcccfContext())
            {
                foreach (Sach sach in saches)
                {
                    loaisach = db.Loaisach.Where(a => a.Id == sach.LoaiSachId).FirstOrDefault();
                    tinhtrangsach = db.Tinhtrangsach.Where(s => s.Id == sach.TinhTrangId).FirstOrDefault();
                    table.Rows.Add(i++, loaisach.Id + sach.Id, sach.TenSach,
                        loaisach.TenLoai, sach.TacGia, tinhtrangsach.Ten);
                }
            }
            dgv_Sach.DataSource = table;
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            using (var db = new heroku_c5dfe82f5ebcccfContext())
            {
                saches = db.Sach.Where(s => s.TenSach.ToLower().Contains(tb_SearchText.Text.ToLower())).ToList();
            }
            bindingSaches(saches);
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            using (var db = new heroku_c5dfe82f5ebcccfContext()) {
                Thanhlysach thanhlysach = new Thanhlysach();
                thanhlysach.LyDo = tb_LyDo.Text;
                thanhlysach.NgayThanhLy = dtp_NgayThanhLy.Value;
                thanhlysach.IdNhanVien = ((Nhanvien)cbb_NhanVien.SelectedItem).Id;
                var entity = db.Thanhlysach;
                entity.Add(thanhlysach);
                db.SaveChanges();
                Chitietthanhlysach chitietthanhlysach;

                var entity2 = db.Chitietthanhlysach;
                List<Chitietthanhlysach> chitietthanhlysaches = new List<Chitietthanhlysach>();
                foreach (DataGridViewRow row in dgv_Sach.SelectedRows)
                {
                    chitietthanhlysach = new Chitietthanhlysach();
                    chitietthanhlysach.ThanhLySachId = thanhlysach.Id;
                    chitietthanhlysach.ThanhLySach = thanhlysach;
                    chitietthanhlysach.SachId = Int32.Parse(row.Cells["Mã sách"].Value.ToString().Substring(2));
                    chitietthanhlysaches.Add(chitietthanhlysach);
                }
                entity2.AddRange(chitietthanhlysaches);
                db.SaveChanges();
            }

        }
    }
}
