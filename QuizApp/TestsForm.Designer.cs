
namespace QuizApp
{
    partial class TestsForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.panelConnectTest = new System.Windows.Forms.Panel();
            this.buttonConnectTest = new System.Windows.Forms.PictureBox();
            this.textBoxTestCode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelTests = new System.Windows.Forms.Panel();
            this.buttonUpdateTests = new System.Windows.Forms.PictureBox();
            this.panelConnectTest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonConnectTest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonUpdateTests)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Roboto Light", 12.25F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(15, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(439, 66);
            this.label5.TabIndex = 19;
            this.label5.Text = "Интерактивные задания для контроля знаний и усвоения изученного материала. Выбира" +
    "й для себя тест, или воспользуйся кодом";
            // 
            // panelConnectTest
            // 
            this.panelConnectTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelConnectTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(124)))), ((int)(((byte)(124)))), ((int)(((byte)(219)))));
            this.panelConnectTest.Controls.Add(this.buttonConnectTest);
            this.panelConnectTest.Controls.Add(this.textBoxTestCode);
            this.panelConnectTest.Controls.Add(this.label4);
            this.panelConnectTest.Location = new System.Drawing.Point(475, 15);
            this.panelConnectTest.Name = "panelConnectTest";
            this.panelConnectTest.Size = new System.Drawing.Size(369, 135);
            this.panelConnectTest.TabIndex = 18;
            // 
            // buttonConnectTest
            // 
            this.buttonConnectTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.buttonConnectTest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonConnectTest.Image = global::QuizApp.Properties.Resources.conect_icon;
            this.buttonConnectTest.Location = new System.Drawing.Point(282, 68);
            this.buttonConnectTest.Name = "buttonConnectTest";
            this.buttonConnectTest.Size = new System.Drawing.Size(63, 30);
            this.buttonConnectTest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonConnectTest.TabIndex = 11;
            this.buttonConnectTest.TabStop = false;
            this.buttonConnectTest.Click += new System.EventHandler(this.buttonConnectTest_Click);
            // 
            // textBoxTestCode
            // 
            this.textBoxTestCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTestCode.Font = new System.Drawing.Font("Roboto", 13.75F);
            this.textBoxTestCode.Location = new System.Drawing.Point(25, 68);
            this.textBoxTestCode.Name = "textBoxTestCode";
            this.textBoxTestCode.Size = new System.Drawing.Size(260, 30);
            this.textBoxTestCode.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Roboto", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(19, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(266, 35);
            this.label4.TabIndex = 9;
            this.label4.Text = "Присоединиться";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Roboto", 25.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(276, 47);
            this.label3.TabIndex = 17;
            this.label3.Text = "Онлайн-тесты";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelTests
            // 
            this.panelTests.AutoScroll = true;
            this.panelTests.AutoScrollMargin = new System.Drawing.Size(0, 15);
            this.panelTests.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelTests.Location = new System.Drawing.Point(0, 198);
            this.panelTests.Name = "panelTests";
            this.panelTests.Size = new System.Drawing.Size(861, 272);
            this.panelTests.TabIndex = 20;
            // 
            // buttonUpdateTests
            // 
            this.buttonUpdateTests.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonUpdateTests.Image = global::QuizApp.Properties.Resources.update_icon;
            this.buttonUpdateTests.Location = new System.Drawing.Point(814, 168);
            this.buttonUpdateTests.Name = "buttonUpdateTests";
            this.buttonUpdateTests.Size = new System.Drawing.Size(30, 30);
            this.buttonUpdateTests.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonUpdateTests.TabIndex = 21;
            this.buttonUpdateTests.TabStop = false;
            this.buttonUpdateTests.Click += new System.EventHandler(this.buttonUpdateTests_Click);
            // 
            // TestsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(861, 470);
            this.Controls.Add(this.buttonUpdateTests);
            this.Controls.Add(this.panelTests);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panelConnectTest);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Roboto Thin", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TestsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TestsForm";
            this.Shown += new System.EventHandler(this.TestsForm_Shown);
            this.panelConnectTest.ResumeLayout(false);
            this.panelConnectTest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.buttonConnectTest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonUpdateTests)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelConnectTest;
        private System.Windows.Forms.PictureBox buttonConnectTest;
        private System.Windows.Forms.TextBox textBoxTestCode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelTests;
        private System.Windows.Forms.PictureBox buttonUpdateTests;
    }
}