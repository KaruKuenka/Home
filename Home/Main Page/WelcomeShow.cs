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
    public partial class WelcomeShow : UserControl
    {
        public event EventHandler<string> RoleChosen;
        public event EventHandler BackClicked;
        public WelcomeShow()
        {
            InitializeComponent();
        }

        public void Setup(LoginResult r)
        {
            User2Rolelbl.Text = "Welcome, " + r.FullName;
            HomeOwnerBtn.Text = "Home Owner\nPay fees, send reports, view history";
            AdminBtn.Text = "Admin - " + r.HoaPosition + "\nManage reports, payments and announcements";
        }


        private void HomeOwnerBtn_Click(object sender, EventArgs e) => RoleChosen?.Invoke(this, "HomeOwner");
        private void AdminBtn_Click(object sender, EventArgs e) => RoleChosen?.Invoke(this, "Admin");
        private void BackLoginBtn_Click(object sender, EventArgs e) => BackClicked?.Invoke(this, EventArgs.Empty);
    }
}

