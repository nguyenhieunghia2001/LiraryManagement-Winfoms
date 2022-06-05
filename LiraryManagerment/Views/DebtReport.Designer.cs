namespace LiraryManagerment.Views
{
    partial class DebtReport
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_BaoCao = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_TongTienNo = new System.Windows.Forms.TextBox();
            this.dtp_Ngay = new System.Windows.Forms.DateTimePicker();
            this.btn_XemBaoCao = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BaoCao)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(172, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(623, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Báo Cáo Thống Kê Độc Giả Nợ Tiền Phạt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(311, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày";
            // 
            // dgv_BaoCao
            // 
            this.dgv_BaoCao.AllowUserToAddRows = false;
            this.dgv_BaoCao.AllowUserToDeleteRows = false;
            this.dgv_BaoCao.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_BaoCao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_BaoCao.Location = new System.Drawing.Point(12, 219);
            this.dgv_BaoCao.Name = "dgv_BaoCao";
            this.dgv_BaoCao.RowHeadersWidth = 51;
            this.dgv_BaoCao.RowTemplate.Height = 29;
            this.dgv_BaoCao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_BaoCao.Size = new System.Drawing.Size(939, 337);
            this.dgv_BaoCao.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(641, 591);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tổng tiền nợ";
            // 
            // tb_TongTienNo
            // 
            this.tb_TongTienNo.Enabled = false;
            this.tb_TongTienNo.Location = new System.Drawing.Point(763, 584);
            this.tb_TongTienNo.Name = "tb_TongTienNo";
            this.tb_TongTienNo.Size = new System.Drawing.Size(125, 27);
            this.tb_TongTienNo.TabIndex = 5;
            // 
            // dtp_Ngay
            // 
            this.dtp_Ngay.Location = new System.Drawing.Point(379, 142);
            this.dtp_Ngay.Name = "dtp_Ngay";
            this.dtp_Ngay.Size = new System.Drawing.Size(250, 27);
            this.dtp_Ngay.TabIndex = 6;
            // 
            // btn_XemBaoCao
            // 
            this.btn_XemBaoCao.Location = new System.Drawing.Point(641, 145);
            this.btn_XemBaoCao.Name = "btn_XemBaoCao";
            this.btn_XemBaoCao.Size = new System.Drawing.Size(123, 29);
            this.btn_XemBaoCao.TabIndex = 7;
            this.btn_XemBaoCao.Text = "Xem báo  cáo";
            this.btn_XemBaoCao.UseVisualStyleBackColor = true;
            this.btn_XemBaoCao.Click += new System.EventHandler(this.btn_XemBaoCao_Click);
            // 
            // DebtReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 795);
            this.Controls.Add(this.btn_XemBaoCao);
            this.Controls.Add(this.dtp_Ngay);
            this.Controls.Add(this.tb_TongTienNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgv_BaoCao);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DebtReport";
            this.Text = "DebtReport";
            this.Load += new System.EventHandler(this.DebtReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_BaoCao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_BaoCao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_TongTienNo;
        private System.Windows.Forms.DateTimePicker dtp_Ngay;
        private System.Windows.Forms.Button btn_XemBaoCao;
    }
}