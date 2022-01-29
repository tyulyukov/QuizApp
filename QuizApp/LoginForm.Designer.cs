
namespace QuizApp
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.label3 = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.checkBoxShow = new System.Windows.Forms.CheckBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelClickHere = new System.Windows.Forms.LinkLabel();
            this.panelAppMenu = new System.Windows.Forms.Panel();
            this.buttonMinimizeApp = new System.Windows.Forms.PictureBox();
            this.buttonMaximizeApp = new System.Windows.Forms.PictureBox();
            this.buttonCloseApp = new System.Windows.Forms.PictureBox();
            this.panelAppMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonMinimizeApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonMaximizeApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonCloseApp)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Light", 12.75F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(43, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(242, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "У вас нет аккаунта? Нажмите";
            // 
            // buttonLogin
            // 
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Roboto Light", 15F);
            this.buttonLogin.ForeColor = System.Drawing.Color.White;
            this.buttonLogin.Location = new System.Drawing.Point(99, 214);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(177, 35);
            this.buttonLogin.TabIndex = 13;
            this.buttonLogin.Text = "Войти в аккаунт";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // checkBoxShow
            // 
            this.checkBoxShow.AutoSize = true;
            this.checkBoxShow.Font = new System.Drawing.Font("Roboto Light", 11F);
            this.checkBoxShow.ForeColor = System.Drawing.Color.White;
            this.checkBoxShow.Location = new System.Drawing.Point(255, 151);
            this.checkBoxShow.Name = "checkBoxShow";
            this.checkBoxShow.Size = new System.Drawing.Size(93, 22);
            this.checkBoxShow.TabIndex = 12;
            this.checkBoxShow.Text = "Показать";
            this.checkBoxShow.UseVisualStyleBackColor = true;
            this.checkBoxShow.CheckedChanged += new System.EventHandler(this.checkBoxShow_CheckedChanged);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPassword.Font = new System.Drawing.Font("Roboto Light", 15F);
            this.textBoxPassword.Location = new System.Drawing.Point(59, 148);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '•';
            this.textBoxPassword.Size = new System.Drawing.Size(191, 32);
            this.textBoxPassword.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Light", 19.25F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(53, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 32);
            this.label2.TabIndex = 10;
            this.label2.Text = "Пароль";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxUsername.Font = new System.Drawing.Font("Roboto Light", 15F);
            this.textBoxUsername.Location = new System.Drawing.Point(59, 76);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(263, 32);
            this.textBoxUsername.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Light", 19.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(53, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "Никнейм";
            // 
            // labelClickHere
            // 
            this.labelClickHere.AutoSize = true;
            this.labelClickHere.Font = new System.Drawing.Font("Roboto Light", 12.75F);
            this.labelClickHere.Location = new System.Drawing.Point(283, 258);
            this.labelClickHere.Name = "labelClickHere";
            this.labelClickHere.Size = new System.Drawing.Size(55, 20);
            this.labelClickHere.TabIndex = 15;
            this.labelClickHere.TabStop = true;
            this.labelClickHere.Text = "здесь";
            this.labelClickHere.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.labelClickHere_LinkClicked);
            // 
            // panelAppMenu
            // 
            this.panelAppMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(27)))), ((int)(((byte)(56)))));
            this.panelAppMenu.Controls.Add(this.buttonMinimizeApp);
            this.panelAppMenu.Controls.Add(this.buttonMaximizeApp);
            this.panelAppMenu.Controls.Add(this.buttonCloseApp);
            this.panelAppMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAppMenu.ForeColor = System.Drawing.SystemColors.Control;
            this.panelAppMenu.Location = new System.Drawing.Point(0, 0);
            this.panelAppMenu.Margin = new System.Windows.Forms.Padding(5);
            this.panelAppMenu.Name = "panelAppMenu";
            this.panelAppMenu.Size = new System.Drawing.Size(381, 28);
            this.panelAppMenu.TabIndex = 17;
            this.panelAppMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelAppMenu_MouseDown);
            this.panelAppMenu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelAppMenu_MouseMove);
            this.panelAppMenu.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelAppMenu_MouseUp);
            // 
            // buttonMinimizeApp
            // 
            this.buttonMinimizeApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMinimizeApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMinimizeApp.Image = ((System.Drawing.Image)(resources.GetObject("buttonMinimizeApp.Image")));
            this.buttonMinimizeApp.Location = new System.Drawing.Point(271, -2);
            this.buttonMinimizeApp.Margin = new System.Windows.Forms.Padding(5);
            this.buttonMinimizeApp.Name = "buttonMinimizeApp";
            this.buttonMinimizeApp.Size = new System.Drawing.Size(28, 28);
            this.buttonMinimizeApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonMinimizeApp.TabIndex = 3;
            this.buttonMinimizeApp.TabStop = false;
            this.buttonMinimizeApp.Click += new System.EventHandler(this.buttonMinimizeApp_Click);
            this.buttonMinimizeApp.MouseEnter += new System.EventHandler(this.buttonMinOrMax_MouseEnter);
            this.buttonMinimizeApp.MouseLeave += new System.EventHandler(this.buttonMinOrMax_MouseLeave);
            // 
            // buttonMaximizeApp
            // 
            this.buttonMaximizeApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMaximizeApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMaximizeApp.Enabled = false;
            this.buttonMaximizeApp.Image = ((System.Drawing.Image)(resources.GetObject("buttonMaximizeApp.Image")));
            this.buttonMaximizeApp.Location = new System.Drawing.Point(308, -2);
            this.buttonMaximizeApp.Margin = new System.Windows.Forms.Padding(5);
            this.buttonMaximizeApp.Name = "buttonMaximizeApp";
            this.buttonMaximizeApp.Size = new System.Drawing.Size(28, 28);
            this.buttonMaximizeApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonMaximizeApp.TabIndex = 2;
            this.buttonMaximizeApp.TabStop = false;
            this.buttonMaximizeApp.Click += new System.EventHandler(this.buttonMaximizeApp_Click);
            this.buttonMaximizeApp.MouseEnter += new System.EventHandler(this.buttonMinOrMax_MouseEnter);
            this.buttonMaximizeApp.MouseLeave += new System.EventHandler(this.buttonMinOrMax_MouseLeave);
            // 
            // buttonCloseApp
            // 
            this.buttonCloseApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCloseApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCloseApp.Image = ((System.Drawing.Image)(resources.GetObject("buttonCloseApp.Image")));
            this.buttonCloseApp.Location = new System.Drawing.Point(346, -2);
            this.buttonCloseApp.Margin = new System.Windows.Forms.Padding(5);
            this.buttonCloseApp.Name = "buttonCloseApp";
            this.buttonCloseApp.Size = new System.Drawing.Size(28, 28);
            this.buttonCloseApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonCloseApp.TabIndex = 1;
            this.buttonCloseApp.TabStop = false;
            this.buttonCloseApp.Click += new System.EventHandler(this.buttonCloseApp_Click);
            this.buttonCloseApp.MouseEnter += new System.EventHandler(this.buttonCloseApp_MouseEnter);
            this.buttonCloseApp.MouseLeave += new System.EventHandler(this.buttonCloseApp_MouseLeave);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(381, 298);
            this.Controls.Add(this.panelAppMenu);
            this.Controls.Add(this.labelClickHere);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.checkBoxShow);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Roboto Thin", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginForm_FormClosing);
            this.panelAppMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.buttonMinimizeApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonMaximizeApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonCloseApp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.CheckBox checkBoxShow;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel labelClickHere;
        private System.Windows.Forms.Panel panelAppMenu;
        private System.Windows.Forms.PictureBox buttonMinimizeApp;
        private System.Windows.Forms.PictureBox buttonMaximizeApp;
        private System.Windows.Forms.PictureBox buttonCloseApp;
    }
}