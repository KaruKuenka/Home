using Guna.UI2.WinForms;
using Home.Dashboards.Home_Owner.Button;
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

namespace Home.Dashboards.Home_Owner
{
    public partial class HODB2 : Form
    {
        private AccountButtonHO Account = new AccountButtonHO();
        private ReportButtonHO Rport = new ReportButtonHO();
        private PayButtonHO Payed = new PayButtonHO();
        private HistoryButtonHO Histo = new HistoryButtonHO();
        private HomeButtonHO Homepage = new HomeButtonHO();

        public HODB2()
        {
            InitializeComponent();
            this.Load += HODB2_Load;
        }
        private void HODB2_Load(object sender, EventArgs e)
        {
            if (Session.Role != "HomeOwner") { Close(); return; }
            LoadPage(Homepage, "Home");
            Highlight(HomeBtn);
        }

        private void LoadPage(UserControl page, string title)
        {
            ShowCOntentPnl.Controls.Clear();
            page.Dock = DockStyle.Fill;
            ShowCOntentPnl.Controls.Add(page);
            HeaderButtonLbl.Text = title;
        }
        private void Highlight(Guna2Button active)
        {
            foreach (var b in new[] { HomeBtn, ReportBtn, PaymentBtn, HistoryBtn, AccountBtn })
                b.Checked = (b == active);
        }

        private void AccountBtn_Click(object sender, EventArgs e)
        {
            LoadPage(Account, "Account");
            Highlight(AccountBtn);
        }

        private void PaymentBtn_Click(object sender, EventArgs e)
        {
            LoadPage(Payed, "Pay Monthly Fee");
            Highlight(PaymentBtn);
        }



        private void ReportBtn_Click(object sender, EventArgs e)
        {
            LoadPage(Rport, "Report an Issue");
            Highlight(ReportBtn);
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            LoadPage(Homepage, "Home");
            Highlight(HomeBtn);
        }

        private void HistoryBtn_Click(object sender, EventArgs e)
        {
            LoadPage(Histo, "Payment History");
            Highlight(HistoryBtn);
        }



        private void LogoutBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
