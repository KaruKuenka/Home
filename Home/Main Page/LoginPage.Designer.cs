namespace Home.Main_Page
{
    partial class LoginPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            this.BGpic = new Guna.UI2.WinForms.Guna2PictureBox();
            this.ShowContentpnl = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BGpic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BGpic
            // 
            this.BGpic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BGpic.Image = global::Home.Properties.Resources.Background;
            this.BGpic.Location = new System.Drawing.Point(0, 0);
            this.BGpic.Margin = new System.Windows.Forms.Padding(4);
            this.BGpic.Name = "BGpic";
            this.BGpic.ShadowDecoration.Parent = this.BGpic;
            this.BGpic.Size = new System.Drawing.Size(1067, 554);
            this.BGpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BGpic.TabIndex = 0;
            this.BGpic.TabStop = false;
            // 
            // ShowContentpnl
            // 
            this.ShowContentpnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.ShowContentpnl.Location = new System.Drawing.Point(0, 0);
            this.ShowContentpnl.Margin = new System.Windows.Forms.Padding(4);
            this.ShowContentpnl.Name = "ShowContentpnl";
            this.ShowContentpnl.ShadowDecoration.Parent = this.ShowContentpnl;
            this.ShowContentpnl.Size = new System.Drawing.Size(331, 554);
            this.ShowContentpnl.TabIndex = 1;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.guna2PictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.Location = new System.Drawing.Point(488, 160);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(464, 240);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 2;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.ShowContentpnl);
            this.Controls.Add(this.BGpic);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoginPage";
            this.Text = "LoginPage";
            ((System.ComponentModel.ISupportInitialize)(this.BGpic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox BGpic;
        private Guna.UI2.WinForms.Guna2GradientPanel ShowContentpnl;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
    }
}