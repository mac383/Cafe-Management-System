namespace Cafe_Management_System.Forms.Services.frms
{
    partial class frm_AddUpdateOptions
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
            this.pnl_container = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.lbl_optionpricelbl = new System.Windows.Forms.Label();
            this.nud_optionprice = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_services = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txt_optionname = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.lbl_pagetitle = new System.Windows.Forms.Label();
            this.btn_cancel = new Guna.UI2.WinForms.Guna2Button();
            this.btn_addupdate = new Guna.UI2.WinForms.Guna2Button();
            this.pnl_container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_optionprice)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_container
            // 
            this.pnl_container.BackColor = System.Drawing.Color.Transparent;
            this.pnl_container.Controls.Add(this.lbl_optionpricelbl);
            this.pnl_container.Controls.Add(this.nud_optionprice);
            this.pnl_container.Controls.Add(this.label1);
            this.pnl_container.Controls.Add(this.cb_services);
            this.pnl_container.Controls.Add(this.txt_optionname);
            this.pnl_container.Controls.Add(this.guna2Separator1);
            this.pnl_container.Controls.Add(this.lbl_pagetitle);
            this.pnl_container.Controls.Add(this.btn_cancel);
            this.pnl_container.Controls.Add(this.btn_addupdate);
            this.pnl_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_container.FillColor = System.Drawing.Color.White;
            this.pnl_container.Location = new System.Drawing.Point(0, 0);
            this.pnl_container.Name = "pnl_container";
            this.pnl_container.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(108)))), ((int)(((byte)(190)))));
            this.pnl_container.ShadowDepth = 250;
            this.pnl_container.ShadowShift = 10;
            this.pnl_container.Size = new System.Drawing.Size(574, 572);
            this.pnl_container.TabIndex = 1;
            // 
            // lbl_optionpricelbl
            // 
            this.lbl_optionpricelbl.Location = new System.Drawing.Point(324, 266);
            this.lbl_optionpricelbl.Name = "lbl_optionpricelbl";
            this.lbl_optionpricelbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_optionpricelbl.Size = new System.Drawing.Size(202, 20);
            this.lbl_optionpricelbl.TabIndex = 36;
            this.lbl_optionpricelbl.Text = "سعر الخيار";
            // 
            // nud_optionprice
            // 
            this.nud_optionprice.BackColor = System.Drawing.Color.Transparent;
            this.nud_optionprice.BorderRadius = 4;
            this.nud_optionprice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nud_optionprice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nud_optionprice.Increment = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.nud_optionprice.Location = new System.Drawing.Point(48, 289);
            this.nud_optionprice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nud_optionprice.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.nud_optionprice.Name = "nud_optionprice";
            this.nud_optionprice.Size = new System.Drawing.Size(478, 36);
            this.nud_optionprice.TabIndex = 1;
            this.nud_optionprice.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(108)))), ((int)(((byte)(190)))));
            this.nud_optionprice.UpDownButtonForeColor = System.Drawing.Color.White;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(324, 336);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(202, 20);
            this.label1.TabIndex = 33;
            this.label1.Text = "الخدمة";
            // 
            // cb_services
            // 
            this.cb_services.BackColor = System.Drawing.Color.Transparent;
            this.cb_services.BorderRadius = 4;
            this.cb_services.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_services.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_services.Enabled = false;
            this.cb_services.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_services.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_services.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cb_services.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cb_services.ItemHeight = 30;
            this.cb_services.Location = new System.Drawing.Point(48, 359);
            this.cb_services.Name = "cb_services";
            this.cb_services.Size = new System.Drawing.Size(478, 36);
            this.cb_services.TabIndex = 2;
            // 
            // txt_optionname
            // 
            this.txt_optionname.BorderRadius = 4;
            this.txt_optionname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_optionname.DefaultText = "";
            this.txt_optionname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_optionname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_optionname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_optionname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_optionname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_optionname.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_optionname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_optionname.Location = new System.Drawing.Point(48, 191);
            this.txt_optionname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_optionname.MaxLength = 25;
            this.txt_optionname.Name = "txt_optionname";
            this.txt_optionname.PasswordChar = '\0';
            this.txt_optionname.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txt_optionname.PlaceholderText = "أدخل أسم الخيار";
            this.txt_optionname.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_optionname.SelectedText = "";
            this.txt_optionname.Size = new System.Drawing.Size(478, 64);
            this.txt_optionname.TabIndex = 0;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.FillThickness = 3;
            this.guna2Separator1.Location = new System.Drawing.Point(118, 100);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(384, 8);
            this.guna2Separator1.TabIndex = 30;
            // 
            // lbl_pagetitle
            // 
            this.lbl_pagetitle.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pagetitle.Location = new System.Drawing.Point(134, 35);
            this.lbl_pagetitle.Name = "lbl_pagetitle";
            this.lbl_pagetitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_pagetitle.Size = new System.Drawing.Size(352, 48);
            this.lbl_pagetitle.TabIndex = 29;
            this.lbl_pagetitle.Text = "إضافة خيار جديد";
            this.lbl_pagetitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Animated = true;
            this.btn_cancel.AnimatedGIF = true;
            this.btn_cancel.BorderRadius = 4;
            this.btn_cancel.BorderThickness = 1;
            this.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_cancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_cancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_cancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_cancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_cancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_cancel.Location = new System.Drawing.Point(269, 493);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(119, 49);
            this.btn_cancel.TabIndex = 4;
            this.btn_cancel.Tag = "1";
            this.btn_cancel.Text = "إلغاء";
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_addupdate
            // 
            this.btn_addupdate.Animated = true;
            this.btn_addupdate.AnimatedGIF = true;
            this.btn_addupdate.BorderRadius = 4;
            this.btn_addupdate.BorderThickness = 1;
            this.btn_addupdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_addupdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_addupdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_addupdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_addupdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_addupdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btn_addupdate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_addupdate.ForeColor = System.Drawing.Color.White;
            this.btn_addupdate.Location = new System.Drawing.Point(407, 493);
            this.btn_addupdate.Name = "btn_addupdate";
            this.btn_addupdate.Size = new System.Drawing.Size(119, 49);
            this.btn_addupdate.TabIndex = 3;
            this.btn_addupdate.Tag = "1";
            this.btn_addupdate.Text = "إضافة";
            this.btn_addupdate.Click += new System.EventHandler(this.btn_addupdate_Click);
            // 
            // frm_AddUpdateOptions
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(574, 572);
            this.Controls.Add(this.pnl_container);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_AddUpdateOptions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_AddUpdateOptions";
            this.Load += new System.EventHandler(this.frm_AddUpdateOptions_Load);
            this.pnl_container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nud_optionprice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel pnl_container;
        private System.Windows.Forms.Label lbl_optionpricelbl;
        private Guna.UI2.WinForms.Guna2NumericUpDown nud_optionprice;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cb_services;
        private Guna.UI2.WinForms.Guna2TextBox txt_optionname;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Label lbl_pagetitle;
        private Guna.UI2.WinForms.Guna2Button btn_cancel;
        private Guna.UI2.WinForms.Guna2Button btn_addupdate;
    }
}