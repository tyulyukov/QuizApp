
namespace QuizApp
{
    partial class QuizForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuizForm));
            this.panelAppMenu = new System.Windows.Forms.Panel();
            this.buttonMinimizeApp = new System.Windows.Forms.PictureBox();
            this.buttonMaximizeApp = new System.Windows.Forms.PictureBox();
            this.buttonCloseApp = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.panelTests = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonMain = new System.Windows.Forms.PictureBox();
            this.labelPersonalArea = new System.Windows.Forms.Label();
            this.buttonPersonalArea = new System.Windows.Forms.PictureBox();
            this.labelExit = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.PictureBox();
            this.panelUserInfo = new System.Windows.Forms.Panel();
            this.pictureBoxAvatar = new System.Windows.Forms.PictureBox();
            this.labelNickname = new System.Windows.Forms.Label();
            this.listBoxSearchVariants = new System.Windows.Forms.ListBox();
            this.buttonCreateTest = new System.Windows.Forms.PictureBox();
            this.buttonTests = new System.Windows.Forms.PictureBox();
            this.pictureBoxMenu = new System.Windows.Forms.PictureBox();
            this.buttonSearch = new System.Windows.Forms.PictureBox();
            this.buttonAccount = new System.Windows.Forms.PictureBox();
            this.panelAppMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonMinimizeApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonMaximizeApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonCloseApp)).BeginInit();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonPersonalArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonExit)).BeginInit();
            this.panelUserInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonCreateTest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonTests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonAccount)).BeginInit();
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
            this.panelAppMenu.Size = new System.Drawing.Size(939, 28);
            this.panelAppMenu.TabIndex = 3;
            this.panelAppMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelAppMenu_MouseDown);
            this.panelAppMenu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelAppMenu_MouseMove);
            this.panelAppMenu.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelAppMenu_MouseUp);
            // 
            // buttonMinimizeApp
            // 
            this.buttonMinimizeApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMinimizeApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMinimizeApp.Image = ((System.Drawing.Image)(resources.GetObject("buttonMinimizeApp.Image")));
            this.buttonMinimizeApp.Location = new System.Drawing.Point(828, -2);
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
            this.buttonMaximizeApp.Location = new System.Drawing.Point(865, -2);
            this.buttonMaximizeApp.Margin = new System.Windows.Forms.Padding(5);
            this.buttonMaximizeApp.Name = "buttonMaximizeApp";
            this.buttonMaximizeApp.Size = new System.Drawing.Size(28, 28);
            this.buttonMaximizeApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonMaximizeApp.TabIndex = 2;
            this.buttonMaximizeApp.TabStop = false;
            this.buttonMaximizeApp.Click += new System.EventHandler(this.buttonMaximizeApp_Click);
            // 
            // buttonCloseApp
            // 
            this.buttonCloseApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCloseApp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCloseApp.Image = ((System.Drawing.Image)(resources.GetObject("buttonCloseApp.Image")));
            this.buttonCloseApp.Location = new System.Drawing.Point(904, -2);
            this.buttonCloseApp.Margin = new System.Windows.Forms.Padding(5);
            this.buttonCloseApp.Name = "buttonCloseApp";
            this.buttonCloseApp.Size = new System.Drawing.Size(28, 28);
            this.buttonCloseApp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonCloseApp.TabIndex = 1;
            this.buttonCloseApp.TabStop = false;
            this.buttonCloseApp.Click += new System.EventHandler(this.buttonCloseApp_Click);
            this.buttonCloseApp.MouseEnter += new System.EventHandler(this.buttonCloseApp_MouseEnter);
            this.buttonCloseApp.MouseLeave += new System.EventHandler(this.buttonMinOrMax_MouseLeave);
            // 
            // label2
            // 
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Roboto Thin", 11.25F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 37);
            this.label2.TabIndex = 19;
            this.label2.Text = "Создать тест";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.buttonCreateTest_Click);
            // 
            // label1
            // 
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Roboto Thin", 11.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 19);
            this.label1.TabIndex = 15;
            this.label1.Text = "Тесты";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.buttonTests_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(7)))), ((int)(((byte)(24)))));
            this.textBoxSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSearch.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSearch.ForeColor = System.Drawing.Color.White;
            this.textBoxSearch.Location = new System.Drawing.Point(147, 47);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(583, 33);
            this.textBoxSearch.TabIndex = 16;
            this.textBoxSearch.TabStop = false;
            this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // panelTests
            // 
            this.panelTests.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTests.AutoScroll = true;
            this.panelTests.AutoScrollMargin = new System.Drawing.Size(0, 15);
            this.panelTests.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.panelTests.Location = new System.Drawing.Point(78, 95);
            this.panelTests.Name = "panelTests";
            this.panelTests.Size = new System.Drawing.Size(861, 470);
            this.panelTests.TabIndex = 20;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelMenu.Controls.Add(this.label3);
            this.panelMenu.Controls.Add(this.buttonMain);
            this.panelMenu.Controls.Add(this.labelPersonalArea);
            this.panelMenu.Controls.Add(this.buttonPersonalArea);
            this.panelMenu.Controls.Add(this.labelExit);
            this.panelMenu.Controls.Add(this.buttonExit);
            this.panelMenu.Controls.Add(this.panelUserInfo);
            this.panelMenu.Location = new System.Drawing.Point(930, 95);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(10, 471);
            this.panelMenu.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Roboto Light", 14F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(58, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Главная";
            this.label3.Click += new System.EventHandler(this.buttonMain_Click);
            // 
            // buttonMain
            // 
            this.buttonMain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonMain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMain.Image = global::QuizApp.Properties.Resources.home_icon;
            this.buttonMain.Location = new System.Drawing.Point(12, 115);
            this.buttonMain.Name = "buttonMain";
            this.buttonMain.Size = new System.Drawing.Size(40, 40);
            this.buttonMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonMain.TabIndex = 7;
            this.buttonMain.TabStop = false;
            this.buttonMain.Click += new System.EventHandler(this.buttonMain_Click);
            // 
            // labelPersonalArea
            // 
            this.labelPersonalArea.AutoSize = true;
            this.labelPersonalArea.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelPersonalArea.Font = new System.Drawing.Font("Roboto Light", 14F);
            this.labelPersonalArea.ForeColor = System.Drawing.Color.White;
            this.labelPersonalArea.Location = new System.Drawing.Point(58, 169);
            this.labelPersonalArea.Name = "labelPersonalArea";
            this.labelPersonalArea.Size = new System.Drawing.Size(156, 23);
            this.labelPersonalArea.TabIndex = 6;
            this.labelPersonalArea.Text = "Личный кабинет";
            this.labelPersonalArea.Click += new System.EventHandler(this.buttonPersonalArea_Click);
            // 
            // buttonPersonalArea
            // 
            this.buttonPersonalArea.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonPersonalArea.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPersonalArea.Image = global::QuizApp.Properties.Resources.personal_area_icon;
            this.buttonPersonalArea.Location = new System.Drawing.Point(12, 161);
            this.buttonPersonalArea.Name = "buttonPersonalArea";
            this.buttonPersonalArea.Size = new System.Drawing.Size(40, 40);
            this.buttonPersonalArea.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonPersonalArea.TabIndex = 5;
            this.buttonPersonalArea.TabStop = false;
            this.buttonPersonalArea.Click += new System.EventHandler(this.buttonPersonalArea_Click);
            // 
            // labelExit
            // 
            this.labelExit.AutoSize = true;
            this.labelExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelExit.Font = new System.Drawing.Font("Roboto Light", 14F);
            this.labelExit.ForeColor = System.Drawing.Color.White;
            this.labelExit.Location = new System.Drawing.Point(58, 424);
            this.labelExit.Name = "labelExit";
            this.labelExit.Size = new System.Drawing.Size(66, 23);
            this.labelExit.TabIndex = 4;
            this.labelExit.Text = "Выход";
            this.labelExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonExit.Image = global::QuizApp.Properties.Resources.exit_icon;
            this.buttonExit.Location = new System.Drawing.Point(12, 416);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(40, 40);
            this.buttonExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonExit.TabIndex = 3;
            this.buttonExit.TabStop = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // panelUserInfo
            // 
            this.panelUserInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(219)))));
            this.panelUserInfo.Controls.Add(this.pictureBoxAvatar);
            this.panelUserInfo.Controls.Add(this.labelNickname);
            this.panelUserInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUserInfo.Location = new System.Drawing.Point(0, 0);
            this.panelUserInfo.Name = "panelUserInfo";
            this.panelUserInfo.Size = new System.Drawing.Size(10, 100);
            this.panelUserInfo.TabIndex = 2;
            // 
            // pictureBoxAvatar
            // 
            this.pictureBoxAvatar.Image = global::QuizApp.Properties.Resources.default_user_avatar;
            this.pictureBoxAvatar.Location = new System.Drawing.Point(12, 23);
            this.pictureBoxAvatar.Name = "pictureBoxAvatar";
            this.pictureBoxAvatar.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAvatar.TabIndex = 0;
            this.pictureBoxAvatar.TabStop = false;
            // 
            // labelNickname
            // 
            this.labelNickname.Font = new System.Drawing.Font("Roboto Light", 16F);
            this.labelNickname.ForeColor = System.Drawing.Color.White;
            this.labelNickname.Location = new System.Drawing.Point(63, 0);
            this.labelNickname.Name = "labelNickname";
            this.labelNickname.Size = new System.Drawing.Size(188, 100);
            this.labelNickname.TabIndex = 1;
            this.labelNickname.Text = "<nickname>";
            this.labelNickname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listBoxSearchVariants
            // 
            this.listBoxSearchVariants.Font = new System.Drawing.Font("Roboto Light", 11.75F);
            this.listBoxSearchVariants.FormattingEnabled = true;
            this.listBoxSearchVariants.ItemHeight = 19;
            this.listBoxSearchVariants.Location = new System.Drawing.Point(147, 79);
            this.listBoxSearchVariants.Name = "listBoxSearchVariants";
            this.listBoxSearchVariants.Size = new System.Drawing.Size(583, 23);
            this.listBoxSearchVariants.TabIndex = 0;
            this.listBoxSearchVariants.Visible = false;
            this.listBoxSearchVariants.SelectedIndexChanged += new System.EventHandler(this.listBoxSearchVariants_SelectedIndexChanged);
            // 
            // buttonCreateTest
            // 
            this.buttonCreateTest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCreateTest.Image = global::QuizApp.Properties.Resources.add_icon;
            this.buttonCreateTest.Location = new System.Drawing.Point(19, 182);
            this.buttonCreateTest.Name = "buttonCreateTest";
            this.buttonCreateTest.Size = new System.Drawing.Size(40, 40);
            this.buttonCreateTest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonCreateTest.TabIndex = 17;
            this.buttonCreateTest.TabStop = false;
            this.buttonCreateTest.Click += new System.EventHandler(this.buttonCreateTest_Click);
            // 
            // buttonTests
            // 
            this.buttonTests.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTests.Image = global::QuizApp.Properties.Resources.home_icon;
            this.buttonTests.Location = new System.Drawing.Point(22, 111);
            this.buttonTests.Name = "buttonTests";
            this.buttonTests.Size = new System.Drawing.Size(35, 35);
            this.buttonTests.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonTests.TabIndex = 14;
            this.buttonTests.TabStop = false;
            this.buttonTests.Click += new System.EventHandler(this.buttonTests_Click);
            // 
            // pictureBoxMenu
            // 
            this.pictureBoxMenu.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBoxMenu.Image = global::QuizApp.Properties.Resources.menu_icon;
            this.pictureBoxMenu.Location = new System.Drawing.Point(12, 36);
            this.pictureBoxMenu.Name = "pictureBoxMenu";
            this.pictureBoxMenu.Size = new System.Drawing.Size(55, 55);
            this.pictureBoxMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMenu.TabIndex = 12;
            this.pictureBoxMenu.TabStop = false;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSearch.Image = global::QuizApp.Properties.Resources.search_icon;
            this.buttonSearch.Location = new System.Drawing.Point(730, 47);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(63, 33);
            this.buttonSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonSearch.TabIndex = 18;
            this.buttonSearch.TabStop = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // buttonAccount
            // 
            this.buttonAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAccount.Image = global::QuizApp.Properties.Resources.default_user_avatar;
            this.buttonAccount.Location = new System.Drawing.Point(876, 36);
            this.buttonAccount.Name = "buttonAccount";
            this.buttonAccount.Size = new System.Drawing.Size(55, 55);
            this.buttonAccount.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonAccount.TabIndex = 13;
            this.buttonAccount.TabStop = false;
            this.buttonAccount.Click += new System.EventHandler(this.buttonAccount_Click);
            // 
            // QuizForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(939, 563);
            this.Controls.Add(this.listBoxSearchVariants);
            this.Controls.Add(this.panelAppMenu);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelTests);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonCreateTest);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonTests);
            this.Controls.Add(this.pictureBoxMenu);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.buttonAccount);
            this.Font = new System.Drawing.Font("Roboto Thin", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QuizForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quiz App";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QuizForm_FormClosing);
            this.panelAppMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.buttonMinimizeApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonMaximizeApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonCloseApp)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonPersonalArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonExit)).EndInit();
            this.panelUserInfo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonCreateTest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonTests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonAccount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelAppMenu;
        private System.Windows.Forms.PictureBox buttonMinimizeApp;
        private System.Windows.Forms.PictureBox buttonMaximizeApp;
        private System.Windows.Forms.PictureBox buttonCloseApp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox buttonCreateTest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox buttonTests;
        private System.Windows.Forms.PictureBox pictureBoxMenu;
        private System.Windows.Forms.PictureBox buttonSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.PictureBox buttonAccount;
        private System.Windows.Forms.Panel panelTests;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelUserInfo;
        private System.Windows.Forms.PictureBox pictureBoxAvatar;
        private System.Windows.Forms.Label labelNickname;
        private System.Windows.Forms.ListBox listBoxSearchVariants;
        private System.Windows.Forms.PictureBox buttonExit;
        private System.Windows.Forms.Label labelExit;
        private System.Windows.Forms.Label labelPersonalArea;
        private System.Windows.Forms.PictureBox buttonPersonalArea;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox buttonMain;
    }
}

