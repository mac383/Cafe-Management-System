namespace Cafe_Management_System.Forms.Settings.UserControls
{
    partial class UC_SystemInfo
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
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btn_save = new Guna.UI2.WinForms.Guna2Button();
            this.nud_reservationtableduration = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            this.nud_reservationtableprice = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.lbl_reservationtablepricelbl = new System.Windows.Forms.Label();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.cb_curreny = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_reservationtableduration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_reservationtableprice)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guna2GroupBox1.BorderRadius = 6;
            this.guna2GroupBox1.Controls.Add(this.btn_save);
            this.guna2GroupBox1.Controls.Add(this.nud_reservationtableduration);
            this.guna2GroupBox1.Controls.Add(this.label3);
            this.guna2GroupBox1.Controls.Add(this.guna2Separator2);
            this.guna2GroupBox1.Controls.Add(this.nud_reservationtableprice);
            this.guna2GroupBox1.Controls.Add(this.lbl_reservationtablepricelbl);
            this.guna2GroupBox1.Controls.Add(this.guna2Separator1);
            this.guna2GroupBox1.Controls.Add(this.cb_curreny);
            this.guna2GroupBox1.Controls.Add(this.label1);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(248)))), ((int)(((byte)(250)))));
            this.guna2GroupBox1.CustomBorderThickness = new System.Windows.Forms.Padding(0, 80, 0, 0);
            this.guna2GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.Location = new System.Drawing.Point(0, 0);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(854, 312);
            this.guna2GroupBox1.TabIndex = 0;
            this.guna2GroupBox1.Text = "معلومات النظام الاساسية";
            this.guna2GroupBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.guna2GroupBox1.TextOffset = new System.Drawing.Point(0, 20);
            // 
            // btn_save
            // 
            this.btn_save.BorderColor = System.Drawing.Color.Gray;
            this.btn_save.BorderRadius = 5;
            this.btn_save.BorderThickness = 1;
            this.btn_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_save.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_save.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_save.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_save.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_save.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(108)))), ((int)(((byte)(190)))));
            this.btn_save.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.ForeColor = System.Drawing.Color.White;
            this.btn_save.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(108)))), ((int)(((byte)(190)))));
            this.btn_save.HoverState.ForeColor = System.Drawing.Color.White;
            this.btn_save.Location = new System.Drawing.Point(40, 15);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(164, 46);
            this.btn_save.TabIndex = 25;
            this.btn_save.Text = "حفظ التغييرات";
            this.btn_save.Visible = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // nud_reservationtableduration
            // 
            this.nud_reservationtableduration.BackColor = System.Drawing.Color.Transparent;
            this.nud_reservationtableduration.BorderRadius = 6;
            this.nud_reservationtableduration.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nud_reservationtableduration.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nud_reservationtableduration.Location = new System.Drawing.Point(40, 253);
            this.nud_reservationtableduration.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nud_reservationtableduration.Maximum = new decimal(new int[] {
            36,
            0,
            0,
            0});
            this.nud_reservationtableduration.Name = "nud_reservationtableduration";
            this.nud_reservationtableduration.Size = new System.Drawing.Size(320, 36);
            this.nud_reservationtableduration.TabIndex = 23;
            this.nud_reservationtableduration.UpDownButtonFillColor = System.Drawing.Color.White;
            this.nud_reservationtableduration.ValueChanged += new System.EventHandler(this.nud_reservationtableduration_ValueChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label3.Location = new System.Drawing.Point(476, 260);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(315, 25);
            this.label3.TabIndex = 22;
            this.label3.Text = "مدة حجز الطاولة / ساعة";
            // 
            // guna2Separator2
            // 
            this.guna2Separator2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator2.Location = new System.Drawing.Point(13, 227);
            this.guna2Separator2.Name = "guna2Separator2";
            this.guna2Separator2.Size = new System.Drawing.Size(829, 10);
            this.guna2Separator2.TabIndex = 21;
            // 
            // nud_reservationtableprice
            // 
            this.nud_reservationtableprice.BackColor = System.Drawing.Color.Transparent;
            this.nud_reservationtableprice.BorderRadius = 6;
            this.nud_reservationtableprice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nud_reservationtableprice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.nud_reservationtableprice.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.nud_reservationtableprice.Location = new System.Drawing.Point(40, 175);
            this.nud_reservationtableprice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nud_reservationtableprice.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nud_reservationtableprice.Name = "nud_reservationtableprice";
            this.nud_reservationtableprice.Size = new System.Drawing.Size(320, 36);
            this.nud_reservationtableprice.TabIndex = 20;
            this.nud_reservationtableprice.UpDownButtonFillColor = System.Drawing.Color.White;
            this.nud_reservationtableprice.ValueChanged += new System.EventHandler(this.nud_reservationtableprice_ValueChanged);
            // 
            // lbl_reservationtablepricelbl
            // 
            this.lbl_reservationtablepricelbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_reservationtablepricelbl.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_reservationtablepricelbl.Location = new System.Drawing.Point(476, 181);
            this.lbl_reservationtablepricelbl.Name = "lbl_reservationtablepricelbl";
            this.lbl_reservationtablepricelbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_reservationtablepricelbl.Size = new System.Drawing.Size(315, 25);
            this.lbl_reservationtablepricelbl.TabIndex = 19;
            this.lbl_reservationtablepricelbl.Text = "سعر حجز الطاولة";
            this.lbl_reservationtablepricelbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Separator1.Location = new System.Drawing.Point(13, 149);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(829, 10);
            this.guna2Separator1.TabIndex = 18;
            // 
            // cb_curreny
            // 
            this.cb_curreny.BackColor = System.Drawing.Color.Transparent;
            this.cb_curreny.BorderRadius = 6;
            this.cb_curreny.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_curreny.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_curreny.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_curreny.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_curreny.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cb_curreny.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cb_curreny.ItemHeight = 30;
            this.cb_curreny.Items.AddRange(new object[] {
            "الدينار العراقي",
            "الدولار الامريكي"});
            this.cb_curreny.Location = new System.Drawing.Point(40, 97);
            this.cb_curreny.Name = "cb_curreny";
            this.cb_curreny.Size = new System.Drawing.Size(320, 36);
            this.cb_curreny.StartIndex = 0;
            this.cb_curreny.TabIndex = 1;
            this.cb_curreny.SelectedIndexChanged += new System.EventHandler(this.cb_curreny_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label1.Location = new System.Drawing.Point(731, 102);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(60, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "العملة";
            // 
            // UC_SystemInfo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.guna2GroupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(854, 312);
            this.Name = "UC_SystemInfo";
            this.Size = new System.Drawing.Size(854, 312);
            this.Load += new System.EventHandler(this.UC_SystemInfo_Load);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_reservationtableduration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_reservationtableprice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2ComboBox cb_curreny;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private Guna.UI2.WinForms.Guna2NumericUpDown nud_reservationtableduration;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator2;
        private Guna.UI2.WinForms.Guna2NumericUpDown nud_reservationtableprice;
        private System.Windows.Forms.Label lbl_reservationtablepricelbl;
        private Guna.UI2.WinForms.Guna2Button btn_save;
    }
}
