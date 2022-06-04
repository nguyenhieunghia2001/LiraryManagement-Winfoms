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
    public partial class ListReader : Form
    {
        public ListReader()
        {
            InitializeComponent();
        }

        private void ListReader_Load(object sender, EventArgs e)
        {
            List<Docgia> listDocGia = new List<Docgia>();
            using (var db = new heroku_c5dfe82f5ebcccfContext())
            {
                listDocGia = db.Docgia.OrderByDescending(d => d.Id).ToList();
            }

            this.Owner.Enabled = false;
            DataTable table = new DataTable();
            table.Columns.Add("Họ và tên", typeof(string));
            table.Columns.Add("Loại đọc giả", typeof(string));
            table.Columns.Add("Ngày sinh", typeof(string));
            table.Columns.Add("Email", typeof(string));
            table.Columns.Add("Địa Chỉ", typeof(string));
            table.Columns.Add("Tiền Nợ", typeof(int));
            table.Columns.Add("Ngày lập thẻ", typeof(string));


            foreach (Docgia docgia in listDocGia)
            {
                table.Rows.Add(docgia.HoTen, docgia.LoaiDocGia, docgia.NgaySinh.ToString(),
                    docgia.Email, docgia.DiaChi, docgia.TienNo, docgia.NgayLapThe.ToString());
            }

            dgv_ListReader.DataSource = table;
        }

        private void ListReader_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Owner.Enabled = true;
        }
    }
}
