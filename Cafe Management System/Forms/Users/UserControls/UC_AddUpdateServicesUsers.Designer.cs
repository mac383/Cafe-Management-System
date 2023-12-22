namespace Cafe_Management_System.Forms.Users.UserControls
{
    partial class UC_AddUpdateServicesUsers
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
            this.btn_back = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btn_deletepic = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btn_addpic = new Guna.UI2.WinForms.Guna2ImageButton();
            this.pic_userimage = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.txt_password = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_username = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_lastname = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_secondname = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_firstname = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.groupbox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dtp_dob = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.rb_female = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rb_male = new Guna.UI2.WinForms.Guna2RadioButton();
            this.txt_phone2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_phone1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_address = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_idnumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_save = new Guna.UI2.WinForms.Guna2Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pic_userimage)).BeginInit();
            this.groupbox1.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.Transparent;
            this.btn_back.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_back.HoverState.ImageSize = new System.Drawing.Size(35, 35);
            this.btn_back.Image = global::Cafe_Management_System.Properties.Resources.back;
            this.btn_back.ImageOffset = new System.Drawing.Point(0, 0);
            this.btn_back.ImageRotate = 0F;
            this.btn_back.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_back.Location = new System.Drawing.Point(3, 3);
            this.btn_back.Name = "btn_back";
            this.btn_back.PressedState.ImageSize = new System.Drawing.Size(32, 32);
            this.btn_back.Size = new System.Drawing.Size(50, 30);
            this.btn_back.TabIndex = 16;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_deletepic
            // 
            this.btn_deletepic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_deletepic.BackColor = System.Drawing.Color.Transparent;
            this.btn_deletepic.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_deletepic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_deletepic.HoverState.ImageSize = new System.Drawing.Size(27, 27);
            this.btn_deletepic.Image = global::Cafe_Management_System.Properties.Resources.delete32;
            this.btn_deletepic.ImageOffset = new System.Drawing.Point(0, 0);
            this.btn_deletepic.ImageRotate = 0F;
            this.btn_deletepic.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_deletepic.Location = new System.Drawing.Point(1154, 279);
            this.btn_deletepic.Name = "btn_deletepic";
            this.btn_deletepic.PressedState.ImageSize = new System.Drawing.Size(26, 26);
            this.btn_deletepic.Size = new System.Drawing.Size(30, 30);
            this.btn_deletepic.TabIndex = 27;
            this.btn_deletepic.Tag = "";
            this.btn_deletepic.Click += new System.EventHandler(this.btn_deletepic_Click);
            // 
            // btn_addpic
            // 
            this.btn_addpic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_addpic.BackColor = System.Drawing.Color.Transparent;
            this.btn_addpic.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_addpic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_addpic.HoverState.ImageSize = new System.Drawing.Size(27, 27);
            this.btn_addpic.Image = global::Cafe_Management_System.Properties.Resources.edit32;
            this.btn_addpic.ImageOffset = new System.Drawing.Point(0, 0);
            this.btn_addpic.ImageRotate = 0F;
            this.btn_addpic.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_addpic.Location = new System.Drawing.Point(1193, 279);
            this.btn_addpic.Name = "btn_addpic";
            this.btn_addpic.PressedState.ImageSize = new System.Drawing.Size(26, 26);
            this.btn_addpic.Size = new System.Drawing.Size(30, 30);
            this.btn_addpic.TabIndex = 26;
            this.btn_addpic.Tag = "";
            this.btn_addpic.Click += new System.EventHandler(this.btn_addpic_Click);
            // 
            // pic_userimage
            // 
            this.pic_userimage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_userimage.BackColor = System.Drawing.Color.Transparent;
            this.pic_userimage.ErrorImage = global::Cafe_Management_System.Properties.Resources.not_found_256;
            this.pic_userimage.Image = global::Cafe_Management_System.Properties.Resources.empty_image;
            this.pic_userimage.ImageRotate = 0F;
            this.pic_userimage.InitialImage = null;
            this.pic_userimage.Location = new System.Drawing.Point(973, 23);
            this.pic_userimage.Name = "pic_userimage";
            this.pic_userimage.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pic_userimage.Size = new System.Drawing.Size(250, 250);
            this.pic_userimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_userimage.TabIndex = 28;
            this.pic_userimage.TabStop = false;
            this.pic_userimage.UseTransparentBackground = true;
            // 
            // txt_password
            // 
            this.txt_password.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_password.BackColor = System.Drawing.Color.White;
            this.txt_password.BorderColor = System.Drawing.Color.Gray;
            this.txt_password.BorderRadius = 5;
            this.txt_password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_password.DefaultText = "";
            this.txt_password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_password.FocusedState.ForeColor = System.Drawing.Color.Black;
            this.txt_password.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_password.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_password.IconLeft = global::Cafe_Management_System.Properties.Resources.show_password;
            this.txt_password.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.txt_password.IconLeftSize = new System.Drawing.Size(25, 25);
            this.txt_password.Location = new System.Drawing.Point(456, 235);
            this.txt_password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_password.MaxLength = 12;
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '●';
            this.txt_password.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txt_password.PlaceholderText = "كلمة السر *";
            this.txt_password.SelectedText = "";
            this.txt_password.Size = new System.Drawing.Size(239, 38);
            this.txt_password.TabIndex = 33;
            this.txt_password.Tag = "كلمة السر *";
            this.txt_password.UseSystemPasswordChar = true;
            this.txt_password.IconLeftClick += new System.EventHandler(this.txt_password_IconLeftClick);
            this.txt_password.Validating += new System.ComponentModel.CancelEventHandler(this.txt_password_Validating);
            // 
            // txt_username
            // 
            this.txt_username.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_username.BackColor = System.Drawing.Color.White;
            this.txt_username.BorderColor = System.Drawing.Color.Gray;
            this.txt_username.BorderRadius = 5;
            this.txt_username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_username.DefaultText = "";
            this.txt_username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_username.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_username.FocusedState.ForeColor = System.Drawing.Color.Black;
            this.txt_username.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_username.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_username.Location = new System.Drawing.Point(706, 235);
            this.txt_username.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_username.MaxLength = 12;
            this.txt_username.Name = "txt_username";
            this.txt_username.PasswordChar = '\0';
            this.txt_username.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txt_username.PlaceholderText = "أسم المستخدم *";
            this.txt_username.SelectedText = "";
            this.txt_username.Size = new System.Drawing.Size(239, 38);
            this.txt_username.TabIndex = 32;
            this.txt_username.Tag = "أسم المستخدم *";
            this.txt_username.Validating += new System.ComponentModel.CancelEventHandler(this.txt_username_Validating);
            // 
            // txt_lastname
            // 
            this.txt_lastname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_lastname.BackColor = System.Drawing.Color.White;
            this.txt_lastname.BorderColor = System.Drawing.Color.Gray;
            this.txt_lastname.BorderRadius = 5;
            this.txt_lastname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_lastname.DefaultText = "";
            this.txt_lastname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_lastname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_lastname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_lastname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_lastname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_lastname.FocusedState.ForeColor = System.Drawing.Color.Black;
            this.txt_lastname.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_lastname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_lastname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_lastname.Location = new System.Drawing.Point(206, 163);
            this.txt_lastname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_lastname.MaxLength = 12;
            this.txt_lastname.Name = "txt_lastname";
            this.txt_lastname.PasswordChar = '\0';
            this.txt_lastname.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txt_lastname.PlaceholderText = "الأسم الثالث";
            this.txt_lastname.SelectedText = "";
            this.txt_lastname.Size = new System.Drawing.Size(239, 38);
            this.txt_lastname.TabIndex = 31;
            this.txt_lastname.Tag = "الأسم الثااث";
            // 
            // txt_secondname
            // 
            this.txt_secondname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_secondname.BackColor = System.Drawing.Color.White;
            this.txt_secondname.BorderColor = System.Drawing.Color.Gray;
            this.txt_secondname.BorderRadius = 5;
            this.txt_secondname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_secondname.DefaultText = "";
            this.txt_secondname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_secondname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_secondname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_secondname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_secondname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_secondname.FocusedState.ForeColor = System.Drawing.Color.Black;
            this.txt_secondname.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_secondname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_secondname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_secondname.Location = new System.Drawing.Point(456, 163);
            this.txt_secondname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_secondname.MaxLength = 12;
            this.txt_secondname.Name = "txt_secondname";
            this.txt_secondname.PasswordChar = '\0';
            this.txt_secondname.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txt_secondname.PlaceholderText = "الأسم الثاني *";
            this.txt_secondname.SelectedText = "";
            this.txt_secondname.Size = new System.Drawing.Size(239, 38);
            this.txt_secondname.TabIndex = 30;
            this.txt_secondname.Tag = "الأسم الثاني *";
            this.txt_secondname.Validating += new System.ComponentModel.CancelEventHandler(this.txt_firstname_Validating);
            // 
            // txt_firstname
            // 
            this.txt_firstname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_firstname.BackColor = System.Drawing.Color.White;
            this.txt_firstname.BorderColor = System.Drawing.Color.Gray;
            this.txt_firstname.BorderRadius = 5;
            this.txt_firstname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_firstname.DefaultText = "";
            this.txt_firstname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_firstname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_firstname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_firstname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_firstname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_firstname.FocusedState.ForeColor = System.Drawing.Color.Black;
            this.txt_firstname.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_firstname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_firstname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_firstname.Location = new System.Drawing.Point(706, 163);
            this.txt_firstname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_firstname.MaxLength = 12;
            this.txt_firstname.Name = "txt_firstname";
            this.txt_firstname.PasswordChar = '\0';
            this.txt_firstname.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txt_firstname.PlaceholderText = "الأسم الاول *";
            this.txt_firstname.SelectedText = "";
            this.txt_firstname.Size = new System.Drawing.Size(239, 38);
            this.txt_firstname.TabIndex = 29;
            this.txt_firstname.Tag = "الأسم الأول *";
            this.txt_firstname.Validating += new System.ComponentModel.CancelEventHandler(this.txt_firstname_Validating);
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator1.Location = new System.Drawing.Point(74, 321);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(1044, 10);
            this.guna2Separator1.TabIndex = 34;
            // 
            // groupbox1
            // 
            this.groupbox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupbox1.BorderRadius = 5;
            this.groupbox1.Controls.Add(this.dtp_dob);
            this.groupbox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(108)))), ((int)(((byte)(190)))));
            this.groupbox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.groupbox1.ForeColor = System.Drawing.Color.White;
            this.groupbox1.Location = new System.Drawing.Point(741, 372);
            this.groupbox1.Name = "groupbox1";
            this.groupbox1.Size = new System.Drawing.Size(321, 80);
            this.groupbox1.TabIndex = 52;
            this.groupbox1.Text = "تاريخ الميلاد";
            this.groupbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dtp_dob
            // 
            this.dtp_dob.Checked = true;
            this.dtp_dob.FillColor = System.Drawing.Color.White;
            this.dtp_dob.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtp_dob.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(108)))), ((int)(((byte)(190)))));
            this.dtp_dob.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtp_dob.Location = new System.Drawing.Point(1, 40);
            this.dtp_dob.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtp_dob.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtp_dob.Name = "dtp_dob";
            this.dtp_dob.Size = new System.Drawing.Size(321, 40);
            this.dtp_dob.TabIndex = 5;
            this.dtp_dob.Tag = "";
            this.dtp_dob.Value = new System.DateTime(2023, 12, 16, 16, 14, 13, 785);
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2GroupBox1.BorderRadius = 5;
            this.guna2GroupBox1.Controls.Add(this.rb_female);
            this.guna2GroupBox1.Controls.Add(this.rb_male);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(108)))), ((int)(((byte)(190)))));
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox1.Location = new System.Drawing.Point(237, 372);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(321, 80);
            this.guna2GroupBox1.TabIndex = 51;
            this.guna2GroupBox1.Text = "الجنس";
            this.guna2GroupBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // rb_female
            // 
            this.rb_female.AutoSize = true;
            this.rb_female.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rb_female.CheckedState.BorderThickness = 0;
            this.rb_female.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rb_female.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rb_female.CheckedState.InnerOffset = -4;
            this.rb_female.ForeColor = System.Drawing.Color.Black;
            this.rb_female.Location = new System.Drawing.Point(157, 46);
            this.rb_female.Name = "rb_female";
            this.rb_female.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rb_female.Size = new System.Drawing.Size(69, 29);
            this.rb_female.TabIndex = 7;
            this.rb_female.Text = "أنثئ";
            this.rb_female.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rb_female.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rb_female.UncheckedState.BorderThickness = 2;
            this.rb_female.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rb_female.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // rb_male
            // 
            this.rb_male.AutoSize = true;
            this.rb_male.Checked = true;
            this.rb_male.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rb_male.CheckedState.BorderThickness = 0;
            this.rb_male.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rb_male.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rb_male.CheckedState.InnerOffset = -4;
            this.rb_male.ForeColor = System.Drawing.Color.Black;
            this.rb_male.Location = new System.Drawing.Point(94, 46);
            this.rb_male.Name = "rb_male";
            this.rb_male.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rb_male.Size = new System.Drawing.Size(63, 29);
            this.rb_male.TabIndex = 6;
            this.rb_male.TabStop = true;
            this.rb_male.Tag = "";
            this.rb_male.Text = "ذكر";
            this.rb_male.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rb_male.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rb_male.UncheckedState.BorderThickness = 2;
            this.rb_male.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rb_male.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // txt_phone2
            // 
            this.txt_phone2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_phone2.BackColor = System.Drawing.Color.White;
            this.txt_phone2.BorderColor = System.Drawing.Color.Gray;
            this.txt_phone2.BorderRadius = 5;
            this.txt_phone2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_phone2.DefaultText = "";
            this.txt_phone2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_phone2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_phone2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_phone2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_phone2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_phone2.FocusedState.ForeColor = System.Drawing.Color.Black;
            this.txt_phone2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_phone2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_phone2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_phone2.Location = new System.Drawing.Point(237, 568);
            this.txt_phone2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_phone2.MaxLength = 14;
            this.txt_phone2.Name = "txt_phone2";
            this.txt_phone2.PasswordChar = '\0';
            this.txt_phone2.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txt_phone2.PlaceholderText = "الهاتف 2";
            this.txt_phone2.SelectedText = "";
            this.txt_phone2.Size = new System.Drawing.Size(321, 38);
            this.txt_phone2.TabIndex = 50;
            this.txt_phone2.Tag = "الهاتف 2 *";
            this.txt_phone2.Validating += new System.ComponentModel.CancelEventHandler(this.txt_phone2_Validating);
            // 
            // txt_phone1
            // 
            this.txt_phone1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_phone1.BackColor = System.Drawing.Color.White;
            this.txt_phone1.BorderColor = System.Drawing.Color.Gray;
            this.txt_phone1.BorderRadius = 5;
            this.txt_phone1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_phone1.DefaultText = "";
            this.txt_phone1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_phone1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_phone1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_phone1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_phone1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_phone1.FocusedState.ForeColor = System.Drawing.Color.Black;
            this.txt_phone1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_phone1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_phone1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_phone1.Location = new System.Drawing.Point(237, 491);
            this.txt_phone1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_phone1.MaxLength = 14;
            this.txt_phone1.Name = "txt_phone1";
            this.txt_phone1.PasswordChar = '\0';
            this.txt_phone1.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txt_phone1.PlaceholderText = "الهاتف 1 *";
            this.txt_phone1.SelectedText = "";
            this.txt_phone1.Size = new System.Drawing.Size(321, 38);
            this.txt_phone1.TabIndex = 49;
            this.txt_phone1.Tag = "الهاتف 1 *";
            this.txt_phone1.Validating += new System.ComponentModel.CancelEventHandler(this.txt_phone1_Validating);
            // 
            // txt_address
            // 
            this.txt_address.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_address.BackColor = System.Drawing.Color.White;
            this.txt_address.BorderColor = System.Drawing.Color.Gray;
            this.txt_address.BorderRadius = 5;
            this.txt_address.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_address.DefaultText = "";
            this.txt_address.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_address.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_address.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_address.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_address.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_address.FocusedState.ForeColor = System.Drawing.Color.Black;
            this.txt_address.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_address.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_address.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_address.Location = new System.Drawing.Point(741, 568);
            this.txt_address.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_address.MaxLength = 50;
            this.txt_address.Name = "txt_address";
            this.txt_address.PasswordChar = '\0';
            this.txt_address.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txt_address.PlaceholderText = "العنوان *";
            this.txt_address.SelectedText = "";
            this.txt_address.Size = new System.Drawing.Size(323, 38);
            this.txt_address.TabIndex = 48;
            this.txt_address.Tag = "العنوان *";
            this.txt_address.Validating += new System.ComponentModel.CancelEventHandler(this.txt_firstname_Validating);
            // 
            // txt_idnumber
            // 
            this.txt_idnumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_idnumber.BackColor = System.Drawing.Color.White;
            this.txt_idnumber.BorderColor = System.Drawing.Color.Gray;
            this.txt_idnumber.BorderRadius = 5;
            this.txt_idnumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_idnumber.DefaultText = "";
            this.txt_idnumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_idnumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_idnumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_idnumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_idnumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_idnumber.FocusedState.ForeColor = System.Drawing.Color.Black;
            this.txt_idnumber.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_idnumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_idnumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_idnumber.Location = new System.Drawing.Point(741, 491);
            this.txt_idnumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_idnumber.MaxLength = 25;
            this.txt_idnumber.Name = "txt_idnumber";
            this.txt_idnumber.PasswordChar = '\0';
            this.txt_idnumber.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txt_idnumber.PlaceholderText = "رقم الهوية";
            this.txt_idnumber.SelectedText = "";
            this.txt_idnumber.Size = new System.Drawing.Size(321, 38);
            this.txt_idnumber.TabIndex = 47;
            this.txt_idnumber.Tag = "رقم الهوية";
            this.txt_idnumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_idnumber_KeyPress);
            this.txt_idnumber.Validating += new System.ComponentModel.CancelEventHandler(this.txt_idnumber_Validating);
            // 
            // btn_save
            // 
            this.btn_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_save.BorderRadius = 5;
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_save.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_save.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_save.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_save.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(108)))), ((int)(((byte)(190)))));
            this.btn_save.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(108)))), ((int)(((byte)(190)))));
            this.btn_save.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(1168, 644);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(102, 36);
            this.btn_save.TabIndex = 53;
            this.btn_save.Text = "حفظ";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // UC_AddUpdateServicesUsers
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.groupbox1);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.txt_phone2);
            this.Controls.Add(this.txt_phone1);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.txt_idnumber);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.txt_lastname);
            this.Controls.Add(this.txt_secondname);
            this.Controls.Add(this.txt_firstname);
            this.Controls.Add(this.btn_deletepic);
            this.Controls.Add(this.btn_addpic);
            this.Controls.Add(this.pic_userimage);
            this.Controls.Add(this.btn_back);
            this.Name = "UC_AddUpdateServicesUsers";
            this.Size = new System.Drawing.Size(1300, 700);
            this.Load += new System.EventHandler(this.UC_AddUpdateServicesUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_userimage)).EndInit();
            this.groupbox1.ResumeLayout(false);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ImageButton btn_back;
        private Guna.UI2.WinForms.Guna2ImageButton btn_deletepic;
        private Guna.UI2.WinForms.Guna2ImageButton btn_addpic;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pic_userimage;
        private Guna.UI2.WinForms.Guna2TextBox txt_password;
        private Guna.UI2.WinForms.Guna2TextBox txt_username;
        private Guna.UI2.WinForms.Guna2TextBox txt_lastname;
        private Guna.UI2.WinForms.Guna2TextBox txt_secondname;
        private Guna.UI2.WinForms.Guna2TextBox txt_firstname;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2GroupBox groupbox1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_dob;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2RadioButton rb_female;
        private Guna.UI2.WinForms.Guna2RadioButton rb_male;
        private Guna.UI2.WinForms.Guna2TextBox txt_phone2;
        private Guna.UI2.WinForms.Guna2TextBox txt_phone1;
        private Guna.UI2.WinForms.Guna2TextBox txt_address;
        private Guna.UI2.WinForms.Guna2TextBox txt_idnumber;
        private Guna.UI2.WinForms.Guna2Button btn_save;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
