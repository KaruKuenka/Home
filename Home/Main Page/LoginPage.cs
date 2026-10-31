using Home.Dashboards.Admin;
using Home.Dashboards.Home_Owner;
using Home.Dashboards.Super_Admin;
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

namespace Home.Main_Page
{
    public partial class LoginPage : Form
    {
        private readonly LoginShow loginPage = new LoginShow();
        private readonly WelcomeShow rolePage = new WelcomeShow();
        private LoginResult pending;

        public LoginPage()
        {
            InitializeComponent();

            loginPage.LoginCompleted += OnLoginCompleted;
            rolePage.RoleChosen += OnRoleChosen;
            rolePage.BackClicked += (s, e) => { Session.Clear(); pending = null; loginPage.Reset(); ShowPage(loginPage); };

            ShowPage(loginPage);
        }
        private void ShowPage(UserControl page)
        {
            ShowContentpnl.Controls.Clear();
            page.Dock = DockStyle.Fill;
            ShowContentpnl.Controls.Add(page);
        }
        private void OnLoginCompleted(object sender, LoginResult r)
        {
            if (r.IsSuperAdmin)
            {
                Session.Start(r, "SuperAdmin");
                OpenDashboard(new SuperAdminDB2());
            }
            else if (r.IsOfficer)
            {
                pending = r;
                rolePage.Setup(r);
                ShowPage(rolePage);              // let them choose
            }
            else
            {
                Session.Start(r, "HomeOwner");
                OpenDashboard(new HODB2());
            }
        }
        private void OnRoleChosen(object sender, string role)
        {
            Session.Start(pending, role);
            OpenDashboard(role == "Admin" ? (Form)new AdminDB2() : new HODB2());
        }
        private void OpenDashboard(Form dashboard)
        {
            dashboard.FormClosed += (s, e) =>
            {
                Session.Clear();
                pending = null;
                loginPage.Reset();
                ShowPage(loginPage);
                this.Show();                     // back to the login screen
            };
            this.Hide();
            dashboard.Show();
        }
    }
}
