namespace Cafe_Management_System.Forms.Services.UserControls
{
    partial class UC_ServicesDepartment
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
            this.guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.cmb_sortby = new System.Windows.Forms.ToolStripMenuItem();
            this.cmb_sortbydepartmentname = new System.Windows.Forms.ToolStripMenuItem();
            this.تعديلToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.cmb_showservices = new System.Windows.Forms.ToolStripMenuItem();
            this.حذفToolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.cmb_addnew = new System.Windows.Forms.ToolStripMenuItem();
            this.cmb_update = new System.Windows.Forms.ToolStripMenuItem();
            this.cmb_delete = new System.Windows.Forms.ToolStripMenuItem();
            this.dgv_servicesdepartments = new Guna.UI2.WinForms.Guna2DataGridView();
            this.col_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_DepartmentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_DepartmentContainCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_DepartmentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_departmentimage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmb_refresh = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.guna2ContextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_servicesdepartments)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2ContextMenuStrip1
            // 
            this.guna2ContextMenuStrip1.BackColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.guna2ContextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmb_sortby,
            this.تعديلToolStripMenuItem,
            this.cmb_showservices,
            this.حذفToolStripMenuItem1,
            this.cmb_refresh,
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
            this.guna2ContextMenuStrip1.Size = new System.Drawing.Size(181, 176);
            // 
            // cmb_sortby
            // 
            this.cmb_sortby.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmb_sortbydepartmentname});
            this.cmb_sortby.Name = "cmb_sortby";
            this.cmb_sortby.Size = new System.Drawing.Size(180, 22);
            this.cmb_sortby.Text = "فرز حسب";
            // 
            // cmb_sortbydepartmentname
            // 
            this.cmb_sortbydepartmentname.BackColor = System.Drawing.Color.White;
            this.cmb_sortbydepartmentname.Name = "cmb_sortbydepartmentname";
            this.cmb_sortbydepartmentname.Size = new System.Drawing.Size(180, 22);
            this.cmb_sortbydepartmentname.Text = "الاسم";
            this.cmb_sortbydepartmentname.Click += new System.EventHandler(this.cmb_sortbydepartmentname_Click);
            // 
            // تعديلToolStripMenuItem
            // 
            this.تعديلToolStripMenuItem.Name = "تعديلToolStripMenuItem";
            this.تعديلToolStripMenuItem.Size = new System.Drawing.Size(177, 6);
            // 
            // cmb_showservices
            // 
            this.cmb_showservices.Name = "cmb_showservices";
            this.cmb_showservices.Size = new System.Drawing.Size(180, 22);
            this.cmb_showservices.Text = "عرض الخدمات";
            // 
            // حذفToolStripMenuItem1
            // 
            this.حذفToolStripMenuItem1.Name = "حذفToolStripMenuItem1";
            this.حذفToolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // cmb_addnew
            // 
            this.cmb_addnew.Name = "cmb_addnew";
            this.cmb_addnew.Size = new System.Drawing.Size(180, 22);
            this.cmb_addnew.Text = "إضافة جديد";
            this.cmb_addnew.Click += new System.EventHandler(this.cmb_addnew_Click);
            // 
            // cmb_update
            // 
            this.cmb_update.Name = "cmb_update";
            this.cmb_update.Size = new System.Drawing.Size(180, 22);
            this.cmb_update.Text = "تعديل";
            this.cmb_update.Click += new System.EventHandler(this.cmb_update_Click);
            // 
            // cmb_delete
            // 
            this.cmb_delete.Name = "cmb_delete";
            this.cmb_delete.Size = new System.Drawing.Size(180, 22);
            this.cmb_delete.Text = "حذف";
            this.cmb_delete.Click += new System.EventHandler(this.cmb_delete_Click);
            // 
            // dgv_servicesdepartments
            // 
            this.dgv_servicesdepartments.AllowUserToAddRows = false;
            this.dgv_servicesdepartments.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_servicesdepartments.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_servicesdepartments.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_servicesdepartments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgv_servicesdepartments.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
            this.dgv_servicesdepartments.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_servicesdepartments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_servicesdepartments.ColumnHeadersHeight = 40;
            this.dgv_servicesdepartments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_ID,
            this.col_DepartmentName,
            this.col_DepartmentContainCount,
            this.col_DepartmentID,
            this.col_departmentimage});
            this.dgv_servicesdepartments.ContextMenuStrip = this.guna2ContextMenuStrip1;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_servicesdepartments.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_servicesdepartments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_servicesdepartments.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_servicesdepartments.Location = new System.Drawing.Point(0, 0);
            this.dgv_servicesdepartments.MultiSelect = false;
            this.dgv_servicesdepartments.Name = "dgv_servicesdepartments";
            this.dgv_servicesdepartments.ReadOnly = true;
            this.dgv_servicesdepartments.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgv_servicesdepartments.RowHeadersVisible = false;
            this.dgv_servicesdepartments.RowHeadersWidth = 62;
            this.dgv_servicesdepartments.RowTemplate.Height = 30;
            this.dgv_servicesdepartments.Size = new System.Drawing.Size(1300, 700);
            this.dgv_servicesdepartments.TabIndex = 8;
            this.dgv_servicesdepartments.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_servicesdepartments.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_servicesdepartments.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_servicesdepartments.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_servicesdepartments.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_servicesdepartments.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_servicesdepartments.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_servicesdepartments.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_servicesdepartments.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgv_servicesdepartments.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_servicesdepartments.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_servicesdepartments.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgv_servicesdepartments.ThemeStyle.HeaderStyle.Height = 40;
            this.dgv_servicesdepartments.ThemeStyle.ReadOnly = true;
            this.dgv_servicesdepartments.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_servicesdepartments.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
            this.dgv_servicesdepartments.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_servicesdepartments.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_servicesdepartments.ThemeStyle.RowsStyle.Height = 30;
            this.dgv_servicesdepartments.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_servicesdepartments.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_servicesdepartments.DoubleClick += new System.EventHandler(this.dgv_servicesdepartments_DoubleClick);
            // 
            // col_ID
            // 
            this.col_ID.FillWeight = 50F;
            this.col_ID.HeaderText = "ت";
            this.col_ID.MinimumWidth = 8;
            this.col_ID.Name = "col_ID";
            this.col_ID.ReadOnly = true;
            // 
            // col_DepartmentName
            // 
            this.col_DepartmentName.FillWeight = 150F;
            this.col_DepartmentName.HeaderText = "القسم";
            this.col_DepartmentName.MinimumWidth = 8;
            this.col_DepartmentName.Name = "col_DepartmentName";
            this.col_DepartmentName.ReadOnly = true;
            // 
            // col_DepartmentContainCount
            // 
            this.col_DepartmentContainCount.FillWeight = 70F;
            this.col_DepartmentContainCount.HeaderText = "الخدمات";
            this.col_DepartmentContainCount.MinimumWidth = 8;
            this.col_DepartmentContainCount.Name = "col_DepartmentContainCount";
            this.col_DepartmentContainCount.ReadOnly = true;
            // 
            // col_DepartmentID
            // 
            this.col_DepartmentID.HeaderText = "DepartmentID";
            this.col_DepartmentID.MinimumWidth = 8;
            this.col_DepartmentID.Name = "col_DepartmentID";
            this.col_DepartmentID.ReadOnly = true;
            this.col_DepartmentID.Visible = false;
            // 
            // col_departmentimage
            // 
            this.col_departmentimage.HeaderText = "Department Image";
            this.col_departmentimage.Name = "col_departmentimage";
            this.col_departmentimage.ReadOnly = true;
            this.col_departmentimage.Visible = false;
            // 
            // cmb_refresh
            // 
            this.cmb_refresh.Name = "cmb_refresh";
            this.cmb_refresh.Size = new System.Drawing.Size(180, 22);
            this.cmb_refresh.Text = "تحديث";
            this.cmb_refresh.Click += new System.EventHandler(this.cmb_refresh_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // UC_ServicesDepartment
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dgv_servicesdepartments);
            this.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UC_ServicesDepartment";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(1300, 700);
            this.Load += new System.EventHandler(this.UC_ServicesDepartment_Load);
            this.guna2ContextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_servicesdepartments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cmb_sortby;
        private System.Windows.Forms.ToolStripMenuItem cmb_sortbydepartmentname;
        private System.Windows.Forms.ToolStripSeparator تعديلToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cmb_showservices;
        private System.Windows.Forms.ToolStripSeparator حذفToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cmb_addnew;
        private System.Windows.Forms.ToolStripMenuItem cmb_update;
        private System.Windows.Forms.ToolStripMenuItem cmb_delete;
        private Guna.UI2.WinForms.Guna2DataGridView dgv_servicesdepartments;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_DepartmentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_DepartmentContainCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_DepartmentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_departmentimage;
        private System.Windows.Forms.ToolStripMenuItem cmb_refresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}
