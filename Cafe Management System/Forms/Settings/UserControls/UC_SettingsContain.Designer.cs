namespace Cafe_Management_System.Forms.Settings.UserControls
{
    partial class UC_SettingsContain
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
            this.flp_container = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.uC_CurrentUserProfile1 = new Cafe_Management_System.Forms.Settings.UserControls.UC_CurrentUserProfile();
            this.uC_SystemInfo1 = new Cafe_Management_System.Forms.Settings.UserControls.UC_SystemInfo();
            this.uC_KeysPart1 = new Cafe_Management_System.Forms.Settings.UserControls.UC_KeysPart();
            this.flp_container.SuspendLayout();
            this.SuspendLayout();
            // 
            // flp_container
            // 
            this.flp_container.AutoScroll = true;
            this.flp_container.AutoScrollMinSize = new System.Drawing.Size(0, 2000);
            this.flp_container.Controls.Add(this.uC_CurrentUserProfile1);
            this.flp_container.Controls.Add(this.guna2Separator1);
            this.flp_container.Controls.Add(this.uC_SystemInfo1);
            this.flp_container.Controls.Add(this.uC_KeysPart1);
            this.flp_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flp_container.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flp_container.Location = new System.Drawing.Point(0, 0);
            this.flp_container.Name = "flp_container";
            this.flp_container.Size = new System.Drawing.Size(1300, 700);
            this.flp_container.TabIndex = 1;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.FillColor = System.Drawing.Color.Gray;
            this.guna2Separator1.FillThickness = 2;
            this.guna2Separator1.Location = new System.Drawing.Point(223, 486);
            this.guna2Separator1.Margin = new System.Windows.Forms.Padding(223, 3, 3, 3);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(854, 10);
            this.guna2Separator1.TabIndex = 25;
            // 
            // uC_CurrentUserProfile1
            // 
            this.uC_CurrentUserProfile1.BackColor = System.Drawing.Color.White;
            this.uC_CurrentUserProfile1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uC_CurrentUserProfile1.ForeColor = System.Drawing.Color.Black;
            this.uC_CurrentUserProfile1.Location = new System.Drawing.Point(3, 3);
            this.uC_CurrentUserProfile1.MaximumSize = new System.Drawing.Size(0, 687);
            this.uC_CurrentUserProfile1.MinimumSize = new System.Drawing.Size(1140, 477);
            this.uC_CurrentUserProfile1.Name = "uC_CurrentUserProfile1";
            this.uC_CurrentUserProfile1.Size = new System.Drawing.Size(1140, 477);
            this.uC_CurrentUserProfile1.TabIndex = 0;
            this.uC_CurrentUserProfile1.OnUpdate += new System.Action<int>(this.uC_CurrentUserProfile1_OnUpdate);
            // 
            // uC_SystemInfo1
            // 
            this.uC_SystemInfo1.BackColor = System.Drawing.Color.White;
            this.uC_SystemInfo1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uC_SystemInfo1.Location = new System.Drawing.Point(3, 502);
            this.uC_SystemInfo1.MinimumSize = new System.Drawing.Size(854, 312);
            this.uC_SystemInfo1.Name = "uC_SystemInfo1";
            this.uC_SystemInfo1.Size = new System.Drawing.Size(854, 312);
            this.uC_SystemInfo1.TabIndex = 26;
            // 
            // uC_KeysPart1
            // 
            this.uC_KeysPart1.BackColor = System.Drawing.Color.White;
            this.uC_KeysPart1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uC_KeysPart1.Location = new System.Drawing.Point(3, 820);
            this.uC_KeysPart1.Name = "uC_KeysPart1";
            this.uC_KeysPart1.Size = new System.Drawing.Size(1000, 500);
            this.uC_KeysPart1.TabIndex = 27;
            // 
            // UC_SettingsContain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.flp_container);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UC_SettingsContain";
            this.Size = new System.Drawing.Size(1300, 700);
            this.Load += new System.EventHandler(this.UC_SettingsContain_Load);
            this.SizeChanged += new System.EventHandler(this.UC_SettingsContain_SizeChanged);
            this.flp_container.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flp_container;
        private UC_CurrentUserProfile uC_CurrentUserProfile1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private UC_SystemInfo uC_SystemInfo1;
        private UC_KeysPart uC_KeysPart1;
    }
}
