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
    public partial class SearchBook : Form
    {
        List<Loaisach> loaisaches = new List<Loaisach>();
        List<Sach> saches = new List<Sach>();
        public SearchBook()
        {
            InitializeComponent();
        }

        private void SearchBook_Load(object sender, EventArgs e)
        {
            using (var db = new heroku_c5dfe82f5ebcccfContext())
            {
                saches = db.Sach.ToList();
                loaisaches = db.Loaisach.ToList();

                cbb_TheLoai.DataSource = loaisaches;
                cbb_TheLoai.DisplayMember = "TenLoai";
            }
            bindingSaches(saches);

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            using(var db = new heroku_c5dfe82f5ebcccfContext())
            {
                saches = db.Sach.Where(s => s.TenSach.ToLower().Contains(tb_searchtext.Text.ToLower())).ToList();
            }
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
            using(var db = new heroku_c5dfe82f5ebcccfContext())
            {
                foreach (Sach sach in saches)
                {
                    loaisach = db.Loaisach.Where(a => a.Id == sach.LoaiSachId).FirstOrDefault();
                    tinhtrangsach = db.Tinhtrangsach.Where(s => s.Id == sach.TinhTrangId).FirstOrDefault();
                    table.Rows.Add(i++, sach.Id, sach.TenSach,
                        loaisach.TenLoai, sach.TacGia, tinhtrangsach.Ten);
                }
            }
            dgv_sach.DataSource = table;
        }

        private void cbb_TheLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            Loaisach loaisach = (Loaisach)cbb_TheLoai.SelectedItem;
            using(var db = new heroku_c5dfe82f5ebcccfContext())
            {
                saches = db.Sach.Where(s => s.LoaiSachId == loaisach.Id).ToList();
            }
            bindingSaches(saches);
        }
    }
}
