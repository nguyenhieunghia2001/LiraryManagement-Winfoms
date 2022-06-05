namespace LiraryManagerment.Views
{
    partial class CollectFines
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
            this.lbTitle = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtStaff = new System.Windows.Forms.TextBox();
            this.txtDebt = new System.Windows.Forms.TextBox();
            this.cbbReader = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbDebt = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMoneyReceive = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMoneyDebtAfterPay = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbTitle.Location = new System.Drawing.Point(407, 50);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(240, 46);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "Thu Tiền Phạt";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(438, 592);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(171, 46);
            this.btnSubmit.TabIndex = 27;
            this.btnSubmit.Text = "Xác nhận";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtStaff
            // 
            this.txtStaff.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtStaff.Location = new System.Drawing.Point(373, 498);
            this.txtStaff.Name = "txtStaff";
            this.txtStaff.ReadOnly = true;
            this.txtStaff.Size = new System.Drawing.Size(317, 31);
            this.txtStaff.TabIndex = 37;
            // 
            // txtDebt
            // 
            this.txtDebt.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDebt.Location = new System.Drawing.Point(373, 251);
            this.txtDebt.Name = "txtDebt";
            this.txtDebt.ReadOnly = true;
            this.txtDebt.Size = new System.Drawing.Size(317, 31);
            this.txtDebt.TabIndex = 36;
            // 
            // cbbReader
            // 
            this.cbbReader.DisplayMember = "HoTen";
            this.cbbReader.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbbReader.FormattingEnabled = true;
            this.cbbReader.Location = new System.Drawing.Point(373, 166);
            this.cbbReader.Name = "cbbReader";
            this.cbbReader.Size = new System.Drawing.Size(317, 33);
            this.cbbReader.TabIndex = 35;
            this.cbbReader.ValueMember = "Id";
            this.cbbReader.SelectedIndexChanged += new System.EventHandler(this.cbbReader_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(165, 504);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 25);
            this.label2.TabIndex = 32;
            this.label2.Text = "Người ghi nhận\r\n";
            // 
            // lbDebt
            // 
            this.lbDebt.AutoSize = true;
            this.lbDebt.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbDebt.Location = new System.Drawing.Point(168, 257);
            this.lbDebt.Name = "lbDebt";
            this.lbDebt.Size = new System.Drawing.Size(70, 25);
            this.lbDebt.TabIndex = 31;
            this.lbDebt.Text = "Tiền nợ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(165, 174);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(130, 25);
            this.label8.TabIndex = 30;
            this.label8.Text = "Họ tên đọc giả";
            // 
            // txtMoneyReceive
            // 
            this.txtMoneyReceive.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMoneyReceive.Location = new System.Drawing.Point(373, 329);
            this.txtMoneyReceive.Name = "txtMoneyReceive";
            this.txtMoneyReceive.Size = new System.Drawing.Size(317, 31);
            this.txtMoneyReceive.TabIndex = 39;
            this.txtMoneyReceive.TextChanged += new System.EventHandler(this.txtMoneyReceive_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(168, 335);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 25);
            this.label3.TabIndex = 38;
            this.label3.Text = "Tiền thu";
            // 
            // txtMoneyDebtAfterPay
            // 
            this.txtMoneyDebtAfterPay.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMoneyDebtAfterPay.Location = new System.Drawing.Point(373, 410);
            this.txtMoneyDebtAfterPay.Name = "txtMoneyDebtAfterPay";
            this.txtMoneyDebtAfterPay.ReadOnly = true;
            this.txtMoneyDebtAfterPay.Size = new System.Drawing.Size(317, 31);
            this.txtMoneyDebtAfterPay.TabIndex = 41;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(168, 416);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 25);
            this.label4.TabIndex = 40;
            this.label4.Text = "Còn lại";
            // 
            // CollectFines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 795);
            this.Controls.Add(this.txtMoneyDebtAfterPay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMoneyReceive);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtStaff);
            this.Controls.Add(this.txtDebt);
            this.Controls.Add(this.cbbReader);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbDebt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbTitle);
            this.Name = "CollectFines";
            this.Text = "CollectFines";
            this.Load += new System.EventHandler(this.CollectFines_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtStaff;
        private System.Windows.Forms.TextBox txtDebt;
        private System.Windows.Forms.ComboBox cbbReader;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbDebt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMoneyReceive;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMoneyDebtAfterPay;
        private System.Windows.Forms.Label label4;
    }
}