
namespace QuizApp
{
    partial class MyTestsForm
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
            this.buttonUpdateTests = new System.Windows.Forms.PictureBox();
            this.panelMyTests = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.buttonUpdateTests)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonUpdateTests
            // 
            this.buttonUpdateTests.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUpdateTests.Image = global::QuizApp.Properties.Resources.update_icon;
            this.buttonUpdateTests.Location = new System.Drawing.Point(12, 12);
            this.buttonUpdateTests.Name = "buttonUpdateTests";
            this.buttonUpdateTests.Size = new System.Drawing.Size(30, 30);
            this.buttonUpdateTests.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonUpdateTests.TabIndex = 23;
            this.buttonUpdateTests.TabStop = false;
            this.buttonUpdateTests.Click += new System.EventHandler(this.buttonUpdateTests_Click);
            // 
            // panelMyTests
            // 
            this.panelMyTests.AutoScroll = true;
            this.panelMyTests.AutoScrollMargin = new System.Drawing.Size(0, 15);
            this.panelMyTests.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelMyTests.Location = new System.Drawing.Point(0, 63);
            this.panelMyTests.Name = "panelMyTests";
            this.panelMyTests.Size = new System.Drawing.Size(861, 407);
            this.panelMyTests.TabIndex = 22;
            // 
            // MyTestsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(861, 470);
            this.Controls.Add(this.buttonUpdateTests);
            this.Controls.Add(this.panelMyTests);
            this.Font = new System.Drawing.Font("Roboto Thin", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MyTestsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MyTestsForm";
            this.Shown += new System.EventHandler(this.MyTestsForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.buttonUpdateTests)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox buttonUpdateTests;
        private System.Windows.Forms.Panel panelMyTests;
    }
}