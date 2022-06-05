
namespace WinFormsApp1.View
{
    partial class MainLayout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainLayout));
            this.pn_Left = new System.Windows.Forms.Panel();
            this.pn_menu = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.btnLostBook = new System.Windows.Forms.Button();
            this.btnCollectFines = new System.Windows.Forms.Button();
            this.btnReceiveBook = new System.Windows.Forms.Button();
            this.btnBorrowBook = new System.Windows.Forms.Button();
            this.btnBookSearch = new System.Windows.Forms.Button();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnCreateReaderCard = new System.Windows.Forms.Button();
            this.btnAddStaff = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.pn_logo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pn_Right = new System.Windows.Forms.Panel();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.pn_Left.SuspendLayout();
            this.pn_menu.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pn_logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.pn_Right.SuspendLayout();
            this.SuspendLayout();
            // 
            // pn_Left
            // 
            this.pn_Left.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_Left.Controls.Add(this.pn_menu);
            this.pn_Left.Controls.Add(this.pn_logo);
            this.pn_Left.Controls.Add(this.panel1);
            this.pn_Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.pn_Left.Location = new System.Drawing.Point(0, 0);
            this.pn_Left.Name = "pn_Left";
            this.pn_Left.Size = new System.Drawing.Size(281, 801);
            this.pn_Left.TabIndex = 0;
            this.pn_Left.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // pn_menu
            // 
            this.pn_menu.Controls.Add(this.panel3);
            this.pn_menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_menu.Location = new System.Drawing.Point(0, 110);
            this.pn_menu.Name = "pn_menu";
            this.pn_menu.Size = new System.Drawing.Size(279, 657);
            this.pn_menu.TabIndex = 0;
            this.pn_menu.Paint += new System.Windows.Forms.PaintEventHandler(this.pn_menu_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.panel3.Controls.Add(this.btnLogout);
            this.panel3.Controls.Add(this.button9);
            this.panel3.Controls.Add(this.button8);
            this.panel3.Controls.Add(this.btnLostBook);
            this.panel3.Controls.Add(this.btnCollectFines);
            this.panel3.Controls.Add(this.btnReceiveBook);
            this.panel3.Controls.Add(this.btnBorrowBook);
            this.panel3.Controls.Add(this.btnBookSearch);
            this.panel3.Controls.Add(this.btnAddBook);
            this.panel3.Controls.Add(this.btnCreateReaderCard);
            this.panel3.Controls.Add(this.btnAddStaff);
            this.panel3.Controls.Add(this.btnHome);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(279, 657);
            this.panel3.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogout.Location = new System.Drawing.Point(0, 551);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(279, 50);
            this.btnLogout.TabIndex = 13;
            this.btnLogout.Text = "Đăng Xuất";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.button9.Dock = System.Windows.Forms.DockStyle.Top;
            this.button9.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button9.Location = new System.Drawing.Point(0, 501);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(279, 50);
            this.button9.TabIndex = 8;
            this.button9.Text = "Lập Báo Cáo";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.button8.Dock = System.Windows.Forms.DockStyle.Top;
            this.button8.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button8.Location = new System.Drawing.Point(0, 451);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(279, 50);
            this.button8.TabIndex = 7;
            this.button8.Text = "Thanh Lý Sách";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // btnLostBook
            // 
            this.btnLostBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.btnLostBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLostBook.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLostBook.FlatAppearance.BorderSize = 0;
            this.btnLostBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLostBook.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLostBook.Location = new System.Drawing.Point(0, 401);
            this.btnLostBook.Name = "btnLostBook";
            this.btnLostBook.Size = new System.Drawing.Size(279, 50);
            this.btnLostBook.TabIndex = 6;
            this.btnLostBook.Text = "Ghi Nhận Mất Sách";
            this.btnLostBook.UseVisualStyleBackColor = false;
            this.btnLostBook.Click += new System.EventHandler(this.btnLostBook_Click);
            // 
            // btnCollectFines
            // 
            this.btnCollectFines.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.btnCollectFines.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCollectFines.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCollectFines.FlatAppearance.BorderSize = 0;
            this.btnCollectFines.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCollectFines.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCollectFines.Location = new System.Drawing.Point(0, 351);
            this.btnCollectFines.Name = "btnCollectFines";
            this.btnCollectFines.Size = new System.Drawing.Size(279, 50);
            this.btnCollectFines.TabIndex = 5;
            this.btnCollectFines.Text = "Lập Phiếu Thu Tiền Phạt";
            this.btnCollectFines.UseVisualStyleBackColor = false;
            this.btnCollectFines.Click += new System.EventHandler(this.btnCollectFines_Click);
            // 
            // btnReceiveBook
            // 
            this.btnReceiveBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.btnReceiveBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReceiveBook.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnReceiveBook.FlatAppearance.BorderSize = 0;
            this.btnReceiveBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReceiveBook.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReceiveBook.Location = new System.Drawing.Point(0, 301);
            this.btnReceiveBook.Name = "btnReceiveBook";
            this.btnReceiveBook.Size = new System.Drawing.Size(279, 50);
            this.btnReceiveBook.TabIndex = 4;
            this.btnReceiveBook.Text = "Nhận Trả Sách";
            this.btnReceiveBook.UseVisualStyleBackColor = false;
            this.btnReceiveBook.Click += new System.EventHandler(this.btnReceiveBook_Click);
            // 
            // btnBorrowBook
            // 
            this.btnBorrowBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.btnBorrowBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBorrowBook.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBorrowBook.FlatAppearance.BorderSize = 0;
            this.btnBorrowBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrowBook.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBorrowBook.Location = new System.Drawing.Point(0, 251);
            this.btnBorrowBook.Name = "btnBorrowBook";
            this.btnBorrowBook.Size = new System.Drawing.Size(279, 50);
            this.btnBorrowBook.TabIndex = 10;
            this.btnBorrowBook.Text = "Mượn Sách";
            this.btnBorrowBook.UseVisualStyleBackColor = false;
            this.btnBorrowBook.Click += new System.EventHandler(this.btnBorrowBook_Click);
            // 
            // btnBookSearch
            // 
            this.btnBookSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.btnBookSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBookSearch.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBookSearch.FlatAppearance.BorderSize = 0;
            this.btnBookSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBookSearch.Location = new System.Drawing.Point(0, 201);
            this.btnBookSearch.Name = "btnBookSearch";
            this.btnBookSearch.Size = new System.Drawing.Size(279, 50);
            this.btnBookSearch.TabIndex = 3;
            this.btnBookSearch.Text = "Tra Cứu Sách";
            this.btnBookSearch.UseVisualStyleBackColor = false;
            this.btnBookSearch.Click += new System.EventHandler(this.btnBookSearch_Click);
            // 
            // btnAddBook
            // 
            this.btnAddBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.btnAddBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddBook.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAddBook.FlatAppearance.BorderSize = 0;
            this.btnAddBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBook.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddBook.Location = new System.Drawing.Point(0, 151);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(279, 50);
            this.btnAddBook.TabIndex = 2;
            this.btnAddBook.Text = "Tiếp Nhận Sách Mới";
            this.btnAddBook.UseVisualStyleBackColor = false;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // btnCreateReaderCard
            // 
            this.btnCreateReaderCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.btnCreateReaderCard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCreateReaderCard.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCreateReaderCard.FlatAppearance.BorderSize = 0;
            this.btnCreateReaderCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateReaderCard.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCreateReaderCard.Location = new System.Drawing.Point(0, 101);
            this.btnCreateReaderCard.Margin = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.btnCreateReaderCard.Name = "btnCreateReaderCard";
            this.btnCreateReaderCard.Size = new System.Drawing.Size(279, 50);
            this.btnCreateReaderCard.TabIndex = 1;
            this.btnCreateReaderCard.Text = "Lập Thẻ Đọc Giả";
            this.btnCreateReaderCard.UseVisualStyleBackColor = false;
            this.btnCreateReaderCard.Click += new System.EventHandler(this.btnCreateReaderCard_Click);
            // 
            // btnAddStaff
            // 
            this.btnAddStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.btnAddStaff.CausesValidation = false;
            this.btnAddStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddStaff.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddStaff.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAddStaff.FlatAppearance.BorderSize = 0;
            this.btnAddStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStaff.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddStaff.Location = new System.Drawing.Point(0, 50);
            this.btnAddStaff.Name = "btnAddStaff";
            this.btnAddStaff.Size = new System.Drawing.Size(279, 51);
            this.btnAddStaff.TabIndex = 0;
            this.btnAddStaff.Text = "Tiếp nhận nhân viên";
            this.btnAddStaff.UseVisualStyleBackColor = false;
            this.btnAddStaff.Click += new System.EventHandler(this.btnAddStaff_Click_1);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(279, 50);
            this.btnHome.TabIndex = 14;
            this.btnHome.Text = "Trang chủ";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pn_logo
            // 
            this.pn_logo.Controls.Add(this.pictureBox1);
            this.pn_logo.Controls.Add(this.panel2);
            this.pn_logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pn_logo.Location = new System.Drawing.Point(0, 0);
            this.pn_logo.Name = "pn_logo";
            this.pn_logo.Size = new System.Drawing.Size(279, 110);
            this.pn_logo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(279, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 110);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(280, 73);
            this.panel2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 767);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(279, 32);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "CopyRight QLMM 2022";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pn_Right
            // 
            this.pn_Right.Controls.Add(this.panelChildForm);
            this.pn_Right.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pn_Right.Location = new System.Drawing.Point(281, 0);
            this.pn_Right.Name = "pn_Right";
            this.pn_Right.Size = new System.Drawing.Size(981, 801);
            this.pn_Right.TabIndex = 1;
            // 
            // panelChildForm
            // 
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(0, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(981, 801);
            this.panelChildForm.TabIndex = 0;
            // 
            // MainLayout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1262, 801);
            this.Controls.Add(this.pn_Right);
            this.Controls.Add(this.pn_Left);
            this.Name = "MainLayout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainLayout";
            this.Load += new System.EventHandler(this.MainLayout_Load);
            this.pn_Left.ResumeLayout(false);
            this.pn_menu.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.pn_logo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pn_Right.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pn_Left;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pn_Right;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pn_logo;
        private System.Windows.Forms.Panel pn_menu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnAddStaff;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button btnLostBook;
        private System.Windows.Forms.Button btnCollectFines;
        private System.Windows.Forms.Button btnReceiveBook;
        private System.Windows.Forms.Button btnBookSearch;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button btnCreateReaderCard;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnBorrowBook;
        private System.Windows.Forms.Button btnHome;
    }
}