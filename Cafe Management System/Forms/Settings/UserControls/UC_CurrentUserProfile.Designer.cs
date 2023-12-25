namespace Cafe_Management_System.Forms.Settings.UserControls
{
    partial class UC_CurrentUserProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_CurrentUserProfile));
            this.pnl_passwordcontrolscontainer = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_savepassword = new Guna.UI2.WinForms.Guna2Button();
            this.txt_newpassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_oldpassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_changepassword = new System.Windows.Forms.LinkLabel();
            this.lbl_phone = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2Separator3 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_fullname = new System.Windows.Forms.Label();
            this.btn_update = new Guna.UI2.WinForms.Guna2Button();
            this.lbl_username = new System.Windows.Forms.Label();
            this.pic_userimage = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.pnl_passwordcontrolscontainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_userimage)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_passwordcontrolscontainer
            // 
            this.pnl_passwordcontrolscontainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_passwordcontrolscontainer.Controls.Add(this.btn_savepassword);
            this.pnl_passwordcontrolscontainer.Controls.Add(this.txt_newpassword);
            this.pnl_passwordcontrolscontainer.Controls.Add(this.txt_oldpassword);
            this.pnl_passwordcontrolscontainer.Location = new System.Drawing.Point(22, 477);
            this.pnl_passwordcontrolscontainer.Name = "pnl_passwordcontrolscontainer";
            this.pnl_passwordcontrolscontainer.Size = new System.Drawing.Size(1095, 200);
            this.pnl_passwordcontrolscontainer.TabIndex = 12;
            // 
            // btn_savepassword
            // 
            this.btn_savepassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_savepassword.BorderColor = System.Drawing.Color.Gray;
            this.btn_savepassword.BorderRadius = 5;
            this.btn_savepassword.BorderThickness = 1;
            this.btn_savepassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_savepassword.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_savepassword.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_savepassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_savepassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_savepassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(108)))), ((int)(((byte)(190)))));
            this.btn_savepassword.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_savepassword.ForeColor = System.Drawing.Color.White;
            this.btn_savepassword.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(108)))), ((int)(((byte)(190)))));
            this.btn_savepassword.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_savepassword.Location = new System.Drawing.Point(17, 156);
            this.btn_savepassword.Name = "btn_savepassword";
            this.btn_savepassword.Size = new System.Drawing.Size(1061, 33);
            this.btn_savepassword.TabIndex = 16;
            this.btn_savepassword.Text = "تأكيد";
            this.btn_savepassword.Click += new System.EventHandler(this.btn_savepassword_Click);
            // 
            // txt_newpassword
            // 
            this.txt_newpassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_newpassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.txt_newpassword.BorderColor = System.Drawing.Color.Gray;
            this.txt_newpassword.BorderRadius = 6;
            this.txt_newpassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_newpassword.DefaultText = "";
            this.txt_newpassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_newpassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_newpassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_newpassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_newpassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_newpassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_newpassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_newpassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_newpassword.IconLeft = ((System.Drawing.Image)(resources.GetObject("txt_newpassword.IconLeft")));
            this.txt_newpassword.IconLeftSize = new System.Drawing.Size(25, 25);
            this.txt_newpassword.Location = new System.Drawing.Point(17, 80);
            this.txt_newpassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_newpassword.Name = "txt_newpassword";
            this.txt_newpassword.PasswordChar = '●';
            this.txt_newpassword.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txt_newpassword.PlaceholderText = "كلمة المرور الجديدة";
            this.txt_newpassword.SelectedText = "";
            this.txt_newpassword.Size = new System.Drawing.Size(1061, 58);
            this.txt_newpassword.TabIndex = 15;
            this.txt_newpassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_newpassword.UseSystemPasswordChar = true;
            this.txt_newpassword.IconLeftClick += new System.EventHandler(this.txt_newpassword_IconLeftClick);
            // 
            // txt_oldpassword
            // 
            this.txt_oldpassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_oldpassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.txt_oldpassword.BorderColor = System.Drawing.Color.Gray;
            this.txt_oldpassword.BorderRadius = 6;
            this.txt_oldpassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_oldpassword.DefaultText = "";
            this.txt_oldpassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_oldpassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_oldpassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_oldpassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_oldpassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_oldpassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_oldpassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_oldpassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_oldpassword.IconLeft = ((System.Drawing.Image)(resources.GetObject("txt_oldpassword.IconLeft")));
            this.txt_oldpassword.IconLeftSize = new System.Drawing.Size(25, 25);
            this.txt_oldpassword.Location = new System.Drawing.Point(17, 12);
            this.txt_oldpassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_oldpassword.Name = "txt_oldpassword";
            this.txt_oldpassword.PasswordChar = '●';
            this.txt_oldpassword.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txt_oldpassword.PlaceholderText = "كلمة المرور القديمة";
            this.txt_oldpassword.SelectedText = "";
            this.txt_oldpassword.Size = new System.Drawing.Size(1061, 58);
            this.txt_oldpassword.TabIndex = 14;
            this.txt_oldpassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_oldpassword.UseSystemPasswordChar = true;
            this.txt_oldpassword.IconLeftClick += new System.EventHandler(this.txt_oldpassword_IconLeftClick);
            // 
            // lbl_changepassword
            // 
            this.lbl_changepassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_changepassword.AutoSize = true;
            this.lbl_changepassword.Location = new System.Drawing.Point(505, 438);
            this.lbl_changepassword.Name = "lbl_changepassword";
            this.lbl_changepassword.Size = new System.Drawing.Size(86, 13);
            this.lbl_changepassword.TabIndex = 22;
            this.lbl_changepassword.TabStop = true;
            this.lbl_changepassword.Text = "تغيير كلمة المرور";
            this.lbl_changepassword.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_changepassword_LinkClicked);
            // 
            // lbl_phone
            // 
            this.lbl_phone.AutoSize = true;
            this.lbl_phone.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_phone.ForeColor = System.Drawing.Color.Black;
            this.lbl_phone.Location = new System.Drawing.Point(77, 382);
            this.lbl_phone.Name = "lbl_phone";
            this.lbl_phone.Size = new System.Drawing.Size(85, 17);
            this.lbl_phone.TabIndex = 21;
            this.lbl_phone.Text = "07513250929";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(999, 385);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "الهاتف";
            // 
            // guna2Separator3
            // 
            this.guna2Separator3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator3.Location = new System.Drawing.Point(14, 418);
            this.guna2Separator3.Name = "guna2Separator3";
            this.guna2Separator3.Size = new System.Drawing.Size(1095, 10);
            this.guna2Separator3.TabIndex = 19;
            // 
            // guna2Separator2
            // 
            this.guna2Separator2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator2.Location = new System.Drawing.Point(14, 363);
            this.guna2Separator2.Name = "guna2Separator2";
            this.guna2Separator2.Size = new System.Drawing.Size(1095, 10);
            this.guna2Separator2.TabIndex = 18;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator1.Location = new System.Drawing.Point(14, 308);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(1095, 10);
            this.guna2Separator1.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(965, 329);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "أسم المستخدم";
            // 
            // lbl_fullname
            // 
            this.lbl_fullname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_fullname.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_fullname.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fullname.ForeColor = System.Drawing.Color.Black;
            this.lbl_fullname.Location = new System.Drawing.Point(522, 113);
            this.lbl_fullname.Name = "lbl_fullname";
            this.lbl_fullname.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_fullname.Size = new System.Drawing.Size(570, 44);
            this.lbl_fullname.TabIndex = 15;
            this.lbl_fullname.Text = "مرتضئ محمد";
            this.lbl_fullname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_update
            // 
            this.btn_update.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_update.BorderColor = System.Drawing.Color.Gray;
            this.btn_update.BorderRadius = 5;
            this.btn_update.BorderThickness = 1;
            this.btn_update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_update.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_update.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_update.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_update.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_update.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.btn_update.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btn_update.ForeColor = System.Drawing.Color.Black;
            this.btn_update.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(108)))), ((int)(((byte)(190)))));
            this.btn_update.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_update.Location = new System.Drawing.Point(31, 253);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(1061, 45);
            this.btn_update.TabIndex = 14;
            this.btn_update.Text = "تعديل";
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.ForeColor = System.Drawing.Color.Black;
            this.lbl_username.Location = new System.Drawing.Point(77, 327);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(54, 17);
            this.lbl_username.TabIndex = 13;
            this.lbl_username.Text = "mac383";
            // 
            // pic_userimage
            // 
            this.pic_userimage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_userimage.Image = ((System.Drawing.Image)(resources.GetObject("pic_userimage.Image")));
            this.pic_userimage.ImageRotate = 0F;
            this.pic_userimage.Location = new System.Drawing.Point(37, 21);
            this.pic_userimage.Name = "pic_userimage";
            this.pic_userimage.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pic_userimage.Size = new System.Drawing.Size(200, 200);
            this.pic_userimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_userimage.TabIndex = 11;
            this.pic_userimage.TabStop = false;
            // 
            // UC_CurrentUserProfile
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnl_passwordcontrolscontainer);
            this.Controls.Add(this.lbl_changepassword);
            this.Controls.Add(this.lbl_phone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.guna2Separator3);
            this.Controls.Add(this.guna2Separator2);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_fullname);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.pic_userimage);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.MaximumSize = new System.Drawing.Size(0, 687);
            this.MinimumSize = new System.Drawing.Size(1140, 477);
            this.Name = "UC_CurrentUserProfile";
            this.Size = new System.Drawing.Size(1140, 687);
            this.Load += new System.EventHandler(this.UC_CurrentUserProfile_Load);
            this.pnl_passwordcontrolscontainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_userimage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnl_passwordcontrolscontainer;
        private Guna.UI2.WinForms.Guna2Button btn_savepassword;
        private Guna.UI2.WinForms.Guna2TextBox txt_newpassword;
        private Guna.UI2.WinForms.Guna2TextBox txt_oldpassword;
        private System.Windows.Forms.LinkLabel lbl_changepassword;
        private System.Windows.Forms.Label lbl_phone;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator3;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_fullname;
        private Guna.UI2.WinForms.Guna2Button btn_update;
        private System.Windows.Forms.Label lbl_username;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pic_userimage;
    }
}
