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
    public partial class DebtReport : Form
    {
        List<Docgia> docgias = new List<Docgia>();
        public DebtReport()
        {
            InitializeComponent();
        }

        private void DebtReport_Load(object sender, EventArgs e)
        {
            dtp_Ngay.Value = DateTime.Now;
            using (var db = new heroku_c5dfe82f5ebcccfContext())
            {
                docgias = db.Docgia.Where(d => d.NgayLapThe.Date == DateTime.Now.Date).ToList();
            }

            bindingSaches(docgias);
        }

        private void bindingSaches(List<Docgia> docgias)
        {
            DataTable table = new DataTable();
            table.Columns.Add("STT", typeof(int));
            table.Columns.Add("Tên Độc Gải", typeof(string));
            table.Columns.Add("Tiền Nợ", typeof(string));
            int total = 0;
            int i = 1;
            using (var db = new heroku_c5dfe82f5ebcccfContext())
            {
                foreach (Docgia docgia in docgias)
                {
                    int debt = docgia.TienNo == null ? 0 : docgia.TienNo.Value;
                    total += debt;
                    table.Rows.Add(i++, docgia.HoTen, debt);
                }
            }
            dgv_BaoCao.DataSource = table;
            tb_TongTienNo.Text = total.ToString();
        }

        private void btn_XemBaoCao_Click(object sender, EventArgs e)
        {
            using (var db = new heroku_c5dfe82f5ebcccfContext())
            {
                docgias = db.Docgia.Where(d => d.NgayLapThe.Date == dtp_Ngay.Value.Date).ToList();
            }

            bindingSaches(docgias);
        }
    }
}
