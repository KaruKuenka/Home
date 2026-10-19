using Home.Dashboards.Home_Owner.Button;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home.Dashboards.Home_Owner
{
    public partial class HODashBoard : Form
    {
        private AccountButton Account;
        private ReportButton Rport;
        private PayButton Payed;
        private HistoryButton Histo;
        private HomeButton Home;
        public HODashBoard()
        {
            InitializeComponent();

            Home = new HomeButton();
            Account = new AccountButton();
            Rport = new ReportButton();
            Payed = new PayButton();
            Histo = new HistoryButton();

            LoadPage(Home);
        }

        private void LoadPage(UserControl page)
        {
            ShowContentPnl.Controls.Clear();
            page.Dock = DockStyle.Fill;
            ShowContentPnl.Controls.Add(page);
        }

        private void HomeBtn_Click(object sender, EventArgs e) => LoadPage(Home);
        private void AccountBtn_Click(object sender, EventArgs e) => LoadPage(Account);
        private void ReportBtn_Click(object sender, EventArgs e) => LoadPage(Rport);
        private void PaymentBtn_Click(object sender, EventArgs e) => LoadPage(Payed);
        private void HistoryBtn_Click(object sender, EventArgs e) => LoadPage(Histo);



        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
