using LiraryManagerment.Repositiorys;
using LiraryManagerment.Views;
using LiraryManagerment.Views.Login;
using LiraryManagerment.Views.LostBook;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp1.View
{
    public partial class MainLayout : Form
    {
        int staffId;
        StaffRepository staffRepo = new StaffRepository();
        Button btnSelected = new Button();
        public MainLayout(int StaffId)
        {
            staffId = StaffId;
            InitializeComponent();
            btnSelected = btnAddStaff;
        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (ActiveForm == null)
                ActiveForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnBorrowBook_Click(object sender, EventArgs e)
        {
            activeSidrbar(sender);
            openChildForm(new BorrowBookView(staffId));
        }

        private void activeSidrbar(object sender)
        {
            var thisButton = sender as Button;
            thisButton.BackColor = Color.FromArgb(130, 180, 255);
            btnSelected.BackColor = Color.FromArgb(237, 237, 237);
            btnSelected = thisButton;
        }

        private void btnLostBook_Click(object sender, EventArgs e)
        {
            var staff = staffRepo.getStaffById(staffId);
            if (staff.BoPhan.ToLower() != "thủ thư")
            {
                MessageBox.Show("Chức vụ chỉ dành cho bộ phận thủ thư");
                return;
            }
            activeSidrbar(sender);
            openChildForm(new LostBook(staffId));
        }

        private void CreateReaderCard_Click(object sender, EventArgs e)
        {
            activeSidrbar(sender);
            openChildForm(new CreateReaderCard());
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            activeSidrbar(sender);
            openChildForm(new ReciveNewBook());
        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            activeSidrbar(sender);
            openChildForm(new CreateStaff());
        }

        private void btnCollectFines_Click(object sender, EventArgs e)
        {
            activeSidrbar(sender);
            openChildForm(new CollectFines(staffId));
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            activeSidrbar(sender);
            openChildForm(new HomeView(staffId));
        }

        private void MainLayout_Load(object sender, EventArgs e)
        {
            btnHome.BackColor = Color.FromArgb(130, 180, 255);
            btnSelected.BackColor = Color.FromArgb(237, 237, 237);
            btnSelected = btnHome;

            var childForm = new HomeView(staffId);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            var login = new Login();
            login.Show();
        }

        private void btnAddStaff_Click_1(object sender, EventArgs e)
        {
            activeSidrbar(sender);
            openChildForm(new CreateStaff());
        }

        private void btnCreateReaderCard_Click(object sender, EventArgs e)
        {
            activeSidrbar(sender);
            openChildForm(new CreateReaderCard());
        }

        private void btnBookSearch_Click(object sender, EventArgs e)
        {
            activeSidrbar(sender);
            openChildForm(new SearchBook());
        }

        private void btnReceiveBook_Click(object sender, EventArgs e)
        {
            activeSidrbar(sender);
            openChildForm(new ReturnBooks());
        }

        private void btnLiquidation_Click(object sender, EventArgs e)
        {
            activeSidrbar(sender);
            openChildForm(new BookLiquidation());
        }
    }
}
