using Home.Dashboards.Home_Owner;
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
        private WelcomeShow welcomeShow;
        private LoginShow loginshow;
        private HODashBoard homeowner;

        public LoginPage()
        {
            InitializeComponent();
            this.MinimumSize = new Size(800, 450);


            welcomeShow = new WelcomeShow();
            loginshow = new LoginShow();
            homeowner = new HODashBoard();

            homeowner.Show();

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
