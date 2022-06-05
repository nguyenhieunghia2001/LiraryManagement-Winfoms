
namespace LiraryManagerment.Views
{
    partial class ReturnBooks
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
            this.rb_lb_title = new System.Windows.Forms.Label();
            this.rb_lb_KiemTraPhieuMuon = new System.Windows.Forms.Label();
            this.rb_tb_KiemTraPhieuMuon = new System.Windows.Forms.TextBox();
            this.rb_btn_KiemTraPhieuMuon = new System.Windows.Forms.Button();
            this.rb_dgv_KiemTraPhieuMuon = new System.Windows.Forms.DataGridView();
            this.rb_lb_HovaTen = new System.Windows.Forms.Label();
            this.rb_tb_HovaTen = new System.Windows.Forms.TextBox();
            this.rb_lb_NgayTra = new System.Windows.Forms.Label();
            this.rb_dtp_NgayTra = new System.Windows.Forms.DateTimePicker();
            this.rb_lb_SoTienNo = new System.Windows.Forms.Label();
            this.rb_tb_SoTienNo = new System.Windows.Forms.TextBox();
            this.rb_lb_SoTienPhat = new System.Windows.Forms.Label();
            this.rb_tb_SoTienPhat = new System.Windows.Forms.TextBox();
            this.rb_btn_XacNhan = new System.Windows.Forms.Button();
            this.rb_btn_Huy = new System.Windows.Forms.Button();
            this.rb_lb_IdDocGia = new System.Windows.Forms.Label();
            this.rb_tb_IdDocGia = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.rb_dgv_KiemTraPhieuMuon)).BeginInit();
            this.SuspendLayout();
            // 
            // rb_lb_title
            // 
            this.rb_lb_title.AutoSize = true;
            this.rb_lb_title.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rb_lb_title.Location = new System.Drawing.Point(332, 19);
            this.rb_lb_title.Name = "rb_lb_title";
            this.rb_lb_title.Size = new System.Drawing.Size(246, 46);
            this.rb_lb_title.TabIndex = 2;
            this.rb_lb_title.Text = "Nhận Trả Sách";
            // 
            // rb_lb_KiemTraPhieuMuon
            // 
            this.rb_lb_KiemTraPhieuMuon.AutoSize = true;
            this.rb_lb_KiemTraPhieuMuon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rb_lb_KiemTraPhieuMuon.Location = new System.Drawing.Point(91, 101);
            this.rb_lb_KiemTraPhieuMuon.Name = "rb_lb_KiemTraPhieuMuon";
            this.rb_lb_KiemTraPhieuMuon.Size = new System.Drawing.Size(197, 28);
            this.rb_lb_KiemTraPhieuMuon.TabIndex = 3;
            this.rb_lb_KiemTraPhieuMuon.Text = "Kiểm Tra Phiếu Mượn";
            // 
            // rb_tb_KiemTraPhieuMuon
            // 
            this.rb_tb_KiemTraPhieuMuon.Location = new System.Drawing.Point(298, 102);
            this.rb_tb_KiemTraPhieuMuon.Name = "rb_tb_KiemTraPhieuMuon";
            this.rb_tb_KiemTraPhieuMuon.Size = new System.Drawing.Size(290, 27);
            this.rb_tb_KiemTraPhieuMuon.TabIndex = 4;
            // 
            // rb_btn_KiemTraPhieuMuon
            // 
            this.rb_btn_KiemTraPhieuMuon.Location = new System.Drawing.Point(612, 98);
            this.rb_btn_KiemTraPhieuMuon.Name = "rb_btn_KiemTraPhieuMuon";
            this.rb_btn_KiemTraPhieuMuon.Size = new System.Drawing.Size(115, 35);
            this.rb_btn_KiemTraPhieuMuon.TabIndex = 5;
            this.rb_btn_KiemTraPhieuMuon.Text = "Kiểm Tra";
            this.rb_btn_KiemTraPhieuMuon.UseVisualStyleBackColor = true;
            this.rb_btn_KiemTraPhieuMuon.Click += new System.EventHandler(this.rb_btn_KiemTraPhieuMuon_Click);
            // 
            // rb_dgv_KiemTraPhieuMuon
            // 
            this.rb_dgv_KiemTraPhieuMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rb_dgv_KiemTraPhieuMuon.Location = new System.Drawing.Point(60, 155);
            this.rb_dgv_KiemTraPhieuMuon.Name = "rb_dgv_KiemTraPhieuMuon";
            this.rb_dgv_KiemTraPhieuMuon.RowHeadersWidth = 51;
            this.rb_dgv_KiemTraPhieuMuon.RowTemplate.Height = 29;
            this.rb_dgv_KiemTraPhieuMuon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.rb_dgv_KiemTraPhieuMuon.Size = new System.Drawing.Size(807, 335);
            this.rb_dgv_KiemTraPhieuMuon.TabIndex = 6;
            // 
            // rb_lb_HovaTen
            // 
            this.rb_lb_HovaTen.AutoSize = true;
            this.rb_lb_HovaTen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rb_lb_HovaTen.Location = new System.Drawing.Point(60, 589);
            this.rb_lb_HovaTen.Name = "rb_lb_HovaTen";
            this.rb_lb_HovaTen.Size = new System.Drawing.Size(97, 28);
            this.rb_lb_HovaTen.TabIndex = 7;
            this.rb_lb_HovaTen.Text = "Họ và Tên";
            // 
            // rb_tb_HovaTen
            // 
            this.rb_tb_HovaTen.Location = new System.Drawing.Point(176, 589);
            this.rb_tb_HovaTen.Name = "rb_tb_HovaTen";
            this.rb_tb_HovaTen.Size = new System.Drawing.Size(242, 27);
            this.rb_tb_HovaTen.TabIndex = 8;
            // 
            // rb_lb_NgayTra
            // 
            this.rb_lb_NgayTra.AutoSize = true;
            this.rb_lb_NgayTra.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rb_lb_NgayTra.Location = new System.Drawing.Point(477, 523);
            this.rb_lb_NgayTra.Name = "rb_lb_NgayTra";
            this.rb_lb_NgayTra.Size = new System.Drawing.Size(89, 28);
            this.rb_lb_NgayTra.TabIndex = 9;
            this.rb_lb_NgayTra.Text = "Ngày Trả";
            // 
            // rb_dtp_NgayTra
            // 
            this.rb_dtp_NgayTra.Location = new System.Drawing.Point(590, 522);
            this.rb_dtp_NgayTra.Name = "rb_dtp_NgayTra";
            this.rb_dtp_NgayTra.Size = new System.Drawing.Size(277, 27);
            this.rb_dtp_NgayTra.TabIndex = 10;
            // 
            // rb_lb_SoTienNo
            // 
            this.rb_lb_SoTienNo.AutoSize = true;
            this.rb_lb_SoTienNo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rb_lb_SoTienNo.Location = new System.Drawing.Point(458, 588);
            this.rb_lb_SoTienNo.Name = "rb_lb_SoTienNo";
            this.rb_lb_SoTienNo.Size = new System.Drawing.Size(108, 28);
            this.rb_lb_SoTienNo.TabIndex = 11;
            this.rb_lb_SoTienNo.Text = "Số Tiền Nợ";
            // 
            // rb_tb_SoTienNo
            // 
            this.rb_tb_SoTienNo.Location = new System.Drawing.Point(590, 589);
            this.rb_tb_SoTienNo.Name = "rb_tb_SoTienNo";
            this.rb_tb_SoTienNo.Size = new System.Drawing.Size(277, 27);
            this.rb_tb_SoTienNo.TabIndex = 12;
            // 
            // rb_lb_SoTienPhat
            // 
            this.rb_lb_SoTienPhat.AutoSize = true;
            this.rb_lb_SoTienPhat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rb_lb_SoTienPhat.Location = new System.Drawing.Point(446, 647);
            this.rb_lb_SoTienPhat.Name = "rb_lb_SoTienPhat";
            this.rb_lb_SoTienPhat.Size = new System.Drawing.Size(120, 28);
            this.rb_lb_SoTienPhat.TabIndex = 13;
            this.rb_lb_SoTienPhat.Text = "Số Tiền Phạt";
            // 
            // rb_tb_SoTienPhat
            // 
            this.rb_tb_SoTienPhat.Location = new System.Drawing.Point(590, 647);
            this.rb_tb_SoTienPhat.Name = "rb_tb_SoTienPhat";
            this.rb_tb_SoTienPhat.Size = new System.Drawing.Size(277, 27);
            this.rb_tb_SoTienPhat.TabIndex = 14;
            // 
            // rb_btn_XacNhan
            // 
            this.rb_btn_XacNhan.BackColor = System.Drawing.Color.Lime;
            this.rb_btn_XacNhan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rb_btn_XacNhan.Location = new System.Drawing.Point(539, 702);
            this.rb_btn_XacNhan.Name = "rb_btn_XacNhan";
            this.rb_btn_XacNhan.Size = new System.Drawing.Size(143, 40);
            this.rb_btn_XacNhan.TabIndex = 15;
            this.rb_btn_XacNhan.Text = "Xác Nhận";
            this.rb_btn_XacNhan.UseVisualStyleBackColor = false;
            this.rb_btn_XacNhan.Click += new System.EventHandler(this.rb_btn_XacNhan_Click);
            // 
            // rb_btn_Huy
            // 
            this.rb_btn_Huy.Location = new System.Drawing.Point(719, 702);
            this.rb_btn_Huy.Name = "rb_btn_Huy";
            this.rb_btn_Huy.Size = new System.Drawing.Size(148, 40);
            this.rb_btn_Huy.TabIndex = 16;
            this.rb_btn_Huy.Text = "Hủy";
            this.rb_btn_Huy.UseVisualStyleBackColor = true;
            // 
            // rb_lb_IdDocGia
            // 
            this.rb_lb_IdDocGia.AutoSize = true;
            this.rb_lb_IdDocGia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rb_lb_IdDocGia.Location = new System.Drawing.Point(60, 533);
            this.rb_lb_IdDocGia.Name = "rb_lb_IdDocGia";
            this.rb_lb_IdDocGia.Size = new System.Drawing.Size(103, 28);
            this.rb_lb_IdDocGia.TabIndex = 17;
            this.rb_lb_IdDocGia.Text = "Id Đọc Giả";
            // 
            // rb_tb_IdDocGia
            // 
            this.rb_tb_IdDocGia.Location = new System.Drawing.Point(187, 537);
            this.rb_tb_IdDocGia.Name = "rb_tb_IdDocGia";
            this.rb_tb_IdDocGia.Size = new System.Drawing.Size(231, 27);
            this.rb_tb_IdDocGia.TabIndex = 18;
            // 
            // ReturnBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 754);
            this.Controls.Add(this.rb_tb_IdDocGia);
            this.Controls.Add(this.rb_lb_IdDocGia);
            this.Controls.Add(this.rb_btn_Huy);
            this.Controls.Add(this.rb_btn_XacNhan);
            this.Controls.Add(this.rb_tb_SoTienPhat);
            this.Controls.Add(this.rb_lb_SoTienPhat);
            this.Controls.Add(this.rb_tb_SoTienNo);
            this.Controls.Add(this.rb_lb_SoTienNo);
            this.Controls.Add(this.rb_dtp_NgayTra);
            this.Controls.Add(this.rb_lb_NgayTra);
            this.Controls.Add(this.rb_tb_HovaTen);
            this.Controls.Add(this.rb_lb_HovaTen);
            this.Controls.Add(this.rb_dgv_KiemTraPhieuMuon);
            this.Controls.Add(this.rb_btn_KiemTraPhieuMuon);
            this.Controls.Add(this.rb_tb_KiemTraPhieuMuon);
            this.Controls.Add(this.rb_lb_KiemTraPhieuMuon);
            this.Controls.Add(this.rb_lb_title);
            this.Name = "ReturnBooks";
            this.Text = "Return Book";
            this.Load += new System.EventHandler(this.ReturnBooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rb_dgv_KiemTraPhieuMuon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label rb_lb_title;
        private System.Windows.Forms.Label rb_lb_KiemTraPhieuMuon;
        private System.Windows.Forms.TextBox rb_tb_KiemTraPhieuMuon;
        private System.Windows.Forms.Button rb_btn_KiemTraPhieuMuon;
        private System.Windows.Forms.DataGridView rb_dgv_KiemTraPhieuMuon;
        private System.Windows.Forms.Label rb_lb_HovaTen;
        private System.Windows.Forms.TextBox rb_tb_HovaTen;
        private System.Windows.Forms.Label rb_lb_NgayTra;
        private System.Windows.Forms.DateTimePicker rb_dtp_NgayTra;
        private System.Windows.Forms.Label rb_lb_SoTienNo;
        private System.Windows.Forms.TextBox rb_tb_SoTienNo;
        private System.Windows.Forms.Label rb_lb_SoTienPhat;
        private System.Windows.Forms.TextBox rb_tb_SoTienPhat;
        private System.Windows.Forms.Button rb_btn_XacNhan;
        private System.Windows.Forms.Button rb_btn_Huy;
        private System.Windows.Forms.Label rb_lb_IdDocGia;
        private System.Windows.Forms.TextBox rb_tb_IdDocGia;
    }
}