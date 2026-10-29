using Home.Dashboards.Admin;
using Home.Dashboards.Home_Owner;
using Home.Dashboards.Super_Admin;
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
        private WelcomeShow welcomeShow = new WelcomeShow();
        private LoginShow loginshow = new LoginShow();
        private SuperAdminDB2 SA2 = new SuperAdminDB2();
        private HODB2 newowner = new HODB2();

        private AdminDB2 adminDB2 = new AdminDB2();

        public LoginPage()
        {
            InitializeComponent();
            this.MinimumSize = new Size(800, 450);








            SA2.Show();
            newowner.Show();

            adminDB2.Show();

            welcomeShow.Dock = DockStyle.Fill;
            loginshow.Dock = DockStyle.Fill;

            ShowContentpnl.Controls.Add(welcomeShow);
            ShowContentpnl.Controls.Add(loginshow);

            welcomeShow.Visible = true;
            loginshow.Visible = false;

            welcomeShow.LoginClicked += (s, e) =>
            {
                welcomeShow.Visible = false;
                loginshow.Visible = true;
            };
            welcomeShow.ExitClicked += (s, e) =>
            {
                Application.Exit();
            };
            loginshow.LoginMainClicked += (s, e) =>
            {
                MessageBox.Show("Login successful! Proceeding to the main application.");
            };
            loginshow.BackClicked += (s, e) =>
            {
                loginshow.Visible = false;
                welcomeShow.Visible = true;
            };

        }
    }
}
