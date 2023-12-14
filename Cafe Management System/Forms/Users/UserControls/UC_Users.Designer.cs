namespace Cafe_Management_System.Forms.Users.UserControls
{
    partial class UC_Users
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_users = new Guna.UI2.WinForms.Guna2DataGridView();
            this.col_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_phonenumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_userid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_Top = new System.Windows.Forms.Panel();
            this.guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.cb_filter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btn_search = new Guna.UI2.WinForms.Guna2Button();
            this.txt_searchan = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.cmb_sortingby = new System.Windows.Forms.ToolStripMenuItem();
            this.cmb_userfullname = new System.Windows.Forms.ToolStripMenuItem();
            this.cmb_username = new System.Windows.Forms.ToolStripMenuItem();
            this.cmb_refresh = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.col_addnew = new System.Windows.Forms.ToolStripMenuItem();
            this.cmb_update = new System.Windows.Forms.ToolStripMenuItem();
            this.cmb_delete = new System.Windows.Forms.ToolStripMenuItem();
            this.cmb_gender = new System.Windows.Forms.ToolStripMenuItem();
            this.cmb_managementappuser = new System.Windows.Forms.ToolStripMenuItem();
            this.cmb_servicesappuser = new System.Windows.Forms.ToolStripMenuItem();
            this.cmb_show = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.cmb_showmoretools = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_users)).BeginInit();
            this.pnl_Top.SuspendLayout();
            this.guna2ContextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_users
            // 
            this.dgv_users.AllowUserToAddRows = false;
            this.dgv_users.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_users.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_users.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_users.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgv_users.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_users.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_users.ColumnHeadersHeight = 40;
            this.dgv_users.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_ID,
            this.col_fullname,
            this.col_username,
            this.col_phonenumber,
            this.col_gender,
            this.col_userid});
            this.dgv_users.ContextMenuStrip = this.guna2ContextMenuStrip1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_users.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_users.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_users.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_users.Location = new System.Drawing.Point(0, 68);
            this.dgv_users.MultiSelect = false;
            this.dgv_users.Name = "dgv_users";
            this.dgv_users.ReadOnly = true;
            this.dgv_users.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgv_users.RowHeadersVisible = false;
            this.dgv_users.RowHeadersWidth = 62;
            this.dgv_users.RowTemplate.Height = 30;
            this.dgv_users.Size = new System.Drawing.Size(1300, 632);
            this.dgv_users.TabIndex = 12;
            this.dgv_users.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_users.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_users.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_users.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_users.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_users.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_users.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_users.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_users.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_users.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_users.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_users.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_users.ThemeStyle.HeaderStyle.Height = 40;
            this.dgv_users.ThemeStyle.ReadOnly = true;
            this.dgv_users.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_users.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_users.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_users.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_users.ThemeStyle.RowsStyle.Height = 30;
            this.dgv_users.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_users.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // col_ID
            // 
            this.col_ID.FillWeight = 40F;
            this.col_ID.HeaderText = "ت";
            this.col_ID.MinimumWidth = 8;
            this.col_ID.Name = "col_ID";
            this.col_ID.ReadOnly = true;
            // 
            // col_fullname
            // 
            this.col_fullname.HeaderText = "الأسم الكامل";
            this.col_fullname.MinimumWidth = 8;
            this.col_fullname.Name = "col_fullname";
            this.col_fullname.ReadOnly = true;
            // 
            // col_username
            // 
            this.col_username.HeaderText = "أسم المستخدم";
            this.col_username.MinimumWidth = 8;
            this.col_username.Name = "col_username";
            this.col_username.ReadOnly = true;
            // 
            // col_phonenumber
            // 
            this.col_phonenumber.HeaderText = "رقم الهاتف";
            this.col_phonenumber.MinimumWidth = 8;
            this.col_phonenumber.Name = "col_phonenumber";
            this.col_phonenumber.ReadOnly = true;
            // 
            // col_gender
            // 
            this.col_gender.HeaderText = "الجنس";
            this.col_gender.MinimumWidth = 8;
            this.col_gender.Name = "col_gender";
            this.col_gender.ReadOnly = true;
            // 
            // col_userid
            // 
            this.col_userid.HeaderText = "UserID";
            this.col_userid.MinimumWidth = 8;
            this.col_userid.Name = "col_userid";
            this.col_userid.ReadOnly = true;
            this.col_userid.Visible = false;
            // 
            // pnl_Top
            // 
            this.pnl_Top.Controls.Add(this.guna2VSeparator1);
            this.pnl_Top.Controls.Add(this.cb_filter);
            this.pnl_Top.Controls.Add(this.btn_search);
            this.pnl_Top.Controls.Add(this.txt_searchan);
            this.pnl_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Top.Location = new System.Drawing.Point(0, 0);
            this.pnl_Top.Name = "pnl_Top";
            this.pnl_Top.Size = new System.Drawing.Size(1300, 68);
            this.pnl_Top.TabIndex = 13;
            // 
            // guna2VSeparator1
            // 
            this.guna2VSeparator1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2VSeparator1.FillThickness = 2;
            this.guna2VSeparator1.Location = new System.Drawing.Point(901, 9);
            this.guna2VSeparator1.Name = "guna2VSeparator1";
            this.guna2VSeparator1.Size = new System.Drawing.Size(10, 50);
            this.guna2VSeparator1.TabIndex = 14;
            // 
            // cb_filter
            // 
            this.cb_filter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_filter.BackColor = System.Drawing.Color.Transparent;
            this.cb_filter.BorderRadius = 4;
            this.cb_filter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_filter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_filter.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_filter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_filter.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cb_filter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cb_filter.ItemHeight = 30;
            this.cb_filter.Items.AddRange(new object[] {
            "الكل",
            "مستخدمين برنامج الخدمات",
            "مستخدمين برنامج الأدارة"});
            this.cb_filter.Location = new System.Drawing.Point(534, 16);
            this.cb_filter.Name = "cb_filter";
            this.cb_filter.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cb_filter.Size = new System.Drawing.Size(357, 36);
            this.cb_filter.StartIndex = 0;
            this.cb_filter.TabIndex = 13;
            this.cb_filter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_search
            // 
            this.btn_search.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_search.BorderRadius = 4;
            this.btn_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_search.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_search.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_search.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_search.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_search.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(108)))), ((int)(((byte)(190)))));
            this.btn_search.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_search.ForeColor = System.Drawing.Color.White;
            this.btn_search.Location = new System.Drawing.Point(1151, 10);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(130, 48);
            this.btn_search.TabIndex = 12;
            this.btn_search.Tag = "1";
            this.btn_search.Text = "بحث";
            // 
            // txt_searchan
            // 
            this.txt_searchan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_searchan.BorderRadius = 4;
            this.txt_searchan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_searchan.DefaultText = "";
            this.txt_searchan.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_searchan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_searchan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_searchan.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_searchan.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_searchan.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_searchan.ForeColor = System.Drawing.Color.Black;
            this.txt_searchan.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_searchan.Location = new System.Drawing.Point(919, 10);
            this.txt_searchan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_searchan.Name = "txt_searchan";
            this.txt_searchan.PasswordChar = '\0';
            this.txt_searchan.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_searchan.PlaceholderText = "الأسم / أسم المستخدم";
            this.txt_searchan.SelectedText = "";
            this.txt_searchan.Size = new System.Drawing.Size(225, 48);
            this.txt_searchan.TabIndex = 11;
            this.txt_searchan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // guna2ContextMenuStrip1
            // 
            this.guna2ContextMenuStrip1.BackColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.guna2ContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmb_sortingby,
            this.cmb_refresh,
            this.toolStripSeparator1,
            this.cmb_show,
            this.col_addnew,
            this.cmb_update,
            this.cmb_delete,
            this.toolStripMenuItem1,
            this.cmb_showmoretools});
            this.guna2ContextMenuStrip1.Name = "guna2ContextMenuStrip1";
            this.guna2ContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.ColorTable = null;
            this.guna2ContextMenuStrip1.RenderStyle.RoundedEdges = true;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.guna2ContextMenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.guna2ContextMenuStrip1.Size = new System.Drawing.Size(276, 273);
            // 
            // cmb_sortingby
            // 
            this.cmb_sortingby.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmb_userfullname,
            this.cmb_username,
            this.cmb_gender});
            this.cmb_sortingby.Name = "cmb_sortingby";
            this.cmb_sortingby.Size = new System.Drawing.Size(275, 32);
            this.cmb_sortingby.Text = "فرز حسب";
            // 
            // cmb_userfullname
            // 
            this.cmb_userfullname.BackColor = System.Drawing.Color.White;
            this.cmb_userfullname.Name = "cmb_userfullname";
            this.cmb_userfullname.Size = new System.Drawing.Size(270, 34);
            this.cmb_userfullname.Text = "الأسم";
            // 
            // cmb_username
            // 
            this.cmb_username.BackColor = System.Drawing.Color.White;
            this.cmb_username.Name = "cmb_username";
            this.cmb_username.Size = new System.Drawing.Size(270, 34);
            this.cmb_username.Text = "أسم المستخدم";
            // 
            // cmb_refresh
            // 
            this.cmb_refresh.Name = "cmb_refresh";
            this.cmb_refresh.Size = new System.Drawing.Size(275, 32);
            this.cmb_refresh.Text = "تحديث";
            this.cmb_refresh.ToolTipText = "تحديث الصفحة";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(272, 6);
            // 
            // col_addnew
            // 
            this.col_addnew.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmb_managementappuser,
            this.cmb_servicesappuser});
            this.col_addnew.Name = "col_addnew";
            this.col_addnew.Size = new System.Drawing.Size(275, 32);
            this.col_addnew.Text = "إضافة جديد";
            // 
            // cmb_update
            // 
            this.cmb_update.Name = "cmb_update";
            this.cmb_update.Size = new System.Drawing.Size(275, 32);
            this.cmb_update.Text = "تعديل";
            this.cmb_update.ToolTipText = "تعديل بيانات المستخدم";
            // 
            // cmb_delete
            // 
            this.cmb_delete.Name = "cmb_delete";
            this.cmb_delete.Size = new System.Drawing.Size(275, 32);
            this.cmb_delete.Text = "حذف";
            this.cmb_delete.ToolTipText = "حذف المستخدم";
            // 
            // cmb_gender
            // 
            this.cmb_gender.BackColor = System.Drawing.Color.White;
            this.cmb_gender.Name = "cmb_gender";
            this.cmb_gender.Size = new System.Drawing.Size(270, 34);
            this.cmb_gender.Text = "الجنس";
            // 
            // cmb_managementappuser
            // 
            this.cmb_managementappuser.BackColor = System.Drawing.Color.White;
            this.cmb_managementappuser.Name = "cmb_managementappuser";
            this.cmb_managementappuser.Size = new System.Drawing.Size(296, 34);
            this.cmb_managementappuser.Text = "مستخدم برنامج الإدارة";
            this.cmb_managementappuser.ToolTipText = "إضافة مستخدم برنامج الإدارة";
            // 
            // cmb_servicesappuser
            // 
            this.cmb_servicesappuser.BackColor = System.Drawing.Color.White;
            this.cmb_servicesappuser.Name = "cmb_servicesappuser";
            this.cmb_servicesappuser.Size = new System.Drawing.Size(296, 34);
            this.cmb_servicesappuser.Text = "مستخدم برنامج الخدمات";
            this.cmb_servicesappuser.ToolTipText = "إضافة مستخدم برنامج الخدمات";
            // 
            // cmb_show
            // 
            this.cmb_show.Name = "cmb_show";
            this.cmb_show.Size = new System.Drawing.Size(275, 32);
            this.cmb_show.Text = "عرض";
            this.cmb_show.ToolTipText = "عرض معلومات المستخدم";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(272, 6);
            // 
            // cmb_showmoretools
            // 
            this.cmb_showmoretools.Name = "cmb_showmoretools";
            this.cmb_showmoretools.Size = new System.Drawing.Size(275, 32);
            this.cmb_showmoretools.Text = "إضهار المزيد من الخيارات";
            // 
            // UC_Users
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dgv_users);
            this.Controls.Add(this.pnl_Top);
            this.Name = "UC_Users";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(1300, 700);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_users)).EndInit();
            this.pnl_Top.ResumeLayout(false);
            this.guna2ContextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgv_users;
        private System.Windows.Forms.Panel pnl_Top;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
        private Guna.UI2.WinForms.Guna2ComboBox cb_filter;
        private Guna.UI2.WinForms.Guna2Button btn_search;
        private Guna.UI2.WinForms.Guna2TextBox txt_searchan;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_fullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_username;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_phonenumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_gender;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_userid;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cmb_sortingby;
        private System.Windows.Forms.ToolStripMenuItem cmb_userfullname;
        private System.Windows.Forms.ToolStripMenuItem cmb_username;
        private System.Windows.Forms.ToolStripMenuItem cmb_refresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem col_addnew;
        private System.Windows.Forms.ToolStripMenuItem cmb_update;
        private System.Windows.Forms.ToolStripMenuItem cmb_delete;
        private System.Windows.Forms.ToolStripMenuItem cmb_gender;
        private System.Windows.Forms.ToolStripMenuItem cmb_managementappuser;
        private System.Windows.Forms.ToolStripMenuItem cmb_servicesappuser;
        private System.Windows.Forms.ToolStripMenuItem cmb_show;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cmb_showmoretools;
    }
}
