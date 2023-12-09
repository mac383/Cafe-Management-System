namespace Cafe_Management_System.Forms.Services.UserControls
{
    partial class UC_Services
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
            this.dgv_services = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.إضافةToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.الاسمToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cmb_showoptions = new System.Windows.Forms.ToolStripMenuItem();
            this.cmb_addoption = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cmb_addnew = new System.Windows.Forms.ToolStripMenuItem();
            this.cmb_update = new System.Windows.Forms.ToolStripMenuItem();
            this.cmb_delete = new System.Windows.Forms.ToolStripMenuItem();
            this.pnl_Top = new System.Windows.Forms.Panel();
            this.guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.cb_filter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.txt_searchtable = new Guna.UI2.WinForms.Guna2TextBox();
            this.col_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_servicename = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_servicedescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_departmentname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_serviceoptions = new System.Windows.Forms.DataGridViewLinkColumn();
            this.col_serviceid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_serviceimage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_services)).BeginInit();
            this.guna2ContextMenuStrip1.SuspendLayout();
            this.pnl_Top.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_services
            // 
            this.dgv_services.AllowUserToAddRows = false;
            this.dgv_services.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_services.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_services.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_services.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgv_services.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
            this.dgv_services.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_services.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_services.ColumnHeadersHeight = 40;
            this.dgv_services.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_ID,
            this.col_servicename,
            this.col_servicedescription,
            this.col_departmentname,
            this.col_serviceoptions,
            this.col_serviceid,
            this.col_serviceimage});
            this.dgv_services.ContextMenuStrip = this.guna2ContextMenuStrip1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_services.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_services.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_services.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_services.Location = new System.Drawing.Point(0, 68);
            this.dgv_services.MultiSelect = false;
            this.dgv_services.Name = "dgv_services";
            this.dgv_services.ReadOnly = true;
            this.dgv_services.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgv_services.RowHeadersVisible = false;
            this.dgv_services.RowHeadersWidth = 62;
            this.dgv_services.RowTemplate.Height = 30;
            this.dgv_services.Size = new System.Drawing.Size(1300, 632);
            this.dgv_services.TabIndex = 9;
            this.dgv_services.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_services.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_services.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_services.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_services.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_services.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_services.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_services.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_services.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_services.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_services.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_services.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_services.ThemeStyle.HeaderStyle.Height = 40;
            this.dgv_services.ThemeStyle.ReadOnly = true;
            this.dgv_services.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_services.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
            this.dgv_services.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_services.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_services.ThemeStyle.RowsStyle.Height = 30;
            this.dgv_services.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_services.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_services.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_services_CellContentClick);
            this.dgv_services.DoubleClick += new System.EventHandler(this.dgv_services_DoubleClick);
            // 
            // guna2ContextMenuStrip1
            // 
            this.guna2ContextMenuStrip1.BackColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.guna2ContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.إضافةToolStripMenuItem,
            this.toolStripSeparator1,
            this.cmb_showoptions,
            this.cmb_addoption,
            this.toolStripSeparator2,
            this.cmb_addnew,
            this.cmb_update,
            this.cmb_delete});
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
            this.guna2ContextMenuStrip1.Size = new System.Drawing.Size(225, 208);
            // 
            // إضافةToolStripMenuItem
            // 
            this.إضافةToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.الاسمToolStripMenuItem});
            this.إضافةToolStripMenuItem.Name = "إضافةToolStripMenuItem";
            this.إضافةToolStripMenuItem.Size = new System.Drawing.Size(224, 32);
            this.إضافةToolStripMenuItem.Text = "فرز حسب";
            // 
            // الاسمToolStripMenuItem
            // 
            this.الاسمToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.الاسمToolStripMenuItem.Name = "الاسمToolStripMenuItem";
            this.الاسمToolStripMenuItem.Size = new System.Drawing.Size(156, 34);
            this.الاسمToolStripMenuItem.Text = "الاسم";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(221, 6);
            // 
            // cmb_showoptions
            // 
            this.cmb_showoptions.Name = "cmb_showoptions";
            this.cmb_showoptions.Size = new System.Drawing.Size(224, 32);
            this.cmb_showoptions.Text = "عرض الخيارات";
            this.cmb_showoptions.Click += new System.EventHandler(this.cmb_showoptions_Click);
            // 
            // cmb_addoption
            // 
            this.cmb_addoption.Name = "cmb_addoption";
            this.cmb_addoption.Size = new System.Drawing.Size(224, 32);
            this.cmb_addoption.Text = "إضافة خيارات";
            this.cmb_addoption.Click += new System.EventHandler(this.cmb_addoption_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(221, 6);
            // 
            // cmb_addnew
            // 
            this.cmb_addnew.Name = "cmb_addnew";
            this.cmb_addnew.Size = new System.Drawing.Size(224, 32);
            this.cmb_addnew.Text = "إضافة خدمة جديدة";
            this.cmb_addnew.Click += new System.EventHandler(this.cmb_addnew_Click);
            // 
            // cmb_update
            // 
            this.cmb_update.Name = "cmb_update";
            this.cmb_update.Size = new System.Drawing.Size(224, 32);
            this.cmb_update.Text = "تعديل";
            this.cmb_update.Click += new System.EventHandler(this.cmb_update_Click);
            // 
            // cmb_delete
            // 
            this.cmb_delete.Name = "cmb_delete";
            this.cmb_delete.Size = new System.Drawing.Size(224, 32);
            this.cmb_delete.Text = "حذف";
            this.cmb_delete.Click += new System.EventHandler(this.cmb_delete_Click);
            // 
            // pnl_Top
            // 
            this.pnl_Top.Controls.Add(this.guna2VSeparator1);
            this.pnl_Top.Controls.Add(this.cb_filter);
            this.pnl_Top.Controls.Add(this.guna2Button1);
            this.pnl_Top.Controls.Add(this.txt_searchtable);
            this.pnl_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Top.Location = new System.Drawing.Point(0, 0);
            this.pnl_Top.Name = "pnl_Top";
            this.pnl_Top.Size = new System.Drawing.Size(1300, 68);
            this.pnl_Top.TabIndex = 10;
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
            this.cb_filter.Location = new System.Drawing.Point(666, 16);
            this.cb_filter.Name = "cb_filter";
            this.cb_filter.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cb_filter.Size = new System.Drawing.Size(225, 36);
            this.cb_filter.TabIndex = 13;
            this.cb_filter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // guna2Button1
            // 
            this.guna2Button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Button1.BorderRadius = 4;
            this.guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(108)))), ((int)(((byte)(190)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(1151, 10);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(130, 48);
            this.guna2Button1.TabIndex = 12;
            this.guna2Button1.Tag = "1";
            this.guna2Button1.Text = "بحث";
            // 
            // txt_searchtable
            // 
            this.txt_searchtable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_searchtable.BorderRadius = 4;
            this.txt_searchtable.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_searchtable.DefaultText = "";
            this.txt_searchtable.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_searchtable.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_searchtable.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_searchtable.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_searchtable.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_searchtable.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_searchtable.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_searchtable.Location = new System.Drawing.Point(919, 10);
            this.txt_searchtable.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_searchtable.Name = "txt_searchtable";
            this.txt_searchtable.PasswordChar = '\0';
            this.txt_searchtable.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_searchtable.PlaceholderText = "أسم الخدمة";
            this.txt_searchtable.SelectedText = "";
            this.txt_searchtable.Size = new System.Drawing.Size(225, 48);
            this.txt_searchtable.TabIndex = 11;
            this.txt_searchtable.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // col_ID
            // 
            this.col_ID.FillWeight = 50F;
            this.col_ID.HeaderText = "ت";
            this.col_ID.MinimumWidth = 8;
            this.col_ID.Name = "col_ID";
            this.col_ID.ReadOnly = true;
            // 
            // col_servicename
            // 
            this.col_servicename.HeaderText = "الخدمة";
            this.col_servicename.MinimumWidth = 8;
            this.col_servicename.Name = "col_servicename";
            this.col_servicename.ReadOnly = true;
            // 
            // col_servicedescription
            // 
            this.col_servicedescription.FillWeight = 210F;
            this.col_servicedescription.HeaderText = "الوصف";
            this.col_servicedescription.MinimumWidth = 8;
            this.col_servicedescription.Name = "col_servicedescription";
            this.col_servicedescription.ReadOnly = true;
            this.col_servicedescription.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // col_departmentname
            // 
            this.col_departmentname.FillWeight = 80F;
            this.col_departmentname.HeaderText = "القسم";
            this.col_departmentname.MinimumWidth = 8;
            this.col_departmentname.Name = "col_departmentname";
            this.col_departmentname.ReadOnly = true;
            this.col_departmentname.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // col_serviceoptions
            // 
            this.col_serviceoptions.FillWeight = 70F;
            this.col_serviceoptions.HeaderText = "الخيارات";
            this.col_serviceoptions.MinimumWidth = 8;
            this.col_serviceoptions.Name = "col_serviceoptions";
            this.col_serviceoptions.ReadOnly = true;
            this.col_serviceoptions.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_serviceoptions.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.col_serviceoptions.ToolTipText = "أنقر للعرض";
            // 
            // col_serviceid
            // 
            this.col_serviceid.HeaderText = "Service ID";
            this.col_serviceid.MinimumWidth = 8;
            this.col_serviceid.Name = "col_serviceid";
            this.col_serviceid.ReadOnly = true;
            this.col_serviceid.Visible = false;
            // 
            // col_serviceimage
            // 
            this.col_serviceimage.HeaderText = "Service Image";
            this.col_serviceimage.MinimumWidth = 8;
            this.col_serviceimage.Name = "col_serviceimage";
            this.col_serviceimage.ReadOnly = true;
            this.col_serviceimage.Visible = false;
            // 
            // UC_Services
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dgv_services);
            this.Controls.Add(this.pnl_Top);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UC_Services";
            this.Size = new System.Drawing.Size(1300, 700);
            this.Load += new System.EventHandler(this.UC_Services_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_services)).EndInit();
            this.guna2ContextMenuStrip1.ResumeLayout(false);
            this.pnl_Top.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgv_services;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem إضافةToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem الاسمToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cmb_showoptions;
        private System.Windows.Forms.ToolStripMenuItem cmb_addnew;
        private System.Windows.Forms.ToolStripMenuItem cmb_update;
        private System.Windows.Forms.ToolStripMenuItem cmb_delete;
        private System.Windows.Forms.ToolStripMenuItem cmb_addoption;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Panel pnl_Top;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
        private Guna.UI2.WinForms.Guna2ComboBox cb_filter;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2TextBox txt_searchtable;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_servicename;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_servicedescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_departmentname;
        private System.Windows.Forms.DataGridViewLinkColumn col_serviceoptions;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_serviceid;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_serviceimage;
    }
}
