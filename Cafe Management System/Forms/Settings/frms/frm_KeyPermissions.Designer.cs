namespace Cafe_Management_System.Forms.Settings.frms
{
    partial class frm_KeyPermissions
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
            this.pnl_body = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.lbl_title = new System.Windows.Forms.Label();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.pnl_body.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_body
            // 
            this.pnl_body.BackColor = System.Drawing.Color.Transparent;
            this.pnl_body.Controls.Add(this.guna2Separator1);
            this.pnl_body.Controls.Add(this.lbl_title);
            this.pnl_body.Controls.Add(this.guna2ControlBox1);
            this.pnl_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_body.FillColor = System.Drawing.Color.White;
            this.pnl_body.Location = new System.Drawing.Point(0, 0);
            this.pnl_body.Name = "pnl_body";
            this.pnl_body.Radius = 10;
            this.pnl_body.ShadowColor = System.Drawing.Color.Black;
            this.pnl_body.ShadowDepth = 150;
            this.pnl_body.ShadowShift = 10;
            this.pnl_body.Size = new System.Drawing.Size(1020, 612);
            this.pnl_body.TabIndex = 2;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator1.FillColor = System.Drawing.Color.Gray;
            this.guna2Separator1.FillThickness = 2;
            this.guna2Separator1.Location = new System.Drawing.Point(15, 57);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(991, 10);
            this.guna2Separator1.TabIndex = 2;
            // 
            // lbl_title
            // 
            this.lbl_title.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_title.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_title.Location = new System.Drawing.Point(300, 18);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_title.Size = new System.Drawing.Size(699, 36);
            this.lbl_title.TabIndex = 1;
            this.lbl_title.Text = "صلاحيات المفتاح";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
            this.guna2ControlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.Gray;
            this.guna2ControlBox1.Location = new System.Drawing.Point(15, 18);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(40, 40);
            this.guna2ControlBox1.TabIndex = 0;
            // 
            // frm_KeyPermissions
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1020, 612);
            this.Controls.Add(this.pnl_body);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_KeyPermissions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_KeyPermissions";
            this.Load += new System.EventHandler(this.frm_KeyPermissions_Load);
            this.pnl_body.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel pnl_body;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Label lbl_title;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
    }
}