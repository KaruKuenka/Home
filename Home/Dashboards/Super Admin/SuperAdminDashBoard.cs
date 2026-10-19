using Home.Dashboards.Super_Admin.Buttons;
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
    public partial class SuperAdminDashBoard : Form
    {
        private ActivityButton Activity = new ActivityButton();
        private HomeButton Home = new HomeButton();
        private MAdminButton MAdmin = new MAdminButton();
        public SuperAdminDashBoard()
        {
            InitializeComponent();
            LoadPage(Home);
        }
        private void LoadPage(UserControl page)
        {
            ShowContentPnl.Controls.Clear();
            page.Dock = DockStyle.Fill;
            ShowContentPnl.Controls.Add(page);
        }

        private void HomeBtn_Click(object sender, EventArgs e) => LoadPage(Home);
        private void AdAccBtn_Click(object sender, EventArgs e) => LoadPage(MAdmin);
        private void ActivityBtn_Click(object sender, EventArgs e) => LoadPage(Activity);
        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
