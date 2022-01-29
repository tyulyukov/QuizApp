
namespace QuizApp
{
    partial class MyStatisticsForm
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
            this.buttonUpdateMyStatistics = new System.Windows.Forms.PictureBox();
            this.panelMyStatistics = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.buttonUpdateMyStatistics)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonUpdateMyStatistics
            // 
            this.buttonUpdateMyStatistics.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUpdateMyStatistics.Image = global::QuizApp.Properties.Resources.update_icon;
            this.buttonUpdateMyStatistics.Location = new System.Drawing.Point(12, 12);
            this.buttonUpdateMyStatistics.Name = "buttonUpdateMyStatistics";
            this.buttonUpdateMyStatistics.Size = new System.Drawing.Size(30, 30);
            this.buttonUpdateMyStatistics.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonUpdateMyStatistics.TabIndex = 25;
            this.buttonUpdateMyStatistics.TabStop = false;
            this.buttonUpdateMyStatistics.Click += new System.EventHandler(this.buttonUpdateMyStatistics_Click);
            // 
            // panelMyStatistics
            // 
            this.panelMyStatistics.AutoScroll = true;
            this.panelMyStatistics.AutoScrollMargin = new System.Drawing.Size(0, 15);
            this.panelMyStatistics.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelMyStatistics.Location = new System.Drawing.Point(0, 62);
            this.panelMyStatistics.Name = "panelMyStatistics";
            this.panelMyStatistics.Size = new System.Drawing.Size(861, 408);
            this.panelMyStatistics.TabIndex = 24;
            // 
            // MyStatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(861, 470);
            this.Controls.Add(this.buttonUpdateMyStatistics);
            this.Controls.Add(this.panelMyStatistics);
            this.Font = new System.Drawing.Font("Roboto Thin", 9.75F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MyStatisticsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "StatisticsForm";
            this.Load += new System.EventHandler(this.StatisticsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.buttonUpdateMyStatistics)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox buttonUpdateMyStatistics;
        private System.Windows.Forms.Panel panelMyStatistics;
    }
}