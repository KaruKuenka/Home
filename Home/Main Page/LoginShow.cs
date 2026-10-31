using Home.Data;
using Home.Main_Page.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Home.Main_Page
{
    public partial class LoginShow : UserControl
    {
        public event EventHandler<LoginResult> LoginCompleted;

        public LoginShow()
        {
            InitializeComponent();
            TxtPassword.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter) { e.SuppressKeyPress = true; LoginMainBtn.PerformClick(); }
            };
        }

        public void Reset()
        {
            TxtUsername.Clear();
            TxtPassword.Clear();
            ErrorLbl.Visible = false;
            TxtUsername.Focus();
        }

        private void LoginMainBtn_Click(object sender, EventArgs e)
        {
            string user = TxtUsername.Text.Trim();
            string pass = TxtPassword.Text;

            if (user == "" || pass == "")
            {
                ShowError("Enter your username and password.");
                return;
            }

            try
            {
                LoginResult result = AuthService.Authenticate(user, pass);
                if (result == null)
                {
                    ShowError("Wrong username or password.");
                    TxtPassword.Clear();
                    return;
                }
                ErrorLbl.Visible = false;
                LoginCompleted?.Invoke(this, result);
            }
            catch (SqlException)
            {
                ShowError("Cannot reach the server. Check your connection.");
            }
        }

        private void ShowError(string message)
        {
            ErrorLbl.Text = message;
            ErrorLbl.Visible = true;
        }




    }
}
