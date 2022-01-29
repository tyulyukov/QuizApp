
namespace QuizServer
{
    partial class ServerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServerForm));
            this.buttonStart = new System.Windows.Forms.Button();
            this.listBoxLogs = new System.Windows.Forms.ListBox();
            this.numericUpDownDelay = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.timerLogs = new System.Windows.Forms.Timer(this.components);
            this.checkBoxHideInTray = new System.Windows.Forms.CheckBox();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDelay)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonStart.Font = new System.Drawing.Font("Roboto Light", 8.25F);
            this.buttonStart.Location = new System.Drawing.Point(127, 366);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(193, 33);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // listBoxLogs
            // 
            this.listBoxLogs.Dock = System.Windows.Forms.DockStyle.Top;
            this.listBoxLogs.Font = new System.Drawing.Font("Roboto Light", 8.25F);
            this.listBoxLogs.FormattingEnabled = true;
            this.listBoxLogs.Location = new System.Drawing.Point(0, 0);
            this.listBoxLogs.Name = "listBoxLogs";
            this.listBoxLogs.Size = new System.Drawing.Size(467, 355);
            this.listBoxLogs.TabIndex = 1;
            // 
            // numericUpDownDelay
            // 
            this.numericUpDownDelay.Location = new System.Drawing.Point(370, 381);
            this.numericUpDownDelay.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownDelay.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownDelay.Name = "numericUpDownDelay";
            this.numericUpDownDelay.Size = new System.Drawing.Size(85, 21);
            this.numericUpDownDelay.TabIndex = 2;
            this.numericUpDownDelay.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericUpDownDelay.ValueChanged += new System.EventHandler(this.numericUpDownDelay_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(368, 366);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Log delay (secs):";
            // 
            // timerLogs
            // 
            this.timerLogs.Interval = 15000;
            this.timerLogs.Tick += new System.EventHandler(this.timerLogs_Tick);
            // 
            // checkBoxHideInTray
            // 
            this.checkBoxHideInTray.AutoSize = true;
            this.checkBoxHideInTray.Location = new System.Drawing.Point(12, 375);
            this.checkBoxHideInTray.Name = "checkBoxHideInTray";
            this.checkBoxHideInTray.Size = new System.Drawing.Size(81, 17);
            this.checkBoxHideInTray.TabIndex = 4;
            this.checkBoxHideInTray.Text = "Hide in tray";
            this.checkBoxHideInTray.UseVisualStyleBackColor = true;
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Quiz Server";
            this.notifyIcon.Click += new System.EventHandler(this.notifyIcon_Click);
            // 
            // ServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 411);
            this.Controls.Add(this.checkBoxHideInTray);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownDelay);
            this.Controls.Add(this.listBoxLogs);
            this.Controls.Add(this.buttonStart);
            this.Font = new System.Drawing.Font("Roboto Light", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ServerForm";
            this.Text = "Server QuizApp";
            this.Resize += new System.EventHandler(this.ServerForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDelay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.ListBox listBoxLogs;
        private System.Windows.Forms.NumericUpDown numericUpDownDelay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timerLogs;
        private System.Windows.Forms.CheckBox checkBoxHideInTray;
        private System.Windows.Forms.NotifyIcon notifyIcon;
    }
}

