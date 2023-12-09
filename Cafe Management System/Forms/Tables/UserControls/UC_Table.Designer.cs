namespace Cafe_Management_System.Forms.Tables.UserControls
{
    partial class UC_Table
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Table));
            this.lbl_tablename = new System.Windows.Forms.Label();
            this.lbl_tablestatus = new System.Windows.Forms.Label();
            this.lbl_reservationname = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_reesrvationnamelbl = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.txt_reservationname = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_reservationtable = new Guna.UI2.WinForms.Guna2Button();
            this.btn_updatetable = new Guna.UI2.WinForms.Guna2Button();
            this.btn_deletetable = new Guna.UI2.WinForms.Guna2Button();
            this.lbl_reservationtime = new System.Windows.Forms.Label();
            this.timer_reservationtimeremender = new System.Windows.Forms.Timer(this.components);
            this.lbl_reservationstatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_tablename
            // 
            resources.ApplyResources(this.lbl_tablename, "lbl_tablename");
            this.lbl_tablename.Name = "lbl_tablename";
            // 
            // lbl_tablestatus
            // 
            resources.ApplyResources(this.lbl_tablestatus, "lbl_tablestatus");
            this.lbl_tablestatus.Name = "lbl_tablestatus";
            // 
            // lbl_reservationname
            // 
            resources.ApplyResources(this.lbl_reservationname, "lbl_reservationname");
            this.lbl_reservationname.Name = "lbl_reservationname";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // lbl_reesrvationnamelbl
            // 
            resources.ApplyResources(this.lbl_reesrvationnamelbl, "lbl_reesrvationnamelbl");
            this.lbl_reesrvationnamelbl.Name = "lbl_reesrvationnamelbl";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 15;
            this.guna2Elipse1.TargetControl = this;
            // 
            // txt_reservationname
            // 
            resources.ApplyResources(this.txt_reservationname, "txt_reservationname");
            this.txt_reservationname.BorderRadius = 4;
            this.txt_reservationname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_reservationname.DefaultText = "";
            this.txt_reservationname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_reservationname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_reservationname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_reservationname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_reservationname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_reservationname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_reservationname.IconLeft = global::Cafe_Management_System.Properties.Resources.Close_64;
            this.txt_reservationname.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.txt_reservationname.MaxLength = 25;
            this.txt_reservationname.Name = "txt_reservationname";
            this.txt_reservationname.PasswordChar = '\0';
            this.txt_reservationname.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.txt_reservationname.PlaceholderText = "الحجز باسم";
            this.txt_reservationname.SelectedText = "";
            this.txt_reservationname.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txt_reservationname.IconLeftClick += new System.EventHandler(this.txt_reservationname_IconLeftClick);
            this.txt_reservationname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_reservationname_KeyPress);
            // 
            // btn_reservationtable
            // 
            resources.ApplyResources(this.btn_reservationtable, "btn_reservationtable");
            this.btn_reservationtable.BackColor = System.Drawing.Color.Transparent;
            this.btn_reservationtable.BorderRadius = 4;
            this.btn_reservationtable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_reservationtable.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_reservationtable.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_reservationtable.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_reservationtable.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_reservationtable.FillColor = System.Drawing.Color.Transparent;
            this.btn_reservationtable.ForeColor = System.Drawing.Color.White;
            this.btn_reservationtable.Name = "btn_reservationtable";
            this.btn_reservationtable.Tag = "1";
            this.btn_reservationtable.Click += new System.EventHandler(this.btn_reservationtable_Click);
            // 
            // btn_updatetable
            // 
            resources.ApplyResources(this.btn_updatetable, "btn_updatetable");
            this.btn_updatetable.BackColor = System.Drawing.Color.Transparent;
            this.btn_updatetable.BorderRadius = 4;
            this.btn_updatetable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_updatetable.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_updatetable.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_updatetable.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_updatetable.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_updatetable.FillColor = System.Drawing.Color.Transparent;
            this.btn_updatetable.ForeColor = System.Drawing.Color.White;
            this.btn_updatetable.Name = "btn_updatetable";
            this.btn_updatetable.Tag = "1";
            this.btn_updatetable.Click += new System.EventHandler(this.btn_updatetable_Click);
            // 
            // btn_deletetable
            // 
            resources.ApplyResources(this.btn_deletetable, "btn_deletetable");
            this.btn_deletetable.BackColor = System.Drawing.Color.Transparent;
            this.btn_deletetable.BorderRadius = 4;
            this.btn_deletetable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_deletetable.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_deletetable.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_deletetable.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_deletetable.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_deletetable.FillColor = System.Drawing.Color.Transparent;
            this.btn_deletetable.ForeColor = System.Drawing.Color.White;
            this.btn_deletetable.Name = "btn_deletetable";
            this.btn_deletetable.Tag = "1";
            this.btn_deletetable.Click += new System.EventHandler(this.btn_deletetable_Click);
            // 
            // lbl_reservationtime
            // 
            resources.ApplyResources(this.lbl_reservationtime, "lbl_reservationtime");
            this.lbl_reservationtime.Name = "lbl_reservationtime";
            // 
            // timer_reservationtimeremender
            // 
            this.timer_reservationtimeremender.Interval = 1000;
            this.timer_reservationtimeremender.Tick += new System.EventHandler(this.timer_reservationtimeremender_Tick);
            // 
            // lbl_reservationstatus
            // 
            resources.ApplyResources(this.lbl_reservationstatus, "lbl_reservationstatus");
            this.lbl_reservationstatus.BackColor = System.Drawing.Color.White;
            this.lbl_reservationstatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_reservationstatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(108)))), ((int)(((byte)(190)))));
            this.lbl_reservationstatus.Name = "lbl_reservationstatus";
            // 
            // UC_Table
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(108)))), ((int)(((byte)(190)))));
            this.Controls.Add(this.lbl_reservationstatus);
            this.Controls.Add(this.btn_deletetable);
            this.Controls.Add(this.btn_updatetable);
            this.Controls.Add(this.btn_reservationtable);
            this.Controls.Add(this.txt_reservationname);
            this.Controls.Add(this.lbl_reesrvationnamelbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_reservationtime);
            this.Controls.Add(this.lbl_reservationname);
            this.Controls.Add(this.lbl_tablestatus);
            this.Controls.Add(this.lbl_tablename);
            resources.ApplyResources(this, "$this");
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "UC_Table";
            this.Load += new System.EventHandler(this.UC_Table_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_tablename;
        private System.Windows.Forms.Label lbl_tablestatus;
        private System.Windows.Forms.Label lbl_reservationname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_reesrvationnamelbl;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2TextBox txt_reservationname;
        private Guna.UI2.WinForms.Guna2Button btn_reservationtable;
        private Guna.UI2.WinForms.Guna2Button btn_deletetable;
        private Guna.UI2.WinForms.Guna2Button btn_updatetable;
        private System.Windows.Forms.Label lbl_reservationtime;
        private System.Windows.Forms.Timer timer_reservationtimeremender;
        private System.Windows.Forms.Label lbl_reservationstatus;
    }
}
