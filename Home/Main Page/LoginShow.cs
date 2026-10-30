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
    public partial class LoginShow : UserControl
    {
        private LoginPage LoginPage = new LoginPage();
        private WelcomeShow welcomeShow = new WelcomeShow();

        public event EventHandler LoginMainClicked;

        public LoginShow()
        {
            InitializeComponent();
            if (TxtPassword.Text == "SuperAdmin" || TxtUsername.Text == "SuperAdmin")
            {
                LoginMainClicked?.Invoke(this, EventArgs.Empty);
                LoginPage.Close();
            }
        }

        private void LoginMainBtn_Click(object sender, EventArgs e)
        {
            LoginMainClicked?.Invoke(this, EventArgs.Empty);
        }


    }
}
