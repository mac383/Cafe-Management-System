namespace Cafe_Management_System.Forms.Users.UserControls
{
    partial class UC_UsersSubButtons
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
            this.btn_managementappusers = new Guna.UI2.WinForms.Guna2Button();
            this.btn_servicesappusers = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // btn_managementappusers
            // 
            this.btn_managementappusers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_managementappusers.BackColor = System.Drawing.Color.Transparent;
            this.btn_managementappusers.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_managementappusers.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(108)))), ((int)(((byte)(190)))));
            this.btn_managementappusers.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btn_managementappusers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_managementappusers.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btn_managementappusers.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_managementappusers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_managementappusers.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_managementappusers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_managementappusers.FillColor = System.Drawing.Color.Transparent;
            this.btn_managementappusers.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn_managementappusers.ForeColor = System.Drawing.Color.Black;
            this.btn_managementappusers.Location = new System.Drawing.Point(1005, 3);
            this.btn_managementappusers.Name = "btn_managementappusers";
            this.btn_managementappusers.Size = new System.Drawing.Size(288, 45);
            this.btn_managementappusers.TabIndex = 14;
            this.btn_managementappusers.Text = "مستخدمين برنامج الإدارة";
            this.btn_managementappusers.Click += new System.EventHandler(this.btn_managementappusers_Click);
            // 
            // btn_servicesappusers
            // 
            this.btn_servicesappusers.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_servicesappusers.BackColor = System.Drawing.Color.Transparent;
            this.btn_servicesappusers.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_servicesappusers.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(108)))), ((int)(((byte)(190)))));
            this.btn_servicesappusers.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btn_servicesappusers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_servicesappusers.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btn_servicesappusers.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_servicesappusers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_servicesappusers.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_servicesappusers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_servicesappusers.FillColor = System.Drawing.Color.Transparent;
            this.btn_servicesappusers.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn_servicesappusers.ForeColor = System.Drawing.Color.Black;
            this.btn_servicesappusers.Location = new System.Drawing.Point(707, 3);
            this.btn_servicesappusers.Name = "btn_servicesappusers";
            this.btn_servicesappusers.Size = new System.Drawing.Size(288, 45);
            this.btn_servicesappusers.TabIndex = 13;
            this.btn_servicesappusers.Text = "مستخدمين برنامج الخدمات";
            this.btn_servicesappusers.Click += new System.EventHandler(this.btn_servicesappusers_Click);
            // 
            // UC_UsersSubButtons
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.btn_managementappusers);
            this.Controls.Add(this.btn_servicesappusers);
            this.Name = "UC_UsersSubButtons";
            this.Size = new System.Drawing.Size(1300, 50);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btn_managementappusers;
        private Guna.UI2.WinForms.Guna2Button btn_servicesappusers;
    }
}
