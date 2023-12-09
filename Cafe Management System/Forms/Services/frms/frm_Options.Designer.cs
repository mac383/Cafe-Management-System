namespace Cafe_Management_System.Forms.Services.frms
{
    partial class frm_Options
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl_Container = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.dgv_options = new Guna.UI2.WinForms.Guna2DataGridView();
            this.col_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_optionname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_optionprice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_servicename = new System.Windows.Forms.DataGridViewLinkColumn();
            this.col_optionid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_optionvalue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.إضافةToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.الاسمToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.السعرToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cmb_addnew = new System.Windows.Forms.ToolStripMenuItem();
            this.cmb_update = new System.Windows.Forms.ToolStripMenuItem();
            this.cmb_delete = new System.Windows.Forms.ToolStripMenuItem();
            this.pnl_Header = new System.Windows.Forms.Panel();
            this.lbl_pagetitle = new System.Windows.Forms.Label();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.pnl_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_options)).BeginInit();
            this.guna2ContextMenuStrip1.SuspendLayout();
            this.pnl_Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Container
            // 
            this.pnl_Container.BackColor = System.Drawing.Color.Transparent;
            this.pnl_Container.Controls.Add(this.dgv_options);
            this.pnl_Container.Controls.Add(this.pnl_Header);
            this.pnl_Container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Container.FillColor = System.Drawing.Color.White;
            this.pnl_Container.Location = new System.Drawing.Point(0, 0);
            this.pnl_Container.Name = "pnl_Container";
            this.pnl_Container.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.pnl_Container.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(108)))), ((int)(((byte)(190)))));
            this.pnl_Container.ShadowDepth = 250;
            this.pnl_Container.ShadowShift = 10;
            this.pnl_Container.Size = new System.Drawing.Size(958, 568);
            this.pnl_Container.TabIndex = 0;
            // 
            // dgv_options
            // 
            this.dgv_options.AllowUserToAddRows = false;
            this.dgv_options.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_options.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_options.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_options.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_options.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgv_options.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
            this.dgv_options.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_options.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_options.ColumnHeadersHeight = 25;
            this.dgv_options.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_ID,
            this.col_optionname,
            this.col_optionprice,
            this.col_servicename,
            this.col_optionid,
            this.col_optionvalue});
            this.dgv_options.ContextMenuStrip = this.guna2ContextMenuStrip1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_options.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_options.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_options.Location = new System.Drawing.Point(12, 50);
            this.dgv_options.MultiSelect = false;
            this.dgv_options.Name = "dgv_options";
            this.dgv_options.ReadOnly = true;
            this.dgv_options.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgv_options.RowHeadersVisible = false;
            this.dgv_options.RowHeadersWidth = 62;
            this.dgv_options.RowTemplate.Height = 30;
            this.dgv_options.Size = new System.Drawing.Size(934, 506);
            this.dgv_options.TabIndex = 10;
            this.dgv_options.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_options.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_options.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_options.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_options.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_options.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_options.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_options.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_options.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_options.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_options.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_options.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_options.ThemeStyle.HeaderStyle.Height = 25;
            this.dgv_options.ThemeStyle.ReadOnly = true;
            this.dgv_options.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_options.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
            this.dgv_options.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_options.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_options.ThemeStyle.RowsStyle.Height = 30;
            this.dgv_options.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_options.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_options.DoubleClick += new System.EventHandler(this.dgv_options_DoubleClick);
            // 
            // col_ID
            // 
            this.col_ID.FillWeight = 50F;
            this.col_ID.HeaderText = "ت";
            this.col_ID.MinimumWidth = 8;
            this.col_ID.Name = "col_ID";
            this.col_ID.ReadOnly = true;
            // 
            // col_optionname
            // 
            this.col_optionname.FillWeight = 160F;
            this.col_optionname.HeaderText = "الخيار";
            this.col_optionname.MinimumWidth = 8;
            this.col_optionname.Name = "col_optionname";
            this.col_optionname.ReadOnly = true;
            // 
            // col_optionprice
            // 
            this.col_optionprice.HeaderText = "السعر";
            this.col_optionprice.MinimumWidth = 8;
            this.col_optionprice.Name = "col_optionprice";
            this.col_optionprice.ReadOnly = true;
            // 
            // col_servicename
            // 
            this.col_servicename.FillWeight = 120F;
            this.col_servicename.HeaderText = "الخدمة";
            this.col_servicename.MinimumWidth = 8;
            this.col_servicename.Name = "col_servicename";
            this.col_servicename.ReadOnly = true;
            this.col_servicename.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.col_servicename.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.col_servicename.ToolTipText = "أنقر للعرض";
            // 
            // col_optionid
            // 
            this.col_optionid.HeaderText = "Option ID";
            this.col_optionid.MinimumWidth = 8;
            this.col_optionid.Name = "col_optionid";
            this.col_optionid.ReadOnly = true;
            this.col_optionid.Visible = false;
            // 
            // col_optionvalue
            // 
            this.col_optionvalue.HeaderText = "Option Value";
            this.col_optionvalue.MinimumWidth = 8;
            this.col_optionvalue.Name = "col_optionvalue";
            this.col_optionvalue.ReadOnly = true;
            this.col_optionvalue.Visible = false;
            // 
            // guna2ContextMenuStrip1
            // 
            this.guna2ContextMenuStrip1.BackColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.guna2ContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.إضافةToolStripMenuItem,
            this.toolStripSeparator1,
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
            this.guna2ContextMenuStrip1.Size = new System.Drawing.Size(206, 138);
            // 
            // إضافةToolStripMenuItem
            // 
            this.إضافةToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.الاسمToolStripMenuItem,
            this.السعرToolStripMenuItem});
            this.إضافةToolStripMenuItem.Name = "إضافةToolStripMenuItem";
            this.إضافةToolStripMenuItem.Size = new System.Drawing.Size(205, 32);
            this.إضافةToolStripMenuItem.Text = "فرز حسب";
            // 
            // الاسمToolStripMenuItem
            // 
            this.الاسمToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.الاسمToolStripMenuItem.Name = "الاسمToolStripMenuItem";
            this.الاسمToolStripMenuItem.Size = new System.Drawing.Size(159, 34);
            this.الاسمToolStripMenuItem.Text = "الاسم";
            // 
            // السعرToolStripMenuItem
            // 
            this.السعرToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.السعرToolStripMenuItem.Name = "السعرToolStripMenuItem";
            this.السعرToolStripMenuItem.Size = new System.Drawing.Size(159, 34);
            this.السعرToolStripMenuItem.Text = "السعر";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(202, 6);
            // 
            // cmb_addnew
            // 
            this.cmb_addnew.Name = "cmb_addnew";
            this.cmb_addnew.Size = new System.Drawing.Size(205, 32);
            this.cmb_addnew.Text = "إضافة خيار جديد";
            this.cmb_addnew.Click += new System.EventHandler(this.cmb_addnew_Click);
            // 
            // cmb_update
            // 
            this.cmb_update.Name = "cmb_update";
            this.cmb_update.Size = new System.Drawing.Size(205, 32);
            this.cmb_update.Text = "تعديل";
            this.cmb_update.Click += new System.EventHandler(this.cmb_update_Click);
            // 
            // cmb_delete
            // 
            this.cmb_delete.Name = "cmb_delete";
            this.cmb_delete.Size = new System.Drawing.Size(205, 32);
            this.cmb_delete.Text = "حذف";
            this.cmb_delete.Click += new System.EventHandler(this.cmb_delete_Click);
            // 
            // pnl_Header
            // 
            this.pnl_Header.Controls.Add(this.lbl_pagetitle);
            this.pnl_Header.Controls.Add(this.guna2ControlBox1);
            this.pnl_Header.Location = new System.Drawing.Point(12, 12);
            this.pnl_Header.Name = "pnl_Header";
            this.pnl_Header.Size = new System.Drawing.Size(934, 41);
            this.pnl_Header.TabIndex = 1;
            // 
            // lbl_pagetitle
            // 
            this.lbl_pagetitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_pagetitle.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pagetitle.Location = new System.Drawing.Point(627, 8);
            this.lbl_pagetitle.Name = "lbl_pagetitle";
            this.lbl_pagetitle.Size = new System.Drawing.Size(299, 24);
            this.lbl_pagetitle.TabIndex = 7;
            this.lbl_pagetitle.Text = "خيارات الخدمة (عصائر)";
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.guna2ControlBox1.ControlBoxStyle = Guna.UI2.WinForms.Enums.ControlBoxStyle.Custom;
            this.guna2ControlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ControlBox1.CustomIconSize = 12F;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.Red;
            this.guna2ControlBox1.Location = new System.Drawing.Point(4, 8);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.Size = new System.Drawing.Size(25, 25);
            this.guna2ControlBox1.TabIndex = 6;
            // 
            // frm_Options
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(958, 568);
            this.Controls.Add(this.pnl_Container);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Options";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Options";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_Options_FormClosing);
            this.Load += new System.EventHandler(this.frm_Options_Load);
            this.pnl_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_options)).EndInit();
            this.guna2ContextMenuStrip1.ResumeLayout(false);
            this.pnl_Header.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel pnl_Container;
        private System.Windows.Forms.Panel pnl_Header;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_options;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_optionname;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_optionprice;
        private System.Windows.Forms.DataGridViewLinkColumn col_servicename;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_optionid;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_optionvalue;
        private System.Windows.Forms.Label lbl_pagetitle;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem إضافةToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem الاسمToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem cmb_addnew;
        private System.Windows.Forms.ToolStripMenuItem cmb_update;
        private System.Windows.Forms.ToolStripMenuItem cmb_delete;
        private System.Windows.Forms.ToolStripMenuItem السعرToolStripMenuItem;
    }
}