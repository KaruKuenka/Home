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
        public event EventHandler LoginMainClicked;
        public event EventHandler BackClicked;
        public LoginShow()
        {
            InitializeComponent();
        }

        private void LoginMainBtn_Click(object sender, EventArgs e)
        {
            LoginMainClicked?.Invoke(this, EventArgs.Empty);
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            BackClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
