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
        public event EventHandler AdminClicked;
        public event EventHandler HomeownerClicked;
        public event EventHandler BackClicked;
        public WelcomeShow()
        {
            InitializeComponent();
            HomeOwnerBtn.Text = "Home Owner\nPay fees, send reports, view history";
            AdminBtn.Text = "Admin\nManage reports, payments and announcements";
        }


        private void HomeOwnerBtn_Click(object sender, EventArgs e)
        {
            HomeownerClicked?.Invoke(this, EventArgs.Empty);
        }

        private void AdminBtn_Click(object sender, EventArgs e)
        {
            AdminClicked?.Invoke(this, EventArgs.Empty);
        }

        private void BackLoginBtn_Click(object sender, EventArgs e)
        {
            BackClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}

