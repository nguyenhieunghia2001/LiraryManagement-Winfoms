using LiraryManagerment.Models;
using LiraryManagerment.Repositiorys;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LiraryManagerment.Views
{
    public partial class CollectFines : Form
    {
        ReaderRepository readerRepo = new ReaderRepository();
        StaffRepository staffRepo = new StaffRepository();
        int staffId;
        public CollectFines(int staffId)
        {
            InitializeComponent();
            this.staffId = staffId;
        }

        private void CollectFines_Load(object sender, EventArgs e)
        {
            var staff = staffRepo.getStaffById(staffId);
            txtStaff.Text = staff.HoTen.ToString();
            var readers = readerRepo.getAllReader();
            cbbReader.DataSource = readers;
            cbbReader.DisplayMember = "HoTen";
            cbbReader.ValueMember = "Id";
        }

        private void cbbReader_SelectedIndexChanged(object sender, EventArgs e)
        {
            var cbb = sender as ComboBox;
            var readerId = (int)cbb.SelectedValue;
            var reader = readerRepo.getReaderbyId(readerId);

            txtDebt.Text = reader.TienNo.ToString();
            txtMoneyDebtAfterPay.Text = reader.TienNo.ToString();
            txtMoneyReceive.Text = "0";
        }

        private void txtMoneyReceive_TextChanged(object sender, EventArgs e)
        {
            var receive = sender as TextBox;
            var receiveMonney = String.IsNullOrEmpty(receive.Text) ? 0 : long.Parse(receive.Text);

            var result = Math.Abs(long.Parse(txtDebt.Text) - receiveMonney);
            txtMoneyDebtAfterPay.Text = result.ToString();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new heroku_c5dfe82f5ebcccfContext())
                {
                    var phieuthu = new Phieuthutienphat();
                    phieuthu.DocGiaId = (int)cbbReader.SelectedValue;
                    phieuthu.NguoiThu = staffId;
                    phieuthu.TienThu = int.Parse(txtMoneyReceive.Text);
                    phieuthu.NgayThu = DateTime.Now;

                    db.Phieuthutienphat.Add(phieuthu);
                    var reader = readerRepo.getReaderbyId((int)cbbReader.SelectedValue);
                    reader.TienNo = int.Parse(txtMoneyDebtAfterPay.Text);

                    db.Entry(reader).State = EntityState.Modified;
                    db.SaveChanges();

                    MessageBox.Show("Thu tiền thành công!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
