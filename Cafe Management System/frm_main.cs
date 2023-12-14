using Cafe_Management_System.Forms.Home.UserControls;
using Cafe_Management_System.Forms.Requests.UserControls;
using Cafe_Management_System.Forms.Services.UserControls;
using Cafe_Management_System.Forms.Settings.frms;
using Cafe_Management_System.Forms.Tables.UserControls;
using Cafe_Management_System.Forms.Users.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe_Management_System
{
    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();
        }

        // move Form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pnlMouseDown()
        {

            this.Opacity = 0.8;

            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }

        private void pnlMouseEnter()
        {
            this.Opacity = 1;
        }

        private void pnl_head_MouseDown(object sender, MouseEventArgs e)
        {
            pnlMouseDown();
        }

        private void pnl_head_MouseEnter(object sender, EventArgs e)
        {
            pnlMouseEnter();
        }

        void _LoadSubBtns(UserControl usercontrol)
        {

            if (pnl_btnscontainer.Height != pnl_btnscontainer.MaximumSize.Height)
                pnl_btnscontainer.Height = pnl_btnscontainer.MaximumSize.Height;

            usercontrol.Dock = DockStyle.Fill;
            pnl_subbtns.Controls.Clear();
            pnl_subbtns.Controls.Add(usercontrol);

        }

        void _LoadPages(UserControl userControl)
        {

            userControl.Dock = DockStyle.Fill;
            pnl_body.Controls.Clear();
            pnl_body.Controls.Add(userControl);

        }

        private void btn_requests_Click(object sender, EventArgs e)
        {

            pnl_subbtns.Controls.Clear();
            pnl_btnscontainer.Height = pnl_btnscontainer.MinimumSize.Height;

            UC_Requests uc = new UC_Requests();
            _LoadPages(uc);

        }

        private void btn_home_Click(object sender, EventArgs e)
        {

            pnl_subbtns.Controls.Clear();
            pnl_btnscontainer.Height = pnl_btnscontainer.MinimumSize.Height;

            UC_Home uc = new UC_Home();
            _LoadPages(uc);

        }

        private void frm_main_Load(object sender, EventArgs e)
        {

            btn_home_Click(null, null);

        }

        private void btn_tables_Click(object sender, EventArgs e)
        {

            pnl_btnscontainer.Height = pnl_btnscontainer.MinimumSize.Height;

            UC_Tables uc = new UC_Tables();
            _LoadPages(uc);
        }

        private void btn_services_Click(object sender, EventArgs e)
        {
            UC_ServicesSubButtons uc = new UC_ServicesSubButtons();
            uc.SubButtonClick += _LoadPages;
            _LoadSubBtns(uc);
        }

        private void btn_users_Click(object sender, EventArgs e)
        {
            pnl_btnscontainer.Height = pnl_btnscontainer.MinimumSize.Height;
            UC_Users uc = new UC_Users();
            _LoadPages(uc);
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            frm_settings frm = new frm_settings();
            frm.ShowDialog();
        }
    }
}
