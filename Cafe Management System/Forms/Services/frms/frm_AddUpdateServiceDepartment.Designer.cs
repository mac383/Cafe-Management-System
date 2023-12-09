namespace Cafe_Management_System.Forms.Services.frms
{
    partial class frm_AddUpdateServiceDepartment
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
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.lbl_deleteimage = new System.Windows.Forms.LinkLabel();
            this.pic_departmentimage = new System.Windows.Forms.PictureBox();
            this.lbl_selectimage = new System.Windows.Forms.LinkLabel();
            this.txt_departmentname = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.lbl_pagetitle = new System.Windows.Forms.Label();
            this.btn_cancel = new Guna.UI2.WinForms.Guna2Button();
            this.btn_addupdate = new Guna.UI2.WinForms.Guna2Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.guna2ShadowPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_departmentimage)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Controls.Add(this.lbl_deleteimage);
            this.guna2ShadowPanel1.Controls.Add(this.pic_departmentimage);
            this.guna2ShadowPanel1.Controls.Add(this.lbl_selectimage);
            this.guna2ShadowPanel1.Controls.Add(this.txt_departmentname);
            this.guna2ShadowPanel1.Controls.Add(this.guna2Separator1);
            this.guna2ShadowPanel1.Controls.Add(this.lbl_pagetitle);
            this.guna2ShadowPanel1.Controls.Add(this.btn_cancel);
            this.guna2ShadowPanel1.Controls.Add(this.btn_addupdate);
            this.guna2ShadowPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(413, 467);
            this.guna2ShadowPanel1.TabIndex = 1;
            // 
            // lbl_deleteimage
            // 
            this.lbl_deleteimage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_deleteimage.AutoSize = true;
            this.lbl_deleteimage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_deleteimage.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_deleteimage.LinkColor = System.Drawing.Color.Red;
            this.lbl_deleteimage.Location = new System.Drawing.Point(200, 316);
            this.lbl_deleteimage.Name = "lbl_deleteimage";
            this.lbl_deleteimage.Size = new System.Drawing.Size(90, 19);
            this.lbl_deleteimage.TabIndex = 16;
            this.lbl_deleteimage.TabStop = true;
            this.lbl_deleteimage.Text = "حذف الصورة";
            this.lbl_deleteimage.Visible = false;
            this.lbl_deleteimage.VisitedLinkColor = System.Drawing.Color.Red;
            this.lbl_deleteimage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_deleteimage_LinkClicked);
            // 
            // pic_departmentimage
            // 
            this.pic_departmentimage.Image = global::Cafe_Management_System.Properties.Resources.empty_image;
            this.pic_departmentimage.Location = new System.Drawing.Point(75, 216);
            this.pic_departmentimage.Name = "pic_departmentimage";
            this.pic_departmentimage.Size = new System.Drawing.Size(119, 119);
            this.pic_departmentimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_departmentimage.TabIndex = 15;
            this.pic_departmentimage.TabStop = false;
            this.pic_departmentimage.Visible = false;
            // 
            // lbl_selectimage
            // 
            this.lbl_selectimage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_selectimage.AutoSize = true;
            this.lbl_selectimage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_selectimage.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_selectimage.Location = new System.Drawing.Point(237, 216);
            this.lbl_selectimage.Name = "lbl_selectimage";
            this.lbl_selectimage.Size = new System.Drawing.Size(127, 19);
            this.lbl_selectimage.TabIndex = 14;
            this.lbl_selectimage.TabStop = true;
            this.lbl_selectimage.Text = "أختر صورة للقسم";
            this.lbl_selectimage.VisitedLinkColor = System.Drawing.Color.Blue;
            this.lbl_selectimage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_selectimage_LinkClicked);
            // 
            // txt_departmentname
            // 
            this.txt_departmentname.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_departmentname.BorderRadius = 4;
            this.txt_departmentname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_departmentname.DefaultText = "";
            this.txt_departmentname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_departmentname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_departmentname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_departmentname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_departmentname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_departmentname.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_departmentname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_departmentname.Location = new System.Drawing.Point(45, 168);
            this.txt_departmentname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_departmentname.MaxLength = 25;
            this.txt_departmentname.Name = "txt_departmentname";
            this.txt_departmentname.PasswordChar = '\0';
            this.txt_departmentname.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txt_departmentname.PlaceholderText = "إدخل أسم القسم";
            this.txt_departmentname.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_departmentname.SelectedText = "";
            this.txt_departmentname.Size = new System.Drawing.Size(323, 36);
            this.txt_departmentname.TabIndex = 0;
            // 
            // guna2Separator1
            // 
            this.guna2Separator1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2Separator1.FillThickness = 3;
            this.guna2Separator1.Location = new System.Drawing.Point(68, 104);
            this.guna2Separator1.Name = "guna2Separator1";
            this.guna2Separator1.Size = new System.Drawing.Size(276, 8);
            this.guna2Separator1.TabIndex = 13;
            // 
            // lbl_pagetitle
            // 
            this.lbl_pagetitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_pagetitle.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pagetitle.Location = new System.Drawing.Point(30, 39);
            this.lbl_pagetitle.Name = "lbl_pagetitle";
            this.lbl_pagetitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_pagetitle.Size = new System.Drawing.Size(352, 48);
            this.lbl_pagetitle.TabIndex = 12;
            this.lbl_pagetitle.Text = "إضافة قسم جديد";
            this.lbl_pagetitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.btn_cancel.Location = new System.Drawing.Point(75, 353);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(119, 49);
            this.btn_cancel.TabIndex = 2;
            this.btn_cancel.Tag = "1";
            this.btn_cancel.Text = "إلغاء";
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click_1);
            // 
            // btn_addupdate
            // 
            this.btn_addupdate.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.btn_addupdate.Location = new System.Drawing.Point(214, 353);
            this.btn_addupdate.Name = "btn_addupdate";
            this.btn_addupdate.Size = new System.Drawing.Size(119, 49);
            this.btn_addupdate.TabIndex = 1;
            this.btn_addupdate.Tag = "1";
            this.btn_addupdate.Text = "إضافة";
            this.btn_addupdate.Click += new System.EventHandler(this.btn_addupdate_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frm_AddUpdateServiceDepartment
            // 
            this.AcceptButton = this.btn_addupdate;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btn_cancel;
            this.ClientSize = new System.Drawing.Size(413, 467);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_AddUpdateServiceDepartment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اقسام الخدمات";
            this.Load += new System.EventHandler(this.frm_AddUpdateServiceDepartment_Load);
            this.guna2ShadowPanel1.ResumeLayout(false);
            this.guna2ShadowPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_departmentimage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2TextBox txt_departmentname;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
        private System.Windows.Forms.Label lbl_pagetitle;
        private Guna.UI2.WinForms.Guna2Button btn_cancel;
        private Guna.UI2.WinForms.Guna2Button btn_addupdate;
        private System.Windows.Forms.PictureBox pic_departmentimage;
        private System.Windows.Forms.LinkLabel lbl_selectimage;
        private System.Windows.Forms.LinkLabel lbl_deleteimage;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}