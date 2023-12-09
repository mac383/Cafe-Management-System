namespace Cafe_Management_System.Forms.Services.UserControls
{
    partial class UC_ServicesSubButtons
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
            this.btn_servicesdepartment = new Guna.UI2.WinForms.Guna2Button();
            this.btn_services = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // btn_servicesdepartment
            // 
            this.btn_servicesdepartment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_servicesdepartment.BackColor = System.Drawing.Color.Transparent;
            this.btn_servicesdepartment.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_servicesdepartment.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(108)))), ((int)(((byte)(190)))));
            this.btn_servicesdepartment.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btn_servicesdepartment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_servicesdepartment.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btn_servicesdepartment.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_servicesdepartment.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_servicesdepartment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_servicesdepartment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_servicesdepartment.FillColor = System.Drawing.Color.Transparent;
            this.btn_servicesdepartment.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn_servicesdepartment.ForeColor = System.Drawing.Color.Black;
            this.btn_servicesdepartment.Location = new System.Drawing.Point(860, 3);
            this.btn_servicesdepartment.Name = "btn_servicesdepartment";
            this.btn_servicesdepartment.Size = new System.Drawing.Size(215, 45);
            this.btn_servicesdepartment.TabIndex = 11;
            this.btn_servicesdepartment.Text = "اقسام الخدمات";
            this.btn_servicesdepartment.Click += new System.EventHandler(this.btn_servicesdepartment_Click);
            // 
            // btn_services
            // 
            this.btn_services.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_services.BackColor = System.Drawing.Color.Transparent;
            this.btn_services.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btn_services.CheckedState.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(108)))), ((int)(((byte)(190)))));
            this.btn_services.CheckedState.FillColor = System.Drawing.Color.Transparent;
            this.btn_services.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_services.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.btn_services.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_services.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_services.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_services.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_services.FillColor = System.Drawing.Color.Transparent;
            this.btn_services.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn_services.ForeColor = System.Drawing.Color.Black;
            this.btn_services.Location = new System.Drawing.Point(1082, 3);
            this.btn_services.Name = "btn_services";
            this.btn_services.Size = new System.Drawing.Size(215, 45);
            this.btn_services.TabIndex = 10;
            this.btn_services.Text = "الخدمات";
            this.btn_services.Click += new System.EventHandler(this.btn_services_Click);
            // 
            // UC_ServicesSubButtons
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.btn_servicesdepartment);
            this.Controls.Add(this.btn_services);
            this.Name = "UC_ServicesSubButtons";
            this.Size = new System.Drawing.Size(1300, 50);
            this.Load += new System.EventHandler(this.UC_ServicesSubButtons_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btn_servicesdepartment;
        private Guna.UI2.WinForms.Guna2Button btn_services;
    }
}
