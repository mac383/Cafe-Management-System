namespace Cafe_Management_System.Forms.Tables.UserControls
{
    partial class UC_Tables
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
            this.flp_body = new System.Windows.Forms.FlowLayoutPanel();
            this.pnl_Top = new System.Windows.Forms.Panel();
            this.guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.btn_addtable = new Guna.UI2.WinForms.Guna2Button();
            this.cb_filter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.txt_searchtable = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnl_Top.SuspendLayout();
            this.SuspendLayout();
            // 
            // flp_body
            // 
            this.flp_body.AutoScroll = true;
            this.flp_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flp_body.Location = new System.Drawing.Point(0, 68);
            this.flp_body.Name = "flp_body";
            this.flp_body.Size = new System.Drawing.Size(1300, 632);
            this.flp_body.TabIndex = 3;
            this.flp_body.SizeChanged += new System.EventHandler(this.flp_body_SizeChanged);
            // 
            // pnl_Top
            // 
            this.pnl_Top.Controls.Add(this.guna2VSeparator1);
            this.pnl_Top.Controls.Add(this.btn_addtable);
            this.pnl_Top.Controls.Add(this.cb_filter);
            this.pnl_Top.Controls.Add(this.guna2Button1);
            this.pnl_Top.Controls.Add(this.txt_searchtable);
            this.pnl_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Top.Location = new System.Drawing.Point(0, 0);
            this.pnl_Top.Name = "pnl_Top";
            this.pnl_Top.Size = new System.Drawing.Size(1300, 68);
            this.pnl_Top.TabIndex = 4;
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
            // btn_addtable
            // 
            this.btn_addtable.BorderRadius = 4;
            this.btn_addtable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_addtable.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_addtable.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_addtable.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_addtable.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_addtable.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(108)))), ((int)(((byte)(190)))));
            this.btn_addtable.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_addtable.ForeColor = System.Drawing.Color.White;
            this.btn_addtable.Location = new System.Drawing.Point(19, 10);
            this.btn_addtable.Name = "btn_addtable";
            this.btn_addtable.Size = new System.Drawing.Size(130, 48);
            this.btn_addtable.TabIndex = 10;
            this.btn_addtable.Tag = "1";
            this.btn_addtable.Text = "إضافة طاولة";
            this.btn_addtable.Click += new System.EventHandler(this.btn_addtable_Click);
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
            "الطاولات المتاحة",
            "الطاولات غير المتاحة"});
            this.cb_filter.Location = new System.Drawing.Point(666, 16);
            this.cb_filter.Name = "cb_filter";
            this.cb_filter.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cb_filter.Size = new System.Drawing.Size(225, 36);
            this.cb_filter.StartIndex = 0;
            this.cb_filter.TabIndex = 13;
            this.cb_filter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.cb_filter.SelectedIndexChanged += new System.EventHandler(this.cb_filter_SelectedIndexChanged);
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
            this.txt_searchtable.PlaceholderText = "اسم الطاولة";
            this.txt_searchtable.SelectedText = "";
            this.txt_searchtable.Size = new System.Drawing.Size(225, 48);
            this.txt_searchtable.TabIndex = 11;
            this.txt_searchtable.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_searchtable.TextChanged += new System.EventHandler(this.txt_searchtable_TextChanged);
            // 
            // UC_Tables
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.flp_body);
            this.Controls.Add(this.pnl_Top);
            this.Name = "UC_Tables";
            this.Size = new System.Drawing.Size(1300, 700);
            this.Load += new System.EventHandler(this.UC_Tables_Load);
            this.pnl_Top.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flp_body;
        private System.Windows.Forms.Panel pnl_Top;
        private Guna.UI2.WinForms.Guna2Button btn_addtable;
        private Guna.UI2.WinForms.Guna2ComboBox cb_filter;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2TextBox txt_searchtable;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
    }
}
