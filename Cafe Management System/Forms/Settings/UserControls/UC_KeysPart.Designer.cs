namespace Cafe_Management_System.Forms.Settings.UserControls
{
    partial class UC_KeysPart
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gb_container = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btn_addnew = new Guna.UI2.WinForms.Guna2Button();
            this.gb_container.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_container
            // 
            this.gb_container.BackColor = System.Drawing.Color.Transparent;
            this.gb_container.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gb_container.BorderRadius = 6;
            this.gb_container.Controls.Add(this.btn_addnew);
            this.gb_container.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.gb_container.CustomBorderThickness = new System.Windows.Forms.Padding(0, 80, 0, 0);
            this.gb_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gb_container.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gb_container.ForeColor = System.Drawing.Color.Black;
            this.gb_container.Location = new System.Drawing.Point(0, 0);
            this.gb_container.Name = "gb_container";
            this.gb_container.Size = new System.Drawing.Size(1000, 500);
            this.gb_container.TabIndex = 1;
            this.gb_container.Text = "مفاتيح النظام";
            this.gb_container.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.gb_container.TextOffset = new System.Drawing.Point(0, 20);
            // 
            // btn_addnew
            // 
            this.btn_addnew.BorderColor = System.Drawing.Color.Gray;
            this.btn_addnew.BorderRadius = 5;
            this.btn_addnew.BorderThickness = 1;
            this.btn_addnew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_addnew.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_addnew.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_addnew.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_addnew.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_addnew.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.btn_addnew.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_addnew.ForeColor = System.Drawing.Color.Black;
            this.btn_addnew.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(108)))), ((int)(((byte)(190)))));
            this.btn_addnew.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_addnew.Location = new System.Drawing.Point(81, 17);
            this.btn_addnew.Name = "btn_addnew";
            this.btn_addnew.Size = new System.Drawing.Size(175, 45);
            this.btn_addnew.TabIndex = 29;
            this.btn_addnew.Text = "إضافة جديد";
            this.btn_addnew.Click += new System.EventHandler(this.btn_addnew_Click);
            // 
            // UC_KeysPart
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gb_container);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UC_KeysPart";
            this.Size = new System.Drawing.Size(1000, 500);
            this.Load += new System.EventHandler(this.UC_KeysPart_Load);
            this.gb_container.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox gb_container;
        private Guna.UI2.WinForms.Guna2Button btn_addnew;
    }
}
