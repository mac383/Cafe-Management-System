namespace Cafe_Management_System.Forms.Settings.UserControls
{
    partial class UC_Key
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
            this.components = new System.ComponentModel.Container();
            this.separaterline = new Guna.UI2.WinForms.Guna2Separator();
            this.lbl_key = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btn_showmore = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btn_copykey = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btn_deletekey = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btn_editkey = new Guna.UI2.WinForms.Guna2ImageButton();
            this.lbl_username = new System.Windows.Forms.LinkLabel();
            this.lbl_createdkeydate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // separaterline
            // 
            this.separaterline.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.separaterline.Location = new System.Drawing.Point(21, 87);
            this.separaterline.Name = "separaterline";
            this.separaterline.Size = new System.Drawing.Size(797, 10);
            this.separaterline.TabIndex = 20;
            // 
            // lbl_key
            // 
            this.lbl_key.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_key.BackColor = System.Drawing.Color.Transparent;
            this.lbl_key.Font = new System.Drawing.Font("Segoe UI", 10.75F, System.Drawing.FontStyle.Bold);
            this.lbl_key.ForeColor = System.Drawing.Color.Black;
            this.lbl_key.Location = new System.Drawing.Point(35, 12);
            this.lbl_key.Name = "lbl_key";
            this.lbl_key.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_key.Size = new System.Drawing.Size(486, 45);
            this.lbl_key.TabIndex = 22;
            this.lbl_key.Text = "LDOW-IRLA-89-mac383-KAOM";
            this.lbl_key.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_showmore
            // 
            this.btn_showmore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_showmore.BackColor = System.Drawing.Color.Transparent;
            this.btn_showmore.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_showmore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_showmore.HoverState.ImageSize = new System.Drawing.Size(27, 27);
            this.btn_showmore.Image = global::Cafe_Management_System.Properties.Resources.more_info;
            this.btn_showmore.ImageOffset = new System.Drawing.Point(0, 0);
            this.btn_showmore.ImageRotate = 0F;
            this.btn_showmore.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_showmore.Location = new System.Drawing.Point(788, 35);
            this.btn_showmore.Name = "btn_showmore";
            this.btn_showmore.PressedState.ImageSize = new System.Drawing.Size(26, 26);
            this.btn_showmore.Size = new System.Drawing.Size(30, 30);
            this.btn_showmore.TabIndex = 26;
            this.btn_showmore.Tag = "";
            this.toolTip1.SetToolTip(this.btn_showmore, "عرض صلاحيات المفتاح");
            this.btn_showmore.Click += new System.EventHandler(this.btn_showmore_Click);
            // 
            // btn_copykey
            // 
            this.btn_copykey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_copykey.BackColor = System.Drawing.Color.Transparent;
            this.btn_copykey.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_copykey.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_copykey.HoverState.ImageSize = new System.Drawing.Size(27, 27);
            this.btn_copykey.Image = global::Cafe_Management_System.Properties.Resources.copy;
            this.btn_copykey.ImageOffset = new System.Drawing.Point(0, 0);
            this.btn_copykey.ImageRotate = 0F;
            this.btn_copykey.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_copykey.Location = new System.Drawing.Point(674, 35);
            this.btn_copykey.Name = "btn_copykey";
            this.btn_copykey.PressedState.ImageSize = new System.Drawing.Size(26, 26);
            this.btn_copykey.Size = new System.Drawing.Size(30, 30);
            this.btn_copykey.TabIndex = 25;
            this.btn_copykey.Tag = "";
            this.toolTip1.SetToolTip(this.btn_copykey, "نسخ المفتاح");
            this.btn_copykey.Click += new System.EventHandler(this.btn_copykey_Click);
            // 
            // btn_deletekey
            // 
            this.btn_deletekey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_deletekey.BackColor = System.Drawing.Color.Transparent;
            this.btn_deletekey.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_deletekey.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_deletekey.HoverState.ImageSize = new System.Drawing.Size(27, 27);
            this.btn_deletekey.Image = global::Cafe_Management_System.Properties.Resources.delete32;
            this.btn_deletekey.ImageOffset = new System.Drawing.Point(0, 0);
            this.btn_deletekey.ImageRotate = 0F;
            this.btn_deletekey.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_deletekey.Location = new System.Drawing.Point(712, 35);
            this.btn_deletekey.Name = "btn_deletekey";
            this.btn_deletekey.PressedState.ImageSize = new System.Drawing.Size(26, 26);
            this.btn_deletekey.Size = new System.Drawing.Size(30, 30);
            this.btn_deletekey.TabIndex = 24;
            this.btn_deletekey.Tag = "";
            this.toolTip1.SetToolTip(this.btn_deletekey, "حذف المفتاح");
            this.btn_deletekey.Click += new System.EventHandler(this.btn_deletekey_Click);
            // 
            // btn_editkey
            // 
            this.btn_editkey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_editkey.BackColor = System.Drawing.Color.Transparent;
            this.btn_editkey.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_editkey.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_editkey.HoverState.ImageSize = new System.Drawing.Size(27, 27);
            this.btn_editkey.Image = global::Cafe_Management_System.Properties.Resources.edit32;
            this.btn_editkey.ImageOffset = new System.Drawing.Point(0, 0);
            this.btn_editkey.ImageRotate = 0F;
            this.btn_editkey.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_editkey.Location = new System.Drawing.Point(750, 35);
            this.btn_editkey.Name = "btn_editkey";
            this.btn_editkey.PressedState.ImageSize = new System.Drawing.Size(26, 26);
            this.btn_editkey.Size = new System.Drawing.Size(30, 30);
            this.btn_editkey.TabIndex = 23;
            this.btn_editkey.Tag = "";
            this.toolTip1.SetToolTip(this.btn_editkey, "تعديل صلاحيات المفتاح");
            this.btn_editkey.Click += new System.EventHandler(this.btn_editkey_Click);
            // 
            // lbl_username
            // 
            this.lbl_username.BackColor = System.Drawing.Color.Transparent;
            this.lbl_username.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.Location = new System.Drawing.Point(47, 48);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(126, 25);
            this.lbl_username.TabIndex = 29;
            this.lbl_username.TabStop = true;
            this.lbl_username.Text = "mac383";
            this.lbl_username.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_username.VisitedLinkColor = System.Drawing.Color.Blue;
            // 
            // lbl_createdkeydate
            // 
            this.lbl_createdkeydate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_createdkeydate.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_createdkeydate.Location = new System.Drawing.Point(527, 38);
            this.lbl_createdkeydate.Name = "lbl_createdkeydate";
            this.lbl_createdkeydate.Size = new System.Drawing.Size(141, 25);
            this.lbl_createdkeydate.TabIndex = 30;
            this.lbl_createdkeydate.Text = "2023-1-3";
            this.lbl_createdkeydate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UC_Key
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lbl_createdkeydate);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.btn_showmore);
            this.Controls.Add(this.btn_copykey);
            this.Controls.Add(this.btn_deletekey);
            this.Controls.Add(this.btn_editkey);
            this.Controls.Add(this.lbl_key);
            this.Controls.Add(this.separaterline);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UC_Key";
            this.Size = new System.Drawing.Size(838, 100);
            this.Load += new System.EventHandler(this.UC_Key_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Separator separaterline;
        private System.Windows.Forms.Label lbl_key;
        private Guna.UI2.WinForms.Guna2ImageButton btn_deletekey;
        private Guna.UI2.WinForms.Guna2ImageButton btn_editkey;
        private System.Windows.Forms.ToolTip toolTip1;
        private Guna.UI2.WinForms.Guna2ImageButton btn_copykey;
        private Guna.UI2.WinForms.Guna2ImageButton btn_showmore;
        private System.Windows.Forms.LinkLabel lbl_username;
        private System.Windows.Forms.Label lbl_createdkeydate;
    }
}
