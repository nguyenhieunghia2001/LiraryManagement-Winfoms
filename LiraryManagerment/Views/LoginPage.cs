using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFormsApp1.View;

namespace LiraryManagerment.Views
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //check login


            //if login success, redirect primary page
            MainLayout layout = new MainLayout();
            this.Hide();
            layout.Show();
        }
    }
}
