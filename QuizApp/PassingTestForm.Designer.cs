
namespace QuizApp
{
    partial class PassingTestForm
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
            this.panelTest = new System.Windows.Forms.Panel();
            this.buttonSendAnswers = new System.Windows.Forms.Button();
            this.labelBack = new System.Windows.Forms.LinkLabel();
            this.labelPassingTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panelTest
            // 
            this.panelTest.AutoScroll = true;
            this.panelTest.AutoScrollMargin = new System.Drawing.Size(0, 15);
            this.panelTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.panelTest.ForeColor = System.Drawing.Color.White;
            this.panelTest.Location = new System.Drawing.Point(0, 35);
            this.panelTest.Name = "panelTest";
            this.panelTest.Size = new System.Drawing.Size(861, 385);
            this.panelTest.TabIndex = 0;
            // 
            // buttonSendAnswers
            // 
            this.buttonSendAnswers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSendAnswers.Font = new System.Drawing.Font("Roboto", 15.75F);
            this.buttonSendAnswers.ForeColor = System.Drawing.Color.White;
            this.buttonSendAnswers.Location = new System.Drawing.Point(300, 426);
            this.buttonSendAnswers.Name = "buttonSendAnswers";
            this.buttonSendAnswers.Size = new System.Drawing.Size(254, 38);
            this.buttonSendAnswers.TabIndex = 21;
            this.buttonSendAnswers.Text = "Отправить ответы";
            this.buttonSendAnswers.UseVisualStyleBackColor = true;
            this.buttonSendAnswers.Click += new System.EventHandler(this.buttonSendAnswers_Click);
            // 
            // labelBack
            // 
            this.labelBack.ActiveLinkColor = System.Drawing.Color.Gray;
            this.labelBack.AutoSize = true;
            this.labelBack.Font = new System.Drawing.Font("Roboto Light", 10.75F);
            this.labelBack.LinkColor = System.Drawing.Color.White;
            this.labelBack.Location = new System.Drawing.Point(8, 9);
            this.labelBack.Name = "labelBack";
            this.labelBack.Size = new System.Drawing.Size(104, 18);
            this.labelBack.TabIndex = 28;
            this.labelBack.TabStop = true;
            this.labelBack.Text = "<- На главную";
            this.labelBack.VisitedLinkColor = System.Drawing.Color.Gainsboro;
            this.labelBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.labelBack_LinkClicked);
            // 
            // labelPassingTime
            // 
            this.labelPassingTime.Font = new System.Drawing.Font("Roboto Thin", 12.75F);
            this.labelPassingTime.Location = new System.Drawing.Point(579, 426);
            this.labelPassingTime.Name = "labelPassingTime";
            this.labelPassingTime.Size = new System.Drawing.Size(270, 35);
            this.labelPassingTime.TabIndex = 29;
            this.labelPassingTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PassingTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(861, 470);
            this.Controls.Add(this.labelPassingTime);
            this.Controls.Add(this.labelBack);
            this.Controls.Add(this.buttonSendAnswers);
            this.Controls.Add(this.panelTest);
            this.Font = new System.Drawing.Font("Roboto Thin", 9.75F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PassingTestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PassingTestForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTest;
        private System.Windows.Forms.Button buttonSendAnswers;
        private System.Windows.Forms.LinkLabel labelBack;
        private System.Windows.Forms.Label labelPassingTime;
    }
}