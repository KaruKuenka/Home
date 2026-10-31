using Guna.UI2.WinForms;
using Home.Dashboards.Admin.Buttons;
using Home.Dashboards.Super_Admin.Buttons;
using Home.Main_Page.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home.Dashboards.Super_Admin
{
    public partial class SuperAdminDB2 : Form
    {
        private ActivityButtonSA actilog = new ActivityButtonSA();
        private HomeButtonSA Homebut = new HomeButtonSA();
        private MAdminButtonSA MAdmin = new MAdminButtonSA();
        private HomeownersButtonSA HOC = new HomeownersButtonSA();

        public SuperAdminDB2()
        {
            InitializeComponent();
            this.Load += SuperAdminDB2_Load;

        }

        private void SuperAdminDB2_Load(object sender, EventArgs e)
        {
            if (Session.Role != "SuperAdmin") { Close(); return; }
            LoadPage(Homebut, "Home");
            Highlight(HomeBtn);
        }
        private void LoadPage(UserControl page, string title)
        {
            ShowCONtentPnl.Controls.Clear();
            page.Dock = DockStyle.Fill;
            ShowCONtentPnl.Controls.Add(page);
            HeaderButtonLbl.Text = title;
        }
        private void Highlight(Guna2Button active)
        {
            foreach (var b in new[] { HomeBtn, HomeOwnerCreationBtn, ManAdminBtn, ActivityBtn })
                b.Checked = (b == active);
        }

        private void ManAdminBtn_Click(object sender, EventArgs e)
        {
            LoadPage(MAdmin, "Manage Admins");
            Highlight(ManAdminBtn);
        }

        private void HomeOwnerCreationBtn_Click(object sender, EventArgs e)
        {
            LoadPage(HOC, "Create Homeowner");
            Highlight(HomeOwnerCreationBtn);
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            LoadPage(Homebut, "Home");
            Highlight(HomeBtn);
        }

        private void ActivityBtn_Click(object sender, EventArgs e)
        {
            LoadPage(actilog, "Activity Log");
            Highlight(ActivityBtn);
        }

        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
