
namespace Diploma
{
    partial class Login
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.PanelLogin = new Guna.UI2.WinForms.Guna2Panel();
            this.error = new System.Windows.Forms.Label();
            this.LoginButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox4 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.PassF = new Guna.UI2.WinForms.Guna2TextBox();
            this.closeLabel = new System.Windows.Forms.Label();
            this.guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.LoginF = new Guna.UI2.WinForms.Guna2TextBox();
            this.LogoPic = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.LeftPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.PanelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.LeftPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelLogin
            // 
            this.PanelLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(196)))));
            this.PanelLogin.BorderColor = System.Drawing.Color.LightSkyBlue;
            this.PanelLogin.BorderRadius = 5;
            this.PanelLogin.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.PanelLogin.Controls.Add(this.error);
            this.PanelLogin.Controls.Add(this.LoginButton);
            this.PanelLogin.Controls.Add(this.guna2PictureBox4);
            this.PanelLogin.Controls.Add(this.PassF);
            this.PanelLogin.Controls.Add(this.closeLabel);
            this.PanelLogin.Controls.Add(this.guna2PictureBox3);
            this.PanelLogin.Controls.Add(this.LoginF);
            this.PanelLogin.Controls.Add(this.LogoPic);
            this.PanelLogin.CustomBorderColor = System.Drawing.Color.LightSkyBlue;
            this.PanelLogin.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelLogin.Location = new System.Drawing.Point(337, 0);
            this.PanelLogin.Name = "PanelLogin";
            this.PanelLogin.ShadowDecoration.Parent = this.PanelLogin;
            this.PanelLogin.Size = new System.Drawing.Size(288, 271);
            this.PanelLogin.TabIndex = 2;
            this.PanelLogin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelLogin_MouseDown);
            this.PanelLogin.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelLogin_MouseMove);
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.BackColor = System.Drawing.Color.DarkRed;
            this.error.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.error.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.error.ForeColor = System.Drawing.Color.White;
            this.error.Location = new System.Drawing.Point(83, 243);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(149, 21);
            this.error.TabIndex = 5;
            this.error.Text = "Неверные данные";
            this.error.Visible = false;
            // 
            // LoginButton
            // 
            this.LoginButton.Animated = true;
            this.LoginButton.BackColor = System.Drawing.Color.Transparent;
            this.LoginButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(132)))), ((int)(((byte)(38)))));
            this.LoginButton.BorderRadius = 4;
            this.LoginButton.BorderThickness = 2;
            this.LoginButton.CheckedState.Parent = this.LoginButton;
            this.LoginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginButton.CustomImages.Parent = this.LoginButton;
            this.LoginButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(132)))), ((int)(((byte)(38)))));
            this.LoginButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginButton.ForeColor = System.Drawing.Color.White;
            this.LoginButton.HoverState.Parent = this.LoginButton;
            this.LoginButton.IndicateFocus = true;
            this.LoginButton.Location = new System.Drawing.Point(102, 208);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.ShadowDecoration.Parent = this.LoginButton;
            this.LoginButton.Size = new System.Drawing.Size(109, 32);
            this.LoginButton.TabIndex = 4;
            this.LoginButton.Text = "Войти";
            this.LoginButton.UseTransparentBackground = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // guna2PictureBox4
            // 
            this.guna2PictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox4.Image")));
            this.guna2PictureBox4.Location = new System.Drawing.Point(19, 158);
            this.guna2PictureBox4.Name = "guna2PictureBox4";
            this.guna2PictureBox4.ShadowDecoration.Parent = this.guna2PictureBox4;
            this.guna2PictureBox4.Size = new System.Drawing.Size(36, 31);
            this.guna2PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox4.TabIndex = 3;
            this.guna2PictureBox4.TabStop = false;
            // 
            // PassF
            // 
            this.PassF.Animated = true;
            this.PassF.BorderRadius = 4;
            this.PassF.BorderThickness = 2;
            this.PassF.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PassF.DefaultText = "";
            this.PassF.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PassF.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PassF.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PassF.DisabledState.Parent = this.PassF;
            this.PassF.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PassF.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PassF.FocusedState.Parent = this.PassF;
            this.PassF.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.PassF.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PassF.HoverState.Parent = this.PassF;
            this.PassF.Location = new System.Drawing.Point(62, 158);
            this.PassF.Margin = new System.Windows.Forms.Padding(4);
            this.PassF.Name = "PassF";
            this.PassF.PasswordChar = '\0';
            this.PassF.PlaceholderText = "Пароль";
            this.PassF.SelectedText = "";
            this.PassF.ShadowDecoration.Parent = this.PassF;
            this.PassF.Size = new System.Drawing.Size(203, 31);
            this.PassF.TabIndex = 2;
            this.PassF.UseSystemPasswordChar = true;
            // 
            // closeLabel
            // 
            this.closeLabel.AutoSize = true;
            this.closeLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeLabel.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeLabel.ForeColor = System.Drawing.Color.White;
            this.closeLabel.Location = new System.Drawing.Point(264, 0);
            this.closeLabel.Name = "closeLabel";
            this.closeLabel.Size = new System.Drawing.Size(24, 25);
            this.closeLabel.TabIndex = 1;
            this.closeLabel.Text = "×";
            this.closeLabel.Click += new System.EventHandler(this.closeLabel_Click);
            this.closeLabel.MouseEnter += new System.EventHandler(this.closeLabel_MouseEnter);
            this.closeLabel.MouseLeave += new System.EventHandler(this.closeLabel_MouseLeave);
            // 
            // guna2PictureBox3
            // 
            this.guna2PictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox3.Image")));
            this.guna2PictureBox3.Location = new System.Drawing.Point(19, 109);
            this.guna2PictureBox3.Name = "guna2PictureBox3";
            this.guna2PictureBox3.ShadowDecoration.Parent = this.guna2PictureBox3;
            this.guna2PictureBox3.Size = new System.Drawing.Size(36, 36);
            this.guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox3.TabIndex = 1;
            this.guna2PictureBox3.TabStop = false;
            // 
            // LoginF
            // 
            this.LoginF.Animated = true;
            this.LoginF.BorderRadius = 4;
            this.LoginF.BorderThickness = 2;
            this.LoginF.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LoginF.DefaultText = "";
            this.LoginF.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.LoginF.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.LoginF.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.LoginF.DisabledState.Parent = this.LoginF;
            this.LoginF.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.LoginF.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LoginF.FocusedState.Parent = this.LoginF;
            this.LoginF.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.LoginF.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.LoginF.HoverState.Parent = this.LoginF;
            this.LoginF.Location = new System.Drawing.Point(62, 109);
            this.LoginF.Margin = new System.Windows.Forms.Padding(4);
            this.LoginF.Name = "LoginF";
            this.LoginF.PasswordChar = '\0';
            this.LoginF.PlaceholderText = "Логин";
            this.LoginF.SelectedText = "";
            this.LoginF.ShadowDecoration.Parent = this.LoginF;
            this.LoginF.Size = new System.Drawing.Size(203, 31);
            this.LoginF.TabIndex = 0;
            // 
            // LogoPic
            // 
            this.LogoPic.BackColor = System.Drawing.Color.Transparent;
            this.LogoPic.FillColor = System.Drawing.Color.Transparent;
            this.LogoPic.Image = ((System.Drawing.Image)(resources.GetObject("LogoPic.Image")));
            this.LogoPic.Location = new System.Drawing.Point(19, 12);
            this.LogoPic.Name = "LogoPic";
            this.LogoPic.ShadowDecoration.Parent = this.LogoPic;
            this.LogoPic.Size = new System.Drawing.Size(266, 64);
            this.LogoPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoPic.TabIndex = 0;
            this.LogoPic.TabStop = false;
            this.LogoPic.UseTransparentBackground = true;
            this.LogoPic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LogoPic_MouseDown);
            this.LogoPic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LogoPic_MouseMove);
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox2.Image")));
            this.guna2PictureBox2.Location = new System.Drawing.Point(0, 0);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.ShadowDecoration.Parent = this.guna2PictureBox2;
            this.guna2PictureBox2.Size = new System.Drawing.Size(338, 271);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox2.TabIndex = 1;
            this.guna2PictureBox2.TabStop = false;
            // 
            // LeftPanel
            // 
            this.LeftPanel.AutoRoundedCorners = true;
            this.LeftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.LeftPanel.BorderColor = System.Drawing.Color.White;
            this.LeftPanel.BorderRadius = 134;
            this.LeftPanel.Controls.Add(this.guna2Button1);
            this.LeftPanel.Controls.Add(this.guna2PictureBox2);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.ShadowDecoration.Parent = this.LeftPanel;
            this.LeftPanel.Size = new System.Drawing.Size(338, 271);
            this.LeftPanel.TabIndex = 1;
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(132)))), ((int)(((byte)(38)))));
            this.guna2Button1.BorderRadius = 4;
            this.guna2Button1.BorderThickness = 2;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(132)))), ((int)(((byte)(38)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.IndicateFocus = true;
            this.guna2Button1.Location = new System.Drawing.Point(12, 12);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(130, 32);
            this.guna2Button1.TabIndex = 6;
            this.guna2Button1.Text = "Быстрый вход";
            this.guna2Button1.UseTransparentBackground = true;
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.BorderRadius = 16;
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.ResizeForm = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(625, 271);
            this.Controls.Add(this.PanelLogin);
            this.Controls.Add(this.LeftPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.PanelLogin.ResumeLayout(false);
            this.PanelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.LeftPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel PanelLogin;
        private System.Windows.Forms.Label closeLabel;
        private Guna.UI2.WinForms.Guna2TextBox LoginF;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox3;
        private Guna.UI2.WinForms.Guna2PictureBox LogoPic;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private Guna.UI2.WinForms.Guna2Panel LeftPanel;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox4;
        private Guna.UI2.WinForms.Guna2TextBox PassF;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2Button LoginButton;
        private System.Windows.Forms.Label error;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}

