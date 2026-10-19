using Home.Dashboards.Admin.Buttons;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home.Dashboards.Admin
{
    public partial class AdminDashBoard : Form
    {
        private AccountButton Account = new AccountButton();
        private AnnouncementButton Announcement = new AnnouncementButton();
        private HomeownersButton HOacc = new HomeownersButton();
        private HomeButton Home = new HomeButton();
        private PaymentsButton Payment = new PaymentsButton();
        private ReportsButton Report = new ReportsButton();

        public AdminDashBoard()
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



        private void AccountBtn_Click(object sender, EventArgs e) => LoadPage(Account);
        private void AnnounceBtn_Click(object sender, EventArgs e) => LoadPage(Announcement);
        private void HOaccBtn_Click(object sender, EventArgs e) => LoadPage(HOacc);
        private void PaymentBtn_Click(object sender, EventArgs e) => LoadPage(Payment);
        private void ReportBtn_Click(object sender, EventArgs e) => LoadPage(Report);
        private void HomeBtn_Click(object sender, EventArgs e) => LoadPage(Home);
        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
