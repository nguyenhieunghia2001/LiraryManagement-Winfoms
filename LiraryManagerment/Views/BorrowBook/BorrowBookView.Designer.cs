namespace LiraryManagerment.Views
{
    partial class BorrowBookView
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
            this.grHeader = new System.Windows.Forms.GroupBox();
            this.lbTitle = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDeleteSelect = new System.Windows.Forms.Button();
            this.btnChoise = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dgBookList = new System.Windows.Forms.DataGridView();
            this.dgBookSelected = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.txtDebt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtStaffBOD = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtStaffName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtStaffId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtStaffPhone = new System.Windows.Forms.TextBox();
            this.btnSearchStaff = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grHeader.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBookList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgBookSelected)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // grHeader
            // 
            this.grHeader.Controls.Add(this.lbTitle);
            this.grHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.grHeader.Location = new System.Drawing.Point(0, 0);
            this.grHeader.Name = "grHeader";
            this.grHeader.Size = new System.Drawing.Size(963, 59);
            this.grHeader.TabIndex = 0;
            this.grHeader.TabStop = false;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTitle.Location = new System.Drawing.Point(374, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(271, 46);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Cho Mượn Sách";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDeleteSelect);
            this.groupBox2.Controls.Add(this.btnChoise);
            this.groupBox2.Controls.Add(this.btnSearch);
            this.groupBox2.Controls.Add(this.txtSearch);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.dgBookList);
            this.groupBox2.Controls.Add(this.dgBookSelected);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Location = new System.Drawing.Point(0, 59);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(689, 736);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin sách";
            // 
            // btnDeleteSelect
            // 
            this.btnDeleteSelect.Location = new System.Drawing.Point(590, 29);
            this.btnDeleteSelect.Name = "btnDeleteSelect";
            this.btnDeleteSelect.Size = new System.Drawing.Size(93, 29);
            this.btnDeleteSelect.TabIndex = 11;
            this.btnDeleteSelect.Text = "Xóa";
            this.btnDeleteSelect.UseVisualStyleBackColor = true;
            this.btnDeleteSelect.Click += new System.EventHandler(this.btnDeleteSelect_Click);
            // 
            // btnChoise
            // 
            this.btnChoise.Location = new System.Drawing.Point(292, 701);
            this.btnChoise.Name = "btnChoise";
            this.btnChoise.Size = new System.Drawing.Size(107, 29);
            this.btnChoise.TabIndex = 10;
            this.btnChoise.Text = "Chọn";
            this.btnChoise.UseVisualStyleBackColor = true;
            this.btnChoise.Click += new System.EventHandler(this.btnChoise_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(623, 370);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(60, 29);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Tìm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(385, 373);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "Tên sách, tên tác giả";
            this.txtSearch.Size = new System.Drawing.Size(232, 27);
            this.txtSearch.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(12, 372);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(199, 28);
            this.label10.TabIndex = 5;
            this.label10.Text = "Sách trong thư viện";
            // 
            // dgBookList
            // 
            this.dgBookList.AllowUserToAddRows = false;
            this.dgBookList.AllowUserToDeleteRows = false;
            this.dgBookList.AllowUserToOrderColumns = true;
            this.dgBookList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBookList.Location = new System.Drawing.Point(12, 406);
            this.dgBookList.Name = "dgBookList";
            this.dgBookList.ReadOnly = true;
            this.dgBookList.RowHeadersWidth = 51;
            this.dgBookList.RowTemplate.Height = 29;
            this.dgBookList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgBookList.Size = new System.Drawing.Size(671, 289);
            this.dgBookList.TabIndex = 4;
            // 
            // dgBookSelected
            // 
            this.dgBookSelected.AllowUserToAddRows = false;
            this.dgBookSelected.AllowUserToDeleteRows = false;
            this.dgBookSelected.AllowUserToOrderColumns = true;
            this.dgBookSelected.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBookSelected.Location = new System.Drawing.Point(12, 64);
            this.dgBookSelected.Name = "dgBookSelected";
            this.dgBookSelected.ReadOnly = true;
            this.dgBookSelected.RowHeadersWidth = 51;
            this.dgBookSelected.RowTemplate.Height = 29;
            this.dgBookSelected.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgBookSelected.Size = new System.Drawing.Size(671, 277);
            this.dgBookSelected.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(12, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 28);
            this.label9.TabIndex = 1;
            this.label9.Text = "Sách đã chọn";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnSubmit);
            this.groupBox3.Controls.Add(this.panel9);
            this.groupBox3.Controls.Add(this.panel8);
            this.groupBox3.Controls.Add(this.panel7);
            this.groupBox3.Controls.Add(this.panel6);
            this.groupBox3.Controls.Add(this.panel3);
            this.groupBox3.Controls.Add(this.panel2);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(689, 59);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(274, 736);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kiểm tra thông tin độc giả";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(74, 611);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(120, 40);
            this.btnSubmit.TabIndex = 9;
            this.btnSubmit.Text = "Xác nhận";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.txtDebt);
            this.panel9.Controls.Add(this.label8);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(3, 462);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(268, 79);
            this.panel9.TabIndex = 8;
            // 
            // txtDebt
            // 
            this.txtDebt.Location = new System.Drawing.Point(17, 40);
            this.txtDebt.Name = "txtDebt";
            this.txtDebt.ReadOnly = true;
            this.txtDebt.Size = new System.Drawing.Size(242, 27);
            this.txtDebt.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tiền nợ";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.txtAddress);
            this.panel8.Controls.Add(this.label7);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(3, 383);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(268, 79);
            this.panel8.TabIndex = 8;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(17, 40);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ReadOnly = true;
            this.txtAddress.Size = new System.Drawing.Size(242, 27);
            this.txtAddress.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "Địa Chỉ";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.txtStaffBOD);
            this.panel7.Controls.Add(this.label6);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(3, 304);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(268, 79);
            this.panel7.TabIndex = 8;
            // 
            // txtStaffBOD
            // 
            this.txtStaffBOD.Location = new System.Drawing.Point(17, 40);
            this.txtStaffBOD.Name = "txtStaffBOD";
            this.txtStaffBOD.ReadOnly = true;
            this.txtStaffBOD.Size = new System.Drawing.Size(242, 27);
            this.txtStaffBOD.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ngày Sinh";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txtStaffName);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(3, 225);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(268, 79);
            this.panel6.TabIndex = 7;
            // 
            // txtStaffName
            // 
            this.txtStaffName.Location = new System.Drawing.Point(17, 40);
            this.txtStaffName.Name = "txtStaffName";
            this.txtStaffName.ReadOnly = true;
            this.txtStaffName.Size = new System.Drawing.Size(242, 27);
            this.txtStaffName.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Họ tên";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.textBox2);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 146);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(268, 79);
            this.panel3.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.textBox3);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(268, 79);
            this.panel4.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtStaffId);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(268, 79);
            this.panel5.TabIndex = 6;
            // 
            // txtStaffId
            // 
            this.txtStaffId.Location = new System.Drawing.Point(17, 40);
            this.txtStaffId.Name = "txtStaffId";
            this.txtStaffId.ReadOnly = true;
            this.txtStaffId.Size = new System.Drawing.Size(242, 27);
            this.txtStaffId.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "ID độc giả";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(17, 40);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(274, 27);
            this.textBox3.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "ID đọc giả";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(17, 40);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(274, 27);
            this.textBox2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "ID đọc giả";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtStaffPhone);
            this.panel2.Controls.Add(this.btnSearchStaff);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(268, 123);
            this.panel2.TabIndex = 3;
            // 
            // txtStaffPhone
            // 
            this.txtStaffPhone.Location = new System.Drawing.Point(53, 34);
            this.txtStaffPhone.Name = "txtStaffPhone";
            this.txtStaffPhone.Size = new System.Drawing.Size(206, 27);
            this.txtStaffPhone.TabIndex = 1;
            // 
            // btnSearchStaff
            // 
            this.btnSearchStaff.Location = new System.Drawing.Point(188, 78);
            this.btnSearchStaff.Name = "btnSearchStaff";
            this.btnSearchStaff.Size = new System.Drawing.Size(71, 29);
            this.btnSearchStaff.TabIndex = 2;
            this.btnSearchStaff.Text = "Tìm";
            this.btnSearchStaff.UseVisualStyleBackColor = true;
            this.btnSearchStaff.Click += new System.EventHandler(this.btnSearchStaff_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email";
            // 
            // BorrowBookView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 795);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grHeader);
            this.Name = "BorrowBookView";
            this.Text = "BorrowBookView";
            this.Load += new System.EventHandler(this.BorrowBookView_Load);
            this.grHeader.ResumeLayout(false);
            this.grHeader.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgBookList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgBookSelected)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grHeader;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox txtDebt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txtStaffBOD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtStaffName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtStaffId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtStaffPhone;
        private System.Windows.Forms.Button btnSearchStaff;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgBookSelected;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgBookList;
        private System.Windows.Forms.Button btnChoise;
        private System.Windows.Forms.Button btnDeleteSelect;
    }
}