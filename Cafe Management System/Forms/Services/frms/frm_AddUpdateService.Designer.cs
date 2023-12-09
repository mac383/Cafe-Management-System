namespace Cafe_Management_System.Forms.Services.frms
{
    partial class frm_AddUpdateService
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.pnl_container = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.lbl_selectimage = new System.Windows.Forms.LinkLabel();
            this.lbl_deleteimage = new System.Windows.Forms.LinkLabel();
            this.pic_serviceimage = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_departments = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txt_servicedescription = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_servicename = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.lbl_pagetitle = new System.Windows.Forms.Label();
            this.btn_cancel = new Guna.UI2.WinForms.Guna2Button();
            this.btn_addupdate = new Guna.UI2.WinForms.Guna2Button();
            this.pnl_container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_serviceimage)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // pnl_container
            // 
            this.pnl_container.BackColor = System.Drawing.Color.Transparent;
            this.pnl_container.Controls.Add(this.lbl_selectimage);
            this.pnl_container.Controls.Add(this.lbl_deleteimage);
            this.pnl_container.Controls.Add(this.pic_serviceimage);
            this.pnl_container.Controls.Add(this.label1);
            this.pnl_container.Controls.Add(this.cb_departments);
            this.pnl_container.Controls.Add(this.txt_servicedescription);
            this.pnl_container.Controls.Add(this.txt_servicename);
            this.pnl_container.Controls.Add(this.guna2Separator1);
            this.pnl_container.Controls.Add(this.lbl_pagetitle);
            this.pnl_container.Controls.Add(this.btn_cancel);
            this.pnl_container.Controls.Add(this.btn_addupdate);
            this.pnl_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_container.FillColor = System.Drawing.Color.White;
            this.pnl_container.Location = new System.Drawing.Point(0, 0);
            this.pnl_container.Name = "pnl_container";
            this.pnl_container.ShadowColor = System.Drawing.Color.Black;
            this.pnl_container.ShadowDepth = 150;
            this.pnl_container.ShadowShift = 10;
            this.pnl_container.Size = new System.Drawing.Size(780, 800);
            this.pnl_container.TabIndex = 0;
            // 
            // lbl_selectimage
            // 
            this.lbl_selectimage.AutoSize = true;
            this.lbl_selectimage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_selectimage.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_selectimage.Location = new System.Drawing.Point(579, 478);
            this.lbl_selectimage.Name = "lbl_selectimage";
            this.lbl_selectimage.Size = new System.Drawing.Size(128, 19);
            this.lbl_selectimage.TabIndex = 3;
            this.lbl_selectimage.TabStop = true;
            this.lbl_selectimage.Text = "أختر صورة للخدمة";
            this.lbl_selectimage.VisitedLinkColor = System.Drawing.Color.Blue;
            this.lbl_selectimage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_selectimage_LinkClicked);
            // 
            // lbl_deleteimage
            // 
            this.lbl_deleteimage.AutoSize = true;
            this.lbl_deleteimage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_deleteimage.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_deleteimage.LinkColor = System.Drawing.Color.Red;
            this.lbl_deleteimage.Location = new System.Drawing.Point(285, 659);
            this.lbl_deleteimage.Name = "lbl_deleteimage";
            this.lbl_deleteimage.Size = new System.Drawing.Size(90, 19);
            this.lbl_deleteimage.TabIndex = 4;
            this.lbl_deleteimage.TabStop = true;
            this.lbl_deleteimage.Text = "حذف الصورة";
            this.lbl_deleteimage.Visible = false;
            this.lbl_deleteimage.VisitedLinkColor = System.Drawing.Color.Red;
            this.lbl_deleteimage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_deleteimage_LinkClicked);
            // 
            // pic_serviceimage
            // 
            this.pic_serviceimage.Image = global::Cafe_Management_System.Properties.Resources.empty_image;
            this.pic_serviceimage.Location = new System.Drawing.Point(73, 478);
            this.pic_serviceimage.Name = "pic_serviceimage";
            this.pic_serviceimage.Size = new System.Drawing.Size(200, 200);
            this.pic_serviceimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_serviceimage.TabIndex = 34;
            this.pic_serviceimage.TabStop = false;
            this.pic_serviceimage.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(648, 420);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 22);
            this.label1.TabIndex = 33;
            this.label1.Text = "القسم";
            // 
            // cb_departments
            // 
            this.cb_departments.BackColor = System.Drawing.Color.Transparent;
            this.cb_departments.BorderRadius = 4;
            this.cb_departments.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cb_departments.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_departments.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_departments.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb_departments.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cb_departments.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cb_departments.ItemHeight = 30;
            this.cb_departments.Location = new System.Drawing.Point(73, 406);
            this.cb_departments.Name = "cb_departments";
            this.cb_departments.Size = new System.Drawing.Size(542, 36);
            this.cb_departments.TabIndex = 2;
            // 
            // txt_servicedescription
            // 
            this.txt_servicedescription.BorderRadius = 4;
            this.txt_servicedescription.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_servicedescription.DefaultText = "";
            this.txt_servicedescription.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_servicedescription.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_servicedescription.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_servicedescription.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_servicedescription.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_servicedescription.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_servicedescription.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_servicedescription.Location = new System.Drawing.Point(75, 260);
            this.txt_servicedescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_servicedescription.MaxLength = 100;
            this.txt_servicedescription.Multiline = true;
            this.txt_servicedescription.Name = "txt_servicedescription";
            this.txt_servicedescription.PasswordChar = '\0';
            this.txt_servicedescription.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txt_servicedescription.PlaceholderText = "ألوصف";
            this.txt_servicedescription.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_servicedescription.SelectedText = "";
            this.txt_servicedescription.Size = new System.Drawing.Size(630, 124);
            this.txt_servicedescription.TabIndex = 1;
            // 
            // txt_servicename
            // 
            this.txt_servicename.BorderRadius = 4;
            this.txt_servicename.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_servicename.DefaultText = "";
            this.txt_servicename.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_servicename.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_servicename.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_servicename.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_servicename.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_servicename.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_servicename.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_servicename.Location = new System.Drawing.Point(75, 172);
            this.txt_servicename.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_servicename.MaxLength = 25;
            this.txt_servicename.Name = "txt_servicename";
            this.txt_servicename.PasswordChar = '\0';
            this.txt_servicename.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txt_servicename.PlaceholderText = "أدخل أسم الخدمة";
            this.txt_servicename.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_servicename.SelectedText = "";
            this.txt_servicename.Size = new System.Drawing.Size(630, 64);
            this.txt_servicename.TabIndex = 0;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.FillThickness = 3;
            this.guna2Separator1.Location = new System.Drawing.Point(198, 100);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(384, 8);
            this.guna2Separator1.TabIndex = 30;
            // 
            // lbl_pagetitle
            // 
            this.lbl_pagetitle.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pagetitle.Location = new System.Drawing.Point(214, 35);
            this.lbl_pagetitle.Name = "lbl_pagetitle";
            this.lbl_pagetitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_pagetitle.Size = new System.Drawing.Size(352, 48);
            this.lbl_pagetitle.TabIndex = 29;
            this.lbl_pagetitle.Text = "إضافة خدمة جديدة";
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
            this.btn_cancel.Location = new System.Drawing.Point(449, 717);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(119, 49);
            this.btn_cancel.TabIndex = 6;
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
            this.btn_addupdate.Location = new System.Drawing.Point(588, 717);
            this.btn_addupdate.Name = "btn_addupdate";
            this.btn_addupdate.Size = new System.Drawing.Size(119, 49);
            this.btn_addupdate.TabIndex = 5;
            this.btn_addupdate.Tag = "1";
            this.btn_addupdate.Text = "إضافة";
            this.btn_addupdate.Click += new System.EventHandler(this.btn_addupdate_Click);
            // 
            // frm_AddUpdateService
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(780, 800);
            this.Controls.Add(this.pnl_container);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1300, 800);
            this.MinimumSize = new System.Drawing.Size(780, 800);
            this.Name = "frm_AddUpdateService";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_AddUpdateService_Load);
            this.pnl_container.ResumeLayout(false);
            this.pnl_container.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_serviceimage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnl_container;
        private System.Windows.Forms.LinkLabel lbl_selectimage;
        private System.Windows.Forms.LinkLabel lbl_deleteimage;
        private System.Windows.Forms.PictureBox pic_serviceimage;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cb_departments;
        private Guna.UI2.WinForms.Guna2TextBox txt_servicedescription;
        private Guna.UI2.WinForms.Guna2TextBox txt_servicename;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Label lbl_pagetitle;
        private Guna.UI2.WinForms.Guna2Button btn_cancel;
        private Guna.UI2.WinForms.Guna2Button btn_addupdate;
    }
}