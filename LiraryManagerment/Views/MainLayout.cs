using LiraryManagerment.Views;
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
        public MainLayout(int StaffId)
        {
            staffId = StaffId;
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pn_menu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if(ActiveForm == null)
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

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void btnBorrowBook_Click(object sender, EventArgs e)
        {
            openChildForm(new BorrowBookView(staffId));
        }

        private void CreateReaderCard_Click(object sender, EventArgs e)
        {
            openChildForm(new CreateReaderCard());
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            openChildForm(new ReciveNewBook());
        }

        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            openChildForm(new CreateStaff());
        }
    }
}
