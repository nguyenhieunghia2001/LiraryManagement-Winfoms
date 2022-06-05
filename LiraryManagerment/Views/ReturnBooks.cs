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
    public partial class ReturnBooks : Form
    {
        public ReturnBooks()
        {
            InitializeComponent();
        }

        List<Chitietphieumuon> ctphieumuons = new List<Chitietphieumuon>();
        List<Phieumuon> phieumuons = new List<Phieumuon>();
        List<Sach> saches = new List<Sach>();
        List<Docgia> docgias = new List<Docgia>();
        private void ReturnBooks_Load(object sender, EventArgs e)
        {
            using (var db = new heroku_c5dfe82f5ebcccfContext())
            {
                ctphieumuons = db.Chitietphieumuon.ToList();
                phieumuons = db.Phieumuon.ToList();
                saches = db.Sach.ToList();
                docgias = db.Docgia.ToList();
            }
            bindingSachs(phieumuons);
        }
        private void rb_btn_KiemTraPhieuMuon_Click(object sender, EventArgs e)
        {

            DataTable dataPhieuMuon = new DataTable();

            int search = int.Parse(rb_tb_KiemTraPhieuMuon.Text);
            Docgia docgianew = new Docgia();
            using (var db = new heroku_c5dfe82f5ebcccfContext())
            {
                phieumuons = db.Phieumuon.Where(s => s.Id == search).ToList();
                if(phieumuons != null )
                {
                    foreach (Phieumuon phieumuon in phieumuons)
                    {
                        rb_tb_IdDocGia.Text = Convert.ToString(phieumuon.DocGiaId);
                        docgianew = db.Docgia.Where(f => f.Id == phieumuon.DocGiaId).FirstOrDefault();
                        rb_tb_HovaTen.Text = docgianew.HoTen;
                    }
                }
            }
            bindingSachs(phieumuons);
        }
        private void bindingSachs(List<Phieumuon> phieumuons)
        {
            DataTable table = new DataTable();
            table.Columns.Add("STT", typeof(int));
            table.Columns.Add("ID Phiếu mượn", typeof(int));
            table.Columns.Add("ID Sách", typeof(string));
            table.Columns.Add("Tên sách", typeof(string));
            table.Columns.Add("Tác giả", typeof(string));
            table.Columns.Add("Năm xuất bản", typeof(string));
            int i = 1;

            List<Chitietphieumuon> chitietphieumuon  = new List<Chitietphieumuon>();
            Sach searchSaches = new Sach();
            
            using (var db = new heroku_c5dfe82f5ebcccfContext())
            {
                foreach (Phieumuon phieumuon in phieumuons)
                {
                    chitietphieumuon = db.Chitietphieumuon.Where(pm => pm.PhieuMuonId == phieumuon.Id).ToList();
                    foreach (Chitietphieumuon ctphieumuon in chitietphieumuon)
                    {
                        searchSaches = db.Sach.Where(s => s.Id == ctphieumuon.SachId).FirstOrDefault();
                        if (searchSaches != null)
                        {
                            table.Rows.Add(i++, phieumuon.Id, searchSaches.Id, searchSaches.TenSach, searchSaches.TacGia, searchSaches.NamXb);
                        }
                        else
                        {
                            string message = "Không tìm thấy kết quả";
                            string title = "Thông báo";
                            MessageBox.Show(message, title);
                        }
            
                    }
                }
            }
            rb_dgv_KiemTraPhieuMuon.DataSource = table;
        }

        private void rb_btn_XacNhan_Click(object sender, EventArgs e)
        {
            try
            {
                Phieutra phieutra = new Phieutra();
        
                phieutra.NgayTra = rb_dtp_NgayTra.Value;
                phieutra.DocGiaId = Convert.ToInt32(rb_tb_IdDocGia.Text);
                phieutra.TaoMoi = 1;
                phieutra.DaXoa = 0;
                using (var content = new heroku_c5dfe82f5ebcccfContext())
                {
                    var entity = content.Phieutra;
                    entity.Add(phieutra);
                    content.SaveChanges();

                    Chitietphieutra chitietphieutra = new Chitietphieutra();

                    chitietphieutra.Id = phieutra.Id;

                    chitietphieutra.SachId = 34;
                    chitietphieutra.TienPhat = Convert.ToInt32(rb_tb_SoTienPhat.Text);

                    var entity2 = content.Chitietphieutra;
                    entity2.Add(chitietphieutra);
                    content.SaveChanges();

                    //int selectedColumnCount = rb_dgv_KiemTraPhieuMuon.Columns.GetColumnCount(DataGridViewElementStates.Selected);
                    //int selectedRowCount = rb_dgv_KiemTraPhieuMuon.Rows.GetRowCount(DataGridViewElementStates.Selected);
                    //if (selectedRowCount > 0)
                    //{
                    //    System.Text.StringBuilder sb = new System.Text.StringBuilder();
                    //    chitietphieutra.SoNgayMuon = 3;
                    //    chitietphieutra.TienPhat = Convert.ToInt32(rb_tb_SoTienPhat.Text);
                    //    for (int i = 0; i < selectedRowCount; i++)
                    //    {
                    //        sb.Append(rb_dgv_KiemTraPhieuMuon.SelectedRows[i].Index.ToString());
                    //        sb.Append(Environment.NewLine);
                    //        for (int j = 0; j < selectedColumnCount; j++)
                    //        {
                    //            chitietphieutra.SachId = Convert.ToInt32(rb_dgv_KiemTraPhieuMuon.SelectedColumns[2].Index.ToString());
                    //            sb.Append(Environment.NewLine);
                    //        }
                    //    }
                    //}

                }

                string message = "Trả sách thành công!";
                string title = "Thông báo";
                MessageBox.Show(message, title);

            }
            catch (Exception ex)
            {
                MessageBox.Show(
                      "Thêm Không thành công",
                      "Thông báo",
                      MessageBoxButtons.OK,
                      MessageBoxIcon.Warning
                 );
            }
        }
    }
}
