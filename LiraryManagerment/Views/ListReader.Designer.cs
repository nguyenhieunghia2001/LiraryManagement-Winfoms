namespace LiraryManagerment.Views
{
    partial class ListReader
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
            this.dgv_ListReader = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListReader)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_ListReader
            // 
            this.dgv_ListReader.AllowUserToAddRows = false;
            this.dgv_ListReader.AllowUserToDeleteRows = false;
            this.dgv_ListReader.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ListReader.Location = new System.Drawing.Point(12, 160);
            this.dgv_ListReader.Name = "dgv_ListReader";
            this.dgv_ListReader.ReadOnly = true;
            this.dgv_ListReader.RowHeadersWidth = 51;
            this.dgv_ListReader.RowTemplate.Height = 29;
            this.dgv_ListReader.ShowEditingIcon = false;
            this.dgv_ListReader.Size = new System.Drawing.Size(931, 535);
            this.dgv_ListReader.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(311, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh sách Đọc Giả";
            // 
            // ListReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 754);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_ListReader);
            this.Name = "ListReader";
            this.Text = "ListReader";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ListReader_FormClosed);
            this.Load += new System.EventHandler(this.ListReader_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ListReader)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_ListReader;
        private System.Windows.Forms.Label label1;
    }
}