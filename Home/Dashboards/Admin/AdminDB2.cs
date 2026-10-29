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
using Guna.UI2.WinForms;

namespace Home.Dashboards.Admin
{
    public partial class AdminDB2 : Form
    {
        private AccountsButtonA Account = new AccountsButtonA();
        private AnnouncementButtonA Announcement = new AnnouncementButtonA();
        private HomeButtonA HomePage = new HomeButtonA();
        private PaymentsButtonA Payment = new PaymentsButtonA();
        private ReportsButtonA Report = new ReportsButtonA();

        public AdminDB2()
        {
            InitializeComponent();
            LoadPage(HomePage, "Home");
            Highlight(HomeBtn);

        }

        private void LoadPage(UserControl page, string title)
        {
            ShowContentPnl.Controls.Clear();
            page.Dock = DockStyle.Fill;
            ShowContentPnl.Controls.Add(page);
            HeaderButtonLbl.Text = title;
        }
        private void Highlight(Guna2Button active)
        {
            foreach (var b in new[] { HomeBtn, ReportBtn, PaymentBtn, AnnounceBtn, AccountBtn })
                b.Checked = (b == active);
        }


        private void AccountBtn_Click(object sender, EventArgs e)
        {
            Highlight(AccountBtn);
            LoadPage(Account, "Account");
        }
        private void AnnounceBtn_Click(object sender, EventArgs e)
        {
            Highlight(AnnounceBtn);
            LoadPage(Announcement, "Announcements");
        }
        private void PaymentBtn_Click(object sender, EventArgs e)
        {
            Highlight(PaymentBtn);
            LoadPage(Payment, "Payments");
        }
        private void ReportBtn_Click(object sender, EventArgs e)
        {
            Highlight(ReportBtn);
            LoadPage(Report, "Reports");
        }
        private void HomeBtn_Click(object sender, EventArgs e)
        {
            Highlight(HomeBtn);
            LoadPage(HomePage, "Home");
        }
        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
