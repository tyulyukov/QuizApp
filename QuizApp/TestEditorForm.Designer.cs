
namespace QuizApp
{
    partial class TestEditorForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.labelBack = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // panelTest
            // 
            this.panelTest.AutoScroll = true;
            this.panelTest.AutoScrollMargin = new System.Drawing.Size(0, 15);
            this.panelTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.panelTest.Location = new System.Drawing.Point(0, 75);
            this.panelTest.Name = "panelTest";
            this.panelTest.Size = new System.Drawing.Size(861, 345);
            this.panelTest.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Roboto", 25.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(18, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(406, 47);
            this.label3.TabIndex = 21;
            this.label3.Text = "Редактирование теста";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonEdit
            // 
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Font = new System.Drawing.Font("Roboto", 15.75F);
            this.buttonEdit.ForeColor = System.Drawing.Color.White;
            this.buttonEdit.Location = new System.Drawing.Point(300, 426);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(254, 38);
            this.buttonEdit.TabIndex = 22;
            this.buttonEdit.Text = "Редактировать тест";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // labelBack
            // 
            this.labelBack.ActiveLinkColor = System.Drawing.Color.Gray;
            this.labelBack.AutoSize = true;
            this.labelBack.Font = new System.Drawing.Font("Roboto Light", 10.75F);
            this.labelBack.LinkColor = System.Drawing.Color.White;
            this.labelBack.Location = new System.Drawing.Point(8, 6);
            this.labelBack.Name = "labelBack";
            this.labelBack.Size = new System.Drawing.Size(140, 18);
            this.labelBack.TabIndex = 29;
            this.labelBack.TabStop = true;
            this.labelBack.Text = "<- Вернуться назад";
            this.labelBack.VisitedLinkColor = System.Drawing.Color.Gainsboro;
            this.labelBack.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.labelBack_LinkClicked);
            // 
            // TestEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(861, 470);
            this.Controls.Add(this.labelBack);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panelTest);
            this.Font = new System.Drawing.Font("Roboto Thin", 9.75F);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TestEditorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TestEditorForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTest;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.LinkLabel labelBack;
    }
}