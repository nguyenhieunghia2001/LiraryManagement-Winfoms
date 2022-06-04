using LiraryManagerment.Repositiorys;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LiraryManagerment.Views
{
    public partial class HomeView : Form
    {
        int staffId;
        public HomeView(int staffId)
        {
            InitializeComponent();
            this.staffId = staffId;
        }

        private void HomeView_Load(object sender, EventArgs e)
        {
            var repo = new StaffRepository();
            var staff = repo.getStaffById(staffId);
            txtAddress.Text = staff.DiaChi;
            txtBOD.Text = staff.NgaySinh.ToString();
            txtName.Text = staff.HoTen;
            txtPosition.Text = staff.BoPhan;
        }
    }
}
