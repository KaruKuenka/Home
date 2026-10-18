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
            this.BGpic = new Guna.UI2.WinForms.Guna2PictureBox();
            this.ShowContentpnl = new Guna.UI2.WinForms.Guna2GradientPanel();
            ((System.ComponentModel.ISupportInitialize)(this.BGpic)).BeginInit();
            this.SuspendLayout();
            // 
            // BGpic
            // 
            this.BGpic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BGpic.Image = global::Home.Properties.Resources.Background;
            this.BGpic.Location = new System.Drawing.Point(0, 0);
            this.BGpic.Name = "BGpic";
            this.BGpic.ShadowDecoration.Parent = this.BGpic;
            this.BGpic.Size = new System.Drawing.Size(800, 450);
            this.BGpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BGpic.TabIndex = 0;
            this.BGpic.TabStop = false;
            // 
            // ShowContentpnl
            // 
            this.ShowContentpnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.ShowContentpnl.Location = new System.Drawing.Point(0, 0);
            this.ShowContentpnl.Name = "ShowContentpnl";
            this.ShowContentpnl.ShadowDecoration.Parent = this.ShowContentpnl;
            this.ShowContentpnl.Size = new System.Drawing.Size(248, 450);
            this.ShowContentpnl.TabIndex = 1;
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ShowContentpnl);
            this.Controls.Add(this.BGpic);
            this.Name = "LoginPage";
            this.Text = "LoginPage";
            ((System.ComponentModel.ISupportInitialize)(this.BGpic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox BGpic;
        private Guna.UI2.WinForms.Guna2GradientPanel ShowContentpnl;
    }
}