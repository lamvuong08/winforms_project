namespace NhaKhoa.UI
{
    partial class FormInDanhMuc
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
            this.rpInDanhMuc = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rpInDanhMuc
            // 
            this.rpInDanhMuc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpInDanhMuc.Location = new System.Drawing.Point(0, 0);
            this.rpInDanhMuc.Margin = new System.Windows.Forms.Padding(2);
            this.rpInDanhMuc.Name = "rpInDanhMuc";
            this.rpInDanhMuc.ServerReport.BearerToken = null;
            this.rpInDanhMuc.Size = new System.Drawing.Size(600, 366);
            this.rpInDanhMuc.TabIndex = 0;
            // 
            // FormInDanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.rpInDanhMuc);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormInDanhMuc";
            this.Text = "FormInDanhMuc";
            this.Load += new System.EventHandler(this.FormInDanhMuc_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpInDanhMuc;
    }
}