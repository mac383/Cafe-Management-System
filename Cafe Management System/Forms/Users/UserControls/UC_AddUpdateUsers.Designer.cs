namespace Cafe_Management_System.Forms.Users.UserControls
{
    partial class UC_AddUpdateUsers
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
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lbl_showpermissions = new System.Windows.Forms.LinkLabel();
            this.btn_deletepic = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btn_addpic = new Guna.UI2.WinForms.Guna2ImageButton();
            this.txt_firstname = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_secondname = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_lastname = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_username = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_department = new System.Windows.Forms.Label();
            this.dtp_dob = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txt_idnumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_address = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_phone1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_phone2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.rb_female = new Guna.UI2.WinForms.Guna2RadioButton();
            this.rb_male = new Guna.UI2.WinForms.Guna2RadioButton();
            this.groupbox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txt_password = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbl_firstnametoltip = new System.Windows.Forms.Label();
            this.lbl_secondnametoltip = new System.Windows.Forms.Label();
            this.lbl_lastnametoltip = new System.Windows.Forms.Label();
            this.lbl_usernametoltip = new System.Windows.Forms.Label();
            this.lbl_passwordtoltip = new System.Windows.Forms.Label();
            this.lbl_idnumbertoltip = new System.Windows.Forms.Label();
            this.lbl_addresstoltip = new System.Windows.Forms.Label();
            this.lbl_phone1toltip = new System.Windows.Forms.Label();
            this.lbl_phone2toltip = new System.Windows.Forms.Label();
            this.btn_save = new Guna.UI2.WinForms.Guna2Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pic_userimage = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btn_back = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2GroupBox1.SuspendLayout();
            this.groupbox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_userimage)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator1.Location = new System.Drawing.Point(74, 321);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(1044, 10);
            this.guna2Separator1.TabIndex = 26;
            // 
            // lbl_showpermissions
            // 
            this.lbl_showpermissions.ActiveLinkColor = System.Drawing.Color.Blue;
            this.lbl_showpermissions.AutoSize = true;
            this.lbl_showpermissions.BackColor = System.Drawing.Color.Transparent;
            this.lbl_showpermissions.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lbl_showpermissions.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline;
            this.lbl_showpermissions.Location = new System.Drawing.Point(232, 298);
            this.lbl_showpermissions.Name = "lbl_showpermissions";
            this.lbl_showpermissions.Size = new System.Drawing.Size(107, 14);
            this.lbl_showpermissions.TabIndex = 47;
            this.lbl_showpermissions.TabStop = true;
            this.lbl_showpermissions.Text = "صلاحيات المستخدم";
            this.lbl_showpermissions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolTip1.SetToolTip(this.lbl_showpermissions, "عرض صلاحيات المستخدم");
            this.lbl_showpermissions.VisitedLinkColor = System.Drawing.Color.Blue;
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
            this.btn_deletepic.Location = new System.Drawing.Point(1159, 277);
            this.btn_deletepic.Name = "btn_deletepic";
            this.btn_deletepic.PressedState.ImageSize = new System.Drawing.Size(26, 26);
            this.btn_deletepic.Size = new System.Drawing.Size(30, 30);
            this.btn_deletepic.TabIndex = 13;
            this.btn_deletepic.Tag = "";
            this.toolTip1.SetToolTip(this.btn_deletepic, "حذف الصورة");
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
            this.btn_addpic.Location = new System.Drawing.Point(1198, 277);
            this.btn_addpic.Name = "btn_addpic";
            this.btn_addpic.PressedState.ImageSize = new System.Drawing.Size(26, 26);
            this.btn_addpic.Size = new System.Drawing.Size(30, 30);
            this.btn_addpic.TabIndex = 12;
            this.btn_addpic.Tag = "";
            this.toolTip1.SetToolTip(this.btn_addpic, "إضافة صورة");
            this.btn_addpic.Click += new System.EventHandler(this.btn_addpic_Click);
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
            this.txt_firstname.Location = new System.Drawing.Point(700, 163);
            this.txt_firstname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_firstname.MaxLength = 12;
            this.txt_firstname.Name = "txt_firstname";
            this.txt_firstname.PasswordChar = '\0';
            this.txt_firstname.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txt_firstname.PlaceholderText = "الأسم الاول *";
            this.txt_firstname.SelectedText = "";
            this.txt_firstname.Size = new System.Drawing.Size(239, 38);
            this.txt_firstname.TabIndex = 0;
            this.txt_firstname.Tag = "";
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
            this.txt_secondname.Location = new System.Drawing.Point(455, 163);
            this.txt_secondname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_secondname.MaxLength = 12;
            this.txt_secondname.Name = "txt_secondname";
            this.txt_secondname.PasswordChar = '\0';
            this.txt_secondname.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txt_secondname.PlaceholderText = "الأسم الثاني *";
            this.txt_secondname.SelectedText = "";
            this.txt_secondname.Size = new System.Drawing.Size(239, 38);
            this.txt_secondname.TabIndex = 1;
            this.txt_secondname.Tag = "";
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
            this.txt_lastname.Location = new System.Drawing.Point(210, 163);
            this.txt_lastname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_lastname.MaxLength = 12;
            this.txt_lastname.Name = "txt_lastname";
            this.txt_lastname.PasswordChar = '\0';
            this.txt_lastname.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txt_lastname.PlaceholderText = "الأسم الثالث";
            this.txt_lastname.SelectedText = "";
            this.txt_lastname.Size = new System.Drawing.Size(239, 38);
            this.txt_lastname.TabIndex = 2;
            this.txt_lastname.Tag = "";
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
            this.txt_username.Location = new System.Drawing.Point(700, 235);
            this.txt_username.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_username.MaxLength = 12;
            this.txt_username.Name = "txt_username";
            this.txt_username.PasswordChar = '\0';
            this.txt_username.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txt_username.PlaceholderText = "أسم المستخدم *";
            this.txt_username.SelectedText = "";
            this.txt_username.Size = new System.Drawing.Size(239, 38);
            this.txt_username.TabIndex = 3;
            this.txt_username.Tag = "";
            // 
            // lbl_department
            // 
            this.lbl_department.AutoSize = true;
            this.lbl_department.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_department.ForeColor = System.Drawing.Color.Red;
            this.lbl_department.Location = new System.Drawing.Point(90, 298);
            this.lbl_department.Name = "lbl_department";
            this.lbl_department.Size = new System.Drawing.Size(35, 14);
            this.lbl_department.TabIndex = 35;
            this.lbl_department.Text = "????";
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
            this.txt_idnumber.Location = new System.Drawing.Point(741, 490);
            this.txt_idnumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_idnumber.MaxLength = 25;
            this.txt_idnumber.Name = "txt_idnumber";
            this.txt_idnumber.PasswordChar = '\0';
            this.txt_idnumber.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txt_idnumber.PlaceholderText = "رقم الهوية";
            this.txt_idnumber.SelectedText = "";
            this.txt_idnumber.Size = new System.Drawing.Size(321, 38);
            this.txt_idnumber.TabIndex = 8;
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
            this.txt_address.Location = new System.Drawing.Point(741, 566);
            this.txt_address.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_address.MaxLength = 50;
            this.txt_address.Name = "txt_address";
            this.txt_address.PasswordChar = '\0';
            this.txt_address.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txt_address.PlaceholderText = "العنوان *";
            this.txt_address.SelectedText = "";
            this.txt_address.Size = new System.Drawing.Size(323, 38);
            this.txt_address.TabIndex = 9;
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
            this.txt_phone1.Location = new System.Drawing.Point(237, 490);
            this.txt_phone1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_phone1.MaxLength = 14;
            this.txt_phone1.Name = "txt_phone1";
            this.txt_phone1.PasswordChar = '\0';
            this.txt_phone1.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txt_phone1.PlaceholderText = "الهاتف 1 *";
            this.txt_phone1.SelectedText = "";
            this.txt_phone1.Size = new System.Drawing.Size(321, 38);
            this.txt_phone1.TabIndex = 10;
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
            this.txt_phone2.Location = new System.Drawing.Point(237, 566);
            this.txt_phone2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_phone2.MaxLength = 14;
            this.txt_phone2.Name = "txt_phone2";
            this.txt_phone2.PasswordChar = '\0';
            this.txt_phone2.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txt_phone2.PlaceholderText = "الهاتف 2";
            this.txt_phone2.SelectedText = "";
            this.txt_phone2.Size = new System.Drawing.Size(321, 38);
            this.txt_phone2.TabIndex = 11;
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
            this.guna2GroupBox1.TabIndex = 42;
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
            this.rb_female.Size = new System.Drawing.Size(46, 19);
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
            this.rb_male.Size = new System.Drawing.Size(42, 19);
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
            this.groupbox1.TabIndex = 46;
            this.groupbox1.Text = "تاريخ الميلاد";
            this.groupbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            this.txt_password.Location = new System.Drawing.Point(455, 235);
            this.txt_password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_password.MaxLength = 12;
            this.txt_password.Name = "txt_password";
            this.txt_password.PasswordChar = '\0';
            this.txt_password.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txt_password.PlaceholderText = "كلمة السر *";
            this.txt_password.SelectedText = "";
            this.txt_password.Size = new System.Drawing.Size(239, 38);
            this.txt_password.TabIndex = 4;
            this.txt_password.Tag = "";
            // 
            // lbl_firstnametoltip
            // 
            this.lbl_firstnametoltip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_firstnametoltip.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_firstnametoltip.ForeColor = System.Drawing.Color.Red;
            this.lbl_firstnametoltip.Location = new System.Drawing.Point(700, 206);
            this.lbl_firstnametoltip.Name = "lbl_firstnametoltip";
            this.lbl_firstnametoltip.Size = new System.Drawing.Size(239, 24);
            this.lbl_firstnametoltip.TabIndex = 49;
            this.lbl_firstnametoltip.Text = "تنسيق غير صحيح";
            this.lbl_firstnametoltip.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_firstnametoltip.Visible = false;
            // 
            // lbl_secondnametoltip
            // 
            this.lbl_secondnametoltip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_secondnametoltip.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_secondnametoltip.ForeColor = System.Drawing.Color.Red;
            this.lbl_secondnametoltip.Location = new System.Drawing.Point(455, 206);
            this.lbl_secondnametoltip.Name = "lbl_secondnametoltip";
            this.lbl_secondnametoltip.Size = new System.Drawing.Size(239, 24);
            this.lbl_secondnametoltip.TabIndex = 50;
            this.lbl_secondnametoltip.Text = "تنسيق غير صحيح";
            this.lbl_secondnametoltip.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_secondnametoltip.Visible = false;
            // 
            // lbl_lastnametoltip
            // 
            this.lbl_lastnametoltip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_lastnametoltip.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lastnametoltip.ForeColor = System.Drawing.Color.Red;
            this.lbl_lastnametoltip.Location = new System.Drawing.Point(210, 206);
            this.lbl_lastnametoltip.Name = "lbl_lastnametoltip";
            this.lbl_lastnametoltip.Size = new System.Drawing.Size(239, 24);
            this.lbl_lastnametoltip.TabIndex = 51;
            this.lbl_lastnametoltip.Text = "تنسيق غير صحيح";
            this.lbl_lastnametoltip.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_lastnametoltip.Visible = false;
            // 
            // lbl_usernametoltip
            // 
            this.lbl_usernametoltip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_usernametoltip.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usernametoltip.ForeColor = System.Drawing.Color.Red;
            this.lbl_usernametoltip.Location = new System.Drawing.Point(700, 277);
            this.lbl_usernametoltip.Name = "lbl_usernametoltip";
            this.lbl_usernametoltip.Size = new System.Drawing.Size(239, 24);
            this.lbl_usernametoltip.TabIndex = 52;
            this.lbl_usernametoltip.Text = "تنسيق غير صحيح";
            this.lbl_usernametoltip.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_usernametoltip.Visible = false;
            // 
            // lbl_passwordtoltip
            // 
            this.lbl_passwordtoltip.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_passwordtoltip.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_passwordtoltip.ForeColor = System.Drawing.Color.Red;
            this.lbl_passwordtoltip.Location = new System.Drawing.Point(455, 277);
            this.lbl_passwordtoltip.Name = "lbl_passwordtoltip";
            this.lbl_passwordtoltip.Size = new System.Drawing.Size(239, 24);
            this.lbl_passwordtoltip.TabIndex = 53;
            this.lbl_passwordtoltip.Text = "تنسيق غير صحيح";
            this.lbl_passwordtoltip.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_passwordtoltip.Visible = false;
            // 
            // lbl_idnumbertoltip
            // 
            this.lbl_idnumbertoltip.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_idnumbertoltip.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_idnumbertoltip.ForeColor = System.Drawing.Color.Red;
            this.lbl_idnumbertoltip.Location = new System.Drawing.Point(742, 532);
            this.lbl_idnumbertoltip.Name = "lbl_idnumbertoltip";
            this.lbl_idnumbertoltip.Size = new System.Drawing.Size(320, 29);
            this.lbl_idnumbertoltip.TabIndex = 54;
            this.lbl_idnumbertoltip.Text = "تنسيق غير صحيح";
            this.lbl_idnumbertoltip.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_idnumbertoltip.Visible = false;
            // 
            // lbl_addresstoltip
            // 
            this.lbl_addresstoltip.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_addresstoltip.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_addresstoltip.ForeColor = System.Drawing.Color.Red;
            this.lbl_addresstoltip.Location = new System.Drawing.Point(741, 607);
            this.lbl_addresstoltip.Name = "lbl_addresstoltip";
            this.lbl_addresstoltip.Size = new System.Drawing.Size(320, 29);
            this.lbl_addresstoltip.TabIndex = 55;
            this.lbl_addresstoltip.Text = "تنسيق غير صحيح";
            this.lbl_addresstoltip.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_addresstoltip.Visible = false;
            // 
            // lbl_phone1toltip
            // 
            this.lbl_phone1toltip.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_phone1toltip.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_phone1toltip.ForeColor = System.Drawing.Color.Red;
            this.lbl_phone1toltip.Location = new System.Drawing.Point(237, 532);
            this.lbl_phone1toltip.Name = "lbl_phone1toltip";
            this.lbl_phone1toltip.Size = new System.Drawing.Size(321, 29);
            this.lbl_phone1toltip.TabIndex = 56;
            this.lbl_phone1toltip.Text = "تنسيق غير صحيح";
            this.lbl_phone1toltip.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_phone1toltip.Visible = false;
            // 
            // lbl_phone2toltip
            // 
            this.lbl_phone2toltip.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_phone2toltip.Font = new System.Drawing.Font("Myanmar Text", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_phone2toltip.ForeColor = System.Drawing.Color.Red;
            this.lbl_phone2toltip.Location = new System.Drawing.Point(237, 607);
            this.lbl_phone2toltip.Name = "lbl_phone2toltip";
            this.lbl_phone2toltip.Size = new System.Drawing.Size(321, 29);
            this.lbl_phone2toltip.TabIndex = 57;
            this.lbl_phone2toltip.Text = "تنسيق غير صحيح";
            this.lbl_phone2toltip.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_phone2toltip.Visible = false;
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
            this.btn_save.TabIndex = 14;
            this.btn_save.Text = "حفظ";
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
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
            this.pic_userimage.TabIndex = 25;
            this.pic_userimage.TabStop = false;
            this.pic_userimage.UseTransparentBackground = true;
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
            this.btn_back.TabIndex = 15;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // UC_AddUpdateUsers
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.lbl_phone2toltip);
            this.Controls.Add(this.lbl_phone1toltip);
            this.Controls.Add(this.lbl_addresstoltip);
            this.Controls.Add(this.lbl_idnumbertoltip);
            this.Controls.Add(this.lbl_passwordtoltip);
            this.Controls.Add(this.lbl_usernametoltip);
            this.Controls.Add(this.lbl_lastnametoltip);
            this.Controls.Add(this.lbl_secondnametoltip);
            this.Controls.Add(this.lbl_firstnametoltip);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.lbl_showpermissions);
            this.Controls.Add(this.groupbox1);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.txt_phone2);
            this.Controls.Add(this.txt_phone1);
            this.Controls.Add(this.txt_address);
            this.Controls.Add(this.txt_idnumber);
            this.Controls.Add(this.lbl_department);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.txt_lastname);
            this.Controls.Add(this.txt_secondname);
            this.Controls.Add(this.txt_firstname);
            this.Controls.Add(this.btn_deletepic);
            this.Controls.Add(this.btn_addpic);
            this.Controls.Add(this.guna2Separator1);
            this.Controls.Add(this.pic_userimage);
            this.Controls.Add(this.btn_back);
            this.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Name = "UC_AddUpdateUsers";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(1300, 700);
            this.Load += new System.EventHandler(this.UC_AddUpdateUsers_Load);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.groupbox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_userimage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ImageButton btn_back;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pic_userimage;
        private System.Windows.Forms.ToolTip toolTip1;
        private Guna.UI2.WinForms.Guna2ImageButton btn_deletepic;
        private Guna.UI2.WinForms.Guna2ImageButton btn_addpic;
        private Guna.UI2.WinForms.Guna2TextBox txt_firstname;
        private Guna.UI2.WinForms.Guna2TextBox txt_secondname;
        private Guna.UI2.WinForms.Guna2TextBox txt_lastname;
        private Guna.UI2.WinForms.Guna2TextBox txt_username;
        private System.Windows.Forms.Label lbl_department;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtp_dob;
        private Guna.UI2.WinForms.Guna2TextBox txt_idnumber;
        private Guna.UI2.WinForms.Guna2TextBox txt_address;
        private Guna.UI2.WinForms.Guna2TextBox txt_phone1;
        private Guna.UI2.WinForms.Guna2TextBox txt_phone2;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2RadioButton rb_female;
        private Guna.UI2.WinForms.Guna2RadioButton rb_male;
        private Guna.UI2.WinForms.Guna2GroupBox groupbox1;
        private System.Windows.Forms.LinkLabel lbl_showpermissions;
        private Guna.UI2.WinForms.Guna2TextBox txt_password;
        private System.Windows.Forms.Label lbl_firstnametoltip;
        private System.Windows.Forms.Label lbl_secondnametoltip;
        private System.Windows.Forms.Label lbl_lastnametoltip;
        private System.Windows.Forms.Label lbl_usernametoltip;
        private System.Windows.Forms.Label lbl_passwordtoltip;
        private System.Windows.Forms.Label lbl_idnumbertoltip;
        private System.Windows.Forms.Label lbl_addresstoltip;
        private System.Windows.Forms.Label lbl_phone1toltip;
        private System.Windows.Forms.Label lbl_phone2toltip;
        private Guna.UI2.WinForms.Guna2Button btn_save;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
