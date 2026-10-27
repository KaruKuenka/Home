namespace Home.Main_Page
{
    partial class WelcomeShow
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ExitBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.LoginBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.SuspendLayout();
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.Transparent;
            this.ExitBtn.BorderRadius = 10;
            this.ExitBtn.CheckedState.Parent = this.ExitBtn;
            this.ExitBtn.CustomImages.Parent = this.ExitBtn;
            this.ExitBtn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ExitBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.ForeColor = System.Drawing.Color.White;
            this.ExitBtn.HoverState.Parent = this.ExitBtn;
            this.ExitBtn.Location = new System.Drawing.Point(40, 264);
            this.ExitBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.ShadowDecoration.Parent = this.ExitBtn;
            this.ExitBtn.Size = new System.Drawing.Size(240, 55);
            this.ExitBtn.TabIndex = 2;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseTransparentBackground = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // LoginBtn
            // 
            this.LoginBtn.BackColor = System.Drawing.Color.Transparent;
            this.LoginBtn.BorderRadius = 10;
            this.LoginBtn.CheckedState.Parent = this.LoginBtn;
            this.LoginBtn.CustomImages.Parent = this.LoginBtn;
            this.LoginBtn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LoginBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginBtn.ForeColor = System.Drawing.Color.White;
            this.LoginBtn.HoverState.Parent = this.LoginBtn;
            this.LoginBtn.Location = new System.Drawing.Point(40, 192);
            this.LoginBtn.Margin = new System.Windows.Forms.Padding(4);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.ShadowDecoration.Parent = this.LoginBtn;
            this.LoginBtn.Size = new System.Drawing.Size(240, 55);
            this.LoginBtn.TabIndex = 3;
            this.LoginBtn.Text = "Get Started";
            this.LoginBtn.UseTransparentBackground = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // WelcomeShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.ExitBtn);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "WelcomeShow";
            this.Size = new System.Drawing.Size(331, 554);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2GradientButton ExitBtn;
        private Guna.UI2.WinForms.Guna2GradientButton LoginBtn;
    }
}
