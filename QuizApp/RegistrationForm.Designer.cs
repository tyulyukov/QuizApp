
namespace QuizApp
{
    partial class RegistrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
            this.panelAppMenu = new System.Windows.Forms.Panel();
            this.buttonMinimizeApp = new System.Windows.Forms.PictureBox();
            this.buttonMaximizeApp = new System.Windows.Forms.PictureBox();
            this.buttonCloseApp = new System.Windows.Forms.PictureBox();
            this.textBoxRepeatPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonRegistration = new System.Windows.Forms.Button();
            this.checkBoxShow = new System.Windows.Forms.CheckBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelBack = new System.Windows.Forms.LinkLabel();
            this.panelAppMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonMinimizeApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonMaximizeApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonCloseApp)).BeginInit();
            this.SuspendLayout();
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
            this.panelAppMenu.Size = new System.Drawing.Size(387, 28);
            this.panelAppMenu.TabIndex = 18;
            this.panelAppMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelAppMenu_MouseDown);
            this.panelAppMenu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelAppMenu_MouseMove);
            this.panelAppMenu.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelAppMenu_MouseUp);
            // 
            // buttonMinimizeApp
            // 
            this.buttonMinimizeApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMinimizeApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMinimizeApp.Image = ((System.Drawing.Image)(resources.GetObject("buttonMinimizeApp.Image")));
            this.buttonMinimizeApp.Location = new System.Drawing.Point(277, -2);
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
            this.buttonMaximizeApp.Location = new System.Drawing.Point(314, -2);
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
            this.buttonCloseApp.Location = new System.Drawing.Point(352, -2);
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
            // textBoxRepeatPassword
            // 
            this.textBoxRepeatPassword.Font = new System.Drawing.Font("Roboto Light", 15F);
            this.textBoxRepeatPassword.Location = new System.Drawing.Point(35, 245);
            this.textBoxRepeatPassword.Name = "textBoxRepeatPassword";
            this.textBoxRepeatPassword.PasswordChar = '•';
            this.textBoxRepeatPassword.Size = new System.Drawing.Size(222, 32);
            this.textBoxRepeatPassword.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Light", 19.25F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(29, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 32);
            this.label3.TabIndex = 25;
            this.label3.Text = "Повторите пароль";
            // 
            // buttonRegistration
            // 
            this.buttonRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegistration.Font = new System.Drawing.Font("Roboto Light", 15F);
            this.buttonRegistration.ForeColor = System.Drawing.Color.White;
            this.buttonRegistration.Location = new System.Drawing.Point(79, 292);
            this.buttonRegistration.Name = "buttonRegistration";
            this.buttonRegistration.Size = new System.Drawing.Size(228, 40);
            this.buttonRegistration.TabIndex = 24;
            this.buttonRegistration.Text = "Зарегистрироваться";
            this.buttonRegistration.UseVisualStyleBackColor = true;
            this.buttonRegistration.Click += new System.EventHandler(this.buttonRegistration_Click);
            // 
            // checkBoxShow
            // 
            this.checkBoxShow.AutoSize = true;
            this.checkBoxShow.Font = new System.Drawing.Font("Roboto Light", 11.75F);
            this.checkBoxShow.ForeColor = System.Drawing.Color.White;
            this.checkBoxShow.Location = new System.Drawing.Point(263, 179);
            this.checkBoxShow.Name = "checkBoxShow";
            this.checkBoxShow.Size = new System.Drawing.Size(99, 23);
            this.checkBoxShow.TabIndex = 23;
            this.checkBoxShow.Text = "Показать";
            this.checkBoxShow.UseVisualStyleBackColor = true;
            this.checkBoxShow.CheckedChanged += new System.EventHandler(this.checkBoxShow_CheckedChanged);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Font = new System.Drawing.Font("Roboto Light", 15F);
            this.textBoxPassword.Location = new System.Drawing.Point(35, 171);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '•';
            this.textBoxPassword.Size = new System.Drawing.Size(222, 32);
            this.textBoxPassword.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Light", 19.25F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(29, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 32);
            this.label2.TabIndex = 21;
            this.label2.Text = "Пароль";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Font = new System.Drawing.Font("Roboto Light", 15F);
            this.textBoxUsername.Location = new System.Drawing.Point(38, 96);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(306, 32);
            this.textBoxUsername.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Light", 19.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(32, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 32);
            this.label1.TabIndex = 19;
            this.label1.Text = "Никнейм";
            // 
            // labelBack
            // 
            this.labelBack.AutoSize = true;
            this.labelBack.Font = new System.Drawing.Font("Roboto Light", 10.75F);
            this.labelBack.Location = new System.Drawing.Point(1, 31);
            this.labelBack.Name = "labelBack";
            this.labelBack.Size = new System.Drawing.Size(68, 18);
            this.labelBack.TabIndex = 27;
            this.labelBack.TabStop = true;
            this.labelBack.Text = "<- Назад";
            this.labelBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.labelBack_LinkClicked);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(387, 350);
            this.Controls.Add(this.labelBack);
            this.Controls.Add(this.textBoxRepeatPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonRegistration);
            this.Controls.Add(this.checkBoxShow);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelAppMenu);
            this.Font = new System.Drawing.Font("Roboto Thin", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistrationForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegistrationForm_FormClosing);
            this.panelAppMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.buttonMinimizeApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonMaximizeApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonCloseApp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelAppMenu;
        private System.Windows.Forms.PictureBox buttonMinimizeApp;
        private System.Windows.Forms.PictureBox buttonMaximizeApp;
        private System.Windows.Forms.PictureBox buttonCloseApp;
        private System.Windows.Forms.TextBox textBoxRepeatPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonRegistration;
        private System.Windows.Forms.CheckBox checkBoxShow;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel labelBack;
    }
}