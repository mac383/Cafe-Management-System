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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_servicesdepartments = new Guna.UI2.WinForms.Guna2DataGridView();
            this.col_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_reservationname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_statusname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_requestcode = new System.Windows.Forms.DataGridViewLinkColumn();
            this.col_byuser = new System.Windows.Forms.DataGridViewLinkColumn();
            this.col_requestid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_statusvalue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnl_Top = new System.Windows.Forms.Panel();
            this.guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.cb_filter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btn_search = new Guna.UI2.WinForms.Guna2Button();
            this.txt_reservationname = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_servicesdepartments)).BeginInit();
            this.pnl_Top.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_servicesdepartments
            // 
            this.dgv_servicesdepartments.AllowUserToAddRows = false;
            this.dgv_servicesdepartments.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dgv_servicesdepartments.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgv_servicesdepartments.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgv_servicesdepartments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgv_servicesdepartments.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
            this.dgv_servicesdepartments.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_servicesdepartments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgv_servicesdepartments.ColumnHeadersHeight = 40;
            this.dgv_servicesdepartments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_ID,
            this.col_reservationname,
            this.col_statusname,
            this.col_requestcode,
            this.col_byuser,
            this.col_requestid,
            this.col_statusvalue});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_servicesdepartments.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgv_servicesdepartments.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_servicesdepartments.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_servicesdepartments.Location = new System.Drawing.Point(0, 68);
            this.dgv_servicesdepartments.MultiSelect = false;
            this.dgv_servicesdepartments.Name = "dgv_servicesdepartments";
            this.dgv_servicesdepartments.ReadOnly = true;
            this.dgv_servicesdepartments.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgv_servicesdepartments.RowHeadersVisible = false;
            this.dgv_servicesdepartments.RowHeadersWidth = 62;
            this.dgv_servicesdepartments.RowTemplate.Height = 30;
            this.dgv_servicesdepartments.Size = new System.Drawing.Size(1300, 632);
            this.dgv_servicesdepartments.TabIndex = 9;
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
            // 
            // col_byuser
            // 
            this.col_byuser.HeaderText = "تم بواسطة";
            this.col_byuser.MinimumWidth = 8;
            this.col_byuser.Name = "col_byuser";
            this.col_byuser.ReadOnly = true;
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
            // pnl_Top
            // 
            this.pnl_Top.Controls.Add(this.guna2VSeparator1);
            this.pnl_Top.Controls.Add(this.cb_filter);
            this.pnl_Top.Controls.Add(this.btn_search);
            this.pnl_Top.Controls.Add(this.txt_reservationname);
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
            this.cb_filter.StartIndex = 1;
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
            // txt_reservationname
            // 
            this.txt_reservationname.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_reservationname.BorderRadius = 4;
            this.txt_reservationname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_reservationname.DefaultText = "";
            this.txt_reservationname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_reservationname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_reservationname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_reservationname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_reservationname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_reservationname.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_reservationname.ForeColor = System.Drawing.Color.Black;
            this.txt_reservationname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_reservationname.Location = new System.Drawing.Point(919, 10);
            this.txt_reservationname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_reservationname.Name = "txt_reservationname";
            this.txt_reservationname.PasswordChar = '\0';
            this.txt_reservationname.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_reservationname.PlaceholderText = "أسم الحجز ";
            this.txt_reservationname.SelectedText = "";
            this.txt_reservationname.Size = new System.Drawing.Size(225, 48);
            this.txt_reservationname.TabIndex = 11;
            this.txt_reservationname.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // UC_Requests
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dgv_servicesdepartments);
            this.Controls.Add(this.pnl_Top);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UC_Requests";
            this.Size = new System.Drawing.Size(1300, 700);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_servicesdepartments)).EndInit();
            this.pnl_Top.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgv_servicesdepartments;
        private System.Windows.Forms.Panel pnl_Top;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
        private Guna.UI2.WinForms.Guna2ComboBox cb_filter;
        private Guna.UI2.WinForms.Guna2Button btn_search;
        private Guna.UI2.WinForms.Guna2TextBox txt_reservationname;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_reservationname;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_statusname;
        private System.Windows.Forms.DataGridViewLinkColumn col_requestcode;
        private System.Windows.Forms.DataGridViewLinkColumn col_byuser;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_requestid;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_statusvalue;
    }
}
