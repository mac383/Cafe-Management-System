namespace Cafe_Management_System.Forms.Settings.UserControls
{
    partial class UC_Settings
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
            this.uC_CurrentUserProfile1 = new Cafe_Management_System.Forms.Settings.UserControls.UC_CurrentUserProfile();
            this.flp_container.SuspendLayout();
            this.SuspendLayout();
            // 
            // flp_container
            // 
            this.flp_container.Controls.Add(this.uC_CurrentUserProfile1);
            this.flp_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flp_container.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flp_container.Location = new System.Drawing.Point(0, 0);
            this.flp_container.Name = "flp_container";
            this.flp_container.Size = new System.Drawing.Size(1300, 700);
            this.flp_container.TabIndex = 0;
            // 
            // uC_CurrentUserProfile1
            // 
            this.uC_CurrentUserProfile1.BackColor = System.Drawing.Color.White;
            this.uC_CurrentUserProfile1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uC_CurrentUserProfile1.ForeColor = System.Drawing.Color.Black;
            this.uC_CurrentUserProfile1.Location = new System.Drawing.Point(204, 3);
            this.uC_CurrentUserProfile1.Margin = new System.Windows.Forms.Padding(204, 3, 204, 3);
            this.uC_CurrentUserProfile1.MaximumSize = new System.Drawing.Size(0, 620);
            this.uC_CurrentUserProfile1.MinimumSize = new System.Drawing.Size(570, 460);
            this.uC_CurrentUserProfile1.Name = "uC_CurrentUserProfile1";
            this.uC_CurrentUserProfile1.Size = new System.Drawing.Size(854, 460);
            this.uC_CurrentUserProfile1.TabIndex = 0;
            // 
            // UC_Settings
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.flp_container);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UC_Settings";
            this.Size = new System.Drawing.Size(1300, 700);
            this.Load += new System.EventHandler(this.UC_Settings_Load);
            this.SizeChanged += new System.EventHandler(this.UC_Settings_SizeChanged);
            this.flp_container.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flp_container;
        private UC_CurrentUserProfile uC_CurrentUserProfile1;
    }
}
