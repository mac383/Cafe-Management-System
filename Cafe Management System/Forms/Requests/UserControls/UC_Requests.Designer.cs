namespace Cafe_Management_System.Forms.Requests.UserControls
{
    partial class UC_Requests
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
            this.dgv_requests = new Guna.UI2.WinForms.Guna2DataGridView();
            this.pnl_Top = new System.Windows.Forms.Panel();
            this.guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.cb_filter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btn_search = new Guna.UI2.WinForms.Guna2Button();
            this.txt_resertvationname = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.إضافةToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmb_id = new System.Windows.Forms.ToolStripMenuItem();
            this.cms_separator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cmb_addtoaccountinglater = new System.Windows.Forms.ToolStripMenuItem();
            this.cmb_accountrequest = new System.Windows.Forms.ToolStripMenuItem();
            this.cms_separator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cmb_deleterequest = new System.Windows.Forms.ToolStripMenuItem();
            this.cmb_reservationname = new System.Windows.Forms.ToolStripMenuItem();
            this.cmb_requeststatus = new System.Windows.Forms.ToolStripMenuItem();
            this.col_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_reservationname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_statusname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_requestcode = new System.Windows.Forms.DataGridViewLinkColumn();
            this.col_byuser = new System.Windows.Forms.DataGridViewLinkColumn();
            this.col_requestid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_statusvalue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_services = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_requests)).BeginInit();
            this.pnl_Top.SuspendLayout();
            this.guna2ContextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_requests
            // 
            this.dgv_requests.AllowUserToAddRows = false;
            this.dgv_requests.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_requests.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_requests.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_requests.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgv_requests.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_requests.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_requests.ColumnHeadersHeight = 40;
            this.dgv_requests.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_ID,
            this.col_reservationname,
            this.col_statusname,
            this.col_requestcode,
            this.col_byuser,
            this.col_requestid,
            this.col_statusvalue,
            this.col_services});
            this.dgv_requests.ContextMenuStrip = this.guna2ContextMenuStrip1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_requests.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_requests.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_requests.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_requests.Location = new System.Drawing.Point(0, 68);
            this.dgv_requests.MultiSelect = false;
            this.dgv_requests.Name = "dgv_requests";
            this.dgv_requests.ReadOnly = true;
            this.dgv_requests.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgv_requests.RowHeadersVisible = false;
            this.dgv_requests.RowHeadersWidth = 62;
            this.dgv_requests.RowTemplate.Height = 30;
            this.dgv_requests.Size = new System.Drawing.Size(1300, 632);
            this.dgv_requests.TabIndex = 9;
            this.dgv_requests.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_requests.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_requests.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_requests.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_requests.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_requests.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_requests.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_requests.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_requests.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_requests.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_requests.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_requests.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_requests.ThemeStyle.HeaderStyle.Height = 40;
            this.dgv_requests.ThemeStyle.ReadOnly = true;
            this.dgv_requests.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_requests.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_requests.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_requests.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_requests.ThemeStyle.RowsStyle.Height = 30;
            this.dgv_requests.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_requests.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_requests.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_requests_CellContentClick);
            // 
            // pnl_Top
            // 
            this.pnl_Top.Controls.Add(this.guna2VSeparator1);
            this.pnl_Top.Controls.Add(this.cb_filter);
            this.pnl_Top.Controls.Add(this.btn_search);
            this.pnl_Top.Controls.Add(this.txt_resertvationname);
            this.pnl_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Top.Location = new System.Drawing.Point(0, 0);
            this.pnl_Top.Name = "pnl_Top";
            this.pnl_Top.Size = new System.Drawing.Size(1300, 68);
            this.pnl_Top.TabIndex = 11;
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
            "طلبات المحاسبة",
            "طلبات المحاسبة لاحقا",
            "طلبات سيتم محاسبتها لاحقا",
            "طلبات تم محاسبتها"});
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
            // txt_resertvationname
            // 
            this.txt_resertvationname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_resertvationname.BorderRadius = 4;
            this.txt_resertvationname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_resertvationname.DefaultText = "";
            this.txt_resertvationname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_resertvationname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_resertvationname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_resertvationname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_resertvationname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_resertvationname.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_resertvationname.ForeColor = System.Drawing.Color.Black;
            this.txt_resertvationname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_resertvationname.Location = new System.Drawing.Point(919, 10);
            this.txt_resertvationname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_resertvationname.Name = "txt_resertvationname";
            this.txt_resertvationname.PasswordChar = '\0';
            this.txt_resertvationname.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_resertvationname.PlaceholderText = "أسم الحجز / رمز الطلب";
            this.txt_resertvationname.SelectedText = "";
            this.txt_resertvationname.Size = new System.Drawing.Size(225, 48);
            this.txt_resertvationname.TabIndex = 11;
            this.txt_resertvationname.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // guna2ContextMenuStrip1
            // 
            this.guna2ContextMenuStrip1.BackColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.guna2ContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.إضافةToolStripMenuItem,
            this.cms_separator1,
            this.cmb_addtoaccountinglater,
            this.cmb_accountrequest,
            this.cms_separator2,
            this.cmb_deleterequest});
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
            this.guna2ContextMenuStrip1.Size = new System.Drawing.Size(198, 104);
            this.guna2ContextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.guna2ContextMenuStrip1_Opening);
            // 
            // إضافةToolStripMenuItem
            // 
            this.إضافةToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmb_id,
            this.cmb_reservationname,
            this.cmb_requeststatus});
            this.إضافةToolStripMenuItem.Name = "إضافةToolStripMenuItem";
            this.إضافةToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.إضافةToolStripMenuItem.Text = "فرز حسب";
            // 
            // cmb_id
            // 
            this.cmb_id.BackColor = System.Drawing.Color.White;
            this.cmb_id.Name = "cmb_id";
            this.cmb_id.Size = new System.Drawing.Size(180, 22);
            this.cmb_id.Text = "التسلسل";
            // 
            // cms_separator1
            // 
            this.cms_separator1.Name = "cms_separator1";
            this.cms_separator1.Size = new System.Drawing.Size(194, 6);
            // 
            // cmb_addtoaccountinglater
            // 
            this.cmb_addtoaccountinglater.Name = "cmb_addtoaccountinglater";
            this.cmb_addtoaccountinglater.Size = new System.Drawing.Size(197, 22);
            this.cmb_addtoaccountinglater.Text = "إضافة الئ المحاسبة لاحقاً";
            this.cmb_addtoaccountinglater.Click += new System.EventHandler(this.cmb_addtoaccountinglater_Click);
            // 
            // cmb_accountrequest
            // 
            this.cmb_accountrequest.Name = "cmb_accountrequest";
            this.cmb_accountrequest.Size = new System.Drawing.Size(197, 22);
            this.cmb_accountrequest.Text = "محاسبة الطلب";
            this.cmb_accountrequest.Click += new System.EventHandler(this.cmb_accountrequest_Click);
            // 
            // cms_separator2
            // 
            this.cms_separator2.Name = "cms_separator2";
            this.cms_separator2.Size = new System.Drawing.Size(194, 6);
            // 
            // cmb_deleterequest
            // 
            this.cmb_deleterequest.Name = "cmb_deleterequest";
            this.cmb_deleterequest.Size = new System.Drawing.Size(197, 22);
            this.cmb_deleterequest.Text = "حذف الطلب";
            this.cmb_deleterequest.Click += new System.EventHandler(this.cmb_deleterequest_Click);
            // 
            // cmb_reservationname
            // 
            this.cmb_reservationname.BackColor = System.Drawing.Color.White;
            this.cmb_reservationname.Name = "cmb_reservationname";
            this.cmb_reservationname.Size = new System.Drawing.Size(180, 22);
            this.cmb_reservationname.Text = "اسم الحجز";
            // 
            // cmb_requeststatus
            // 
            this.cmb_requeststatus.BackColor = System.Drawing.Color.White;
            this.cmb_requeststatus.Name = "cmb_requeststatus";
            this.cmb_requeststatus.Size = new System.Drawing.Size(180, 22);
            this.cmb_requeststatus.Text = "حالة الطلب";
            // 
            // col_ID
            // 
            this.col_ID.FillWeight = 40F;
            this.col_ID.HeaderText = "ت";
            this.col_ID.MinimumWidth = 8;
            this.col_ID.Name = "col_ID";
            this.col_ID.ReadOnly = true;
            // 
            // col_reservationname
            // 
            this.col_reservationname.HeaderText = "أسم الحجز";
            this.col_reservationname.MinimumWidth = 8;
            this.col_reservationname.Name = "col_reservationname";
            this.col_reservationname.ReadOnly = true;
            // 
            // col_statusname
            // 
            this.col_statusname.HeaderText = "حالة ا لطلب";
            this.col_statusname.MinimumWidth = 8;
            this.col_statusname.Name = "col_statusname";
            this.col_statusname.ReadOnly = true;
            // 
            // col_requestcode
            // 
            this.col_requestcode.FillWeight = 75F;
            this.col_requestcode.HeaderText = "رمز الطلب";
            this.col_requestcode.MinimumWidth = 8;
            this.col_requestcode.Name = "col_requestcode";
            this.col_requestcode.ReadOnly = true;
            this.col_requestcode.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_requestcode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.col_requestcode.ToolTipText = "أنقر للنسخ";
            // 
            // col_byuser
            // 
            this.col_byuser.HeaderText = "تم بواسطة";
            this.col_byuser.MinimumWidth = 8;
            this.col_byuser.Name = "col_byuser";
            this.col_byuser.ReadOnly = true;
            this.col_byuser.ToolTipText = "أنقر للذهاب لصفحة المستخدم";
            // 
            // col_requestid
            // 
            this.col_requestid.HeaderText = "Request ID";
            this.col_requestid.MinimumWidth = 8;
            this.col_requestid.Name = "col_requestid";
            this.col_requestid.ReadOnly = true;
            this.col_requestid.Visible = false;
            // 
            // col_statusvalue
            // 
            this.col_statusvalue.HeaderText = "Status Value";
            this.col_statusvalue.MinimumWidth = 8;
            this.col_statusvalue.Name = "col_statusvalue";
            this.col_statusvalue.ReadOnly = true;
            this.col_statusvalue.Visible = false;
            // 
            // col_services
            // 
            this.col_services.HeaderText = "عرض الخدمات";
            this.col_services.Name = "col_services";
            this.col_services.ReadOnly = true;
            this.col_services.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_services.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.col_services.ToolTipText = "أنقر لعرض الخدمات التي تم طلبها";
            // 
            // UC_Requests
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dgv_requests);
            this.Controls.Add(this.pnl_Top);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UC_Requests";
            this.Size = new System.Drawing.Size(1300, 700);
            this.Load += new System.EventHandler(this.UC_Requests_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_requests)).EndInit();
            this.pnl_Top.ResumeLayout(false);
            this.guna2ContextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgv_requests;
        private System.Windows.Forms.Panel pnl_Top;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
        private Guna.UI2.WinForms.Guna2ComboBox cb_filter;
        private Guna.UI2.WinForms.Guna2Button btn_search;
        private Guna.UI2.WinForms.Guna2TextBox txt_resertvationname;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem إضافةToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cmb_id;
        private System.Windows.Forms.ToolStripSeparator cms_separator1;
        private System.Windows.Forms.ToolStripMenuItem cmb_addtoaccountinglater;
        private System.Windows.Forms.ToolStripMenuItem cmb_accountrequest;
        private System.Windows.Forms.ToolStripSeparator cms_separator2;
        private System.Windows.Forms.ToolStripMenuItem cmb_deleterequest;
        private System.Windows.Forms.ToolStripMenuItem cmb_reservationname;
        private System.Windows.Forms.ToolStripMenuItem cmb_requeststatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_reservationname;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_statusname;
        private System.Windows.Forms.DataGridViewLinkColumn col_requestcode;
        private System.Windows.Forms.DataGridViewLinkColumn col_byuser;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_requestid;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_statusvalue;
        private System.Windows.Forms.DataGridViewLinkColumn col_services;
    }
}
