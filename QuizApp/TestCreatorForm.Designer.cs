
namespace QuizApp
{
    partial class TestCreatorForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.panelTest = new System.Windows.Forms.Panel();
            this.groupBoxQuestion1 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.buttonAddAttachment = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonDeleteQuestion1 = new System.Windows.Forms.PictureBox();
            this.buttonDeleteQuestion1Answer2 = new System.Windows.Forms.PictureBox();
            this.buttonDeleteQuestion1Answer1 = new System.Windows.Forms.PictureBox();
            this.buttonQuestion1AddAnswer = new System.Windows.Forms.PictureBox();
            this.textBoxQuestion1Answer2 = new System.Windows.Forms.TextBox();
            this.checkBoxQuestion1Answer2 = new System.Windows.Forms.CheckBox();
            this.textBoxQuestion1Answer1 = new System.Windows.Forms.TextBox();
            this.checkBoxQuestion1Answer1 = new System.Windows.Forms.CheckBox();
            this.textBoxQuestion1 = new System.Windows.Forms.TextBox();
            this.textBoxTestName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxAddQuestion = new System.Windows.Forms.PictureBox();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.panelTest.SuspendLayout();
            this.groupBoxQuestion1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonAddAttachment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonDeleteQuestion1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonDeleteQuestion1Answer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonDeleteQuestion1Answer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonQuestion1AddAnswer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAddQuestion)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Roboto", 25.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(348, 47);
            this.label3.TabIndex = 18;
            this.label3.Text = "Создание теста";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelTest
            // 
            this.panelTest.AutoScroll = true;
            this.panelTest.AutoScrollMargin = new System.Drawing.Size(0, 15);
            this.panelTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.panelTest.Controls.Add(this.groupBoxQuestion1);
            this.panelTest.Controls.Add(this.textBoxTestName);
            this.panelTest.Controls.Add(this.label1);
            this.panelTest.Controls.Add(this.pictureBoxAddQuestion);
            this.panelTest.Location = new System.Drawing.Point(0, 75);
            this.panelTest.Name = "panelTest";
            this.panelTest.Size = new System.Drawing.Size(861, 345);
            this.panelTest.TabIndex = 19;
            // 
            // groupBoxQuestion1
            // 
            this.groupBoxQuestion1.Controls.Add(this.pictureBox2);
            this.groupBoxQuestion1.Controls.Add(this.buttonAddAttachment);
            this.groupBoxQuestion1.Controls.Add(this.pictureBox1);
            this.groupBoxQuestion1.Controls.Add(this.buttonDeleteQuestion1);
            this.groupBoxQuestion1.Controls.Add(this.buttonDeleteQuestion1Answer2);
            this.groupBoxQuestion1.Controls.Add(this.buttonDeleteQuestion1Answer1);
            this.groupBoxQuestion1.Controls.Add(this.buttonQuestion1AddAnswer);
            this.groupBoxQuestion1.Controls.Add(this.textBoxQuestion1Answer2);
            this.groupBoxQuestion1.Controls.Add(this.checkBoxQuestion1Answer2);
            this.groupBoxQuestion1.Controls.Add(this.textBoxQuestion1Answer1);
            this.groupBoxQuestion1.Controls.Add(this.checkBoxQuestion1Answer1);
            this.groupBoxQuestion1.Controls.Add(this.textBoxQuestion1);
            this.groupBoxQuestion1.Font = new System.Drawing.Font("Roboto Thin", 13.75F);
            this.groupBoxQuestion1.ForeColor = System.Drawing.Color.White;
            this.groupBoxQuestion1.Location = new System.Drawing.Point(35, 99);
            this.groupBoxQuestion1.Name = "groupBoxQuestion1";
            this.groupBoxQuestion1.Size = new System.Drawing.Size(782, 331);
            this.groupBoxQuestion1.TabIndex = 25;
            this.groupBoxQuestion1.TabStop = false;
            this.groupBoxQuestion1.Tag = "1";
            this.groupBoxQuestion1.Text = "Вопрос #1:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::QuizApp.Properties.Resources.delete_icon;
            this.pictureBox2.Location = new System.Drawing.Point(198, 101);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "1";
            // 
            // buttonAddAttachment
            // 
            this.buttonAddAttachment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddAttachment.Image = global::QuizApp.Properties.Resources.attachment_icon;
            this.buttonAddAttachment.Location = new System.Drawing.Point(152, 101);
            this.buttonAddAttachment.Name = "buttonAddAttachment";
            this.buttonAddAttachment.Size = new System.Drawing.Size(40, 40);
            this.buttonAddAttachment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonAddAttachment.TabIndex = 34;
            this.buttonAddAttachment.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QuizApp.Properties.Resources.image_icon;
            this.pictureBox1.Location = new System.Drawing.Point(31, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 115);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // buttonDeleteQuestion1
            // 
            this.buttonDeleteQuestion1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDeleteQuestion1.Image = global::QuizApp.Properties.Resources.delete_icon;
            this.buttonDeleteQuestion1.Location = new System.Drawing.Point(726, 275);
            this.buttonDeleteQuestion1.Name = "buttonDeleteQuestion1";
            this.buttonDeleteQuestion1.Size = new System.Drawing.Size(50, 50);
            this.buttonDeleteQuestion1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonDeleteQuestion1.TabIndex = 32;
            this.buttonDeleteQuestion1.TabStop = false;
            this.buttonDeleteQuestion1.Tag = "1";
            // 
            // buttonDeleteQuestion1Answer2
            // 
            this.buttonDeleteQuestion1Answer2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDeleteQuestion1Answer2.Image = global::QuizApp.Properties.Resources.delete_icon;
            this.buttonDeleteQuestion1Answer2.Location = new System.Drawing.Point(595, 211);
            this.buttonDeleteQuestion1Answer2.Name = "buttonDeleteQuestion1Answer2";
            this.buttonDeleteQuestion1Answer2.Size = new System.Drawing.Size(27, 29);
            this.buttonDeleteQuestion1Answer2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonDeleteQuestion1Answer2.TabIndex = 31;
            this.buttonDeleteQuestion1Answer2.TabStop = false;
            this.buttonDeleteQuestion1Answer2.Tag = "1-2";
            // 
            // buttonDeleteQuestion1Answer1
            // 
            this.buttonDeleteQuestion1Answer1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDeleteQuestion1Answer1.Image = global::QuizApp.Properties.Resources.delete_icon;
            this.buttonDeleteQuestion1Answer1.Location = new System.Drawing.Point(595, 179);
            this.buttonDeleteQuestion1Answer1.Name = "buttonDeleteQuestion1Answer1";
            this.buttonDeleteQuestion1Answer1.Size = new System.Drawing.Size(27, 29);
            this.buttonDeleteQuestion1Answer1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonDeleteQuestion1Answer1.TabIndex = 30;
            this.buttonDeleteQuestion1Answer1.TabStop = false;
            this.buttonDeleteQuestion1Answer1.Tag = "1-2";
            // 
            // buttonQuestion1AddAnswer
            // 
            this.buttonQuestion1AddAnswer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonQuestion1AddAnswer.Image = global::QuizApp.Properties.Resources.add_2_icon;
            this.buttonQuestion1AddAnswer.Location = new System.Drawing.Point(47, 243);
            this.buttonQuestion1AddAnswer.Name = "buttonQuestion1AddAnswer";
            this.buttonQuestion1AddAnswer.Size = new System.Drawing.Size(27, 29);
            this.buttonQuestion1AddAnswer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.buttonQuestion1AddAnswer.TabIndex = 29;
            this.buttonQuestion1AddAnswer.TabStop = false;
            this.buttonQuestion1AddAnswer.Tag = "1";
            // 
            // textBoxQuestion1Answer2
            // 
            this.textBoxQuestion1Answer2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(7)))), ((int)(((byte)(24)))));
            this.textBoxQuestion1Answer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxQuestion1Answer2.Font = new System.Drawing.Font("Roboto Light", 12.75F);
            this.textBoxQuestion1Answer2.ForeColor = System.Drawing.Color.White;
            this.textBoxQuestion1Answer2.Location = new System.Drawing.Point(83, 212);
            this.textBoxQuestion1Answer2.MaxLength = 150;
            this.textBoxQuestion1Answer2.Name = "textBoxQuestion1Answer2";
            this.textBoxQuestion1Answer2.Size = new System.Drawing.Size(506, 28);
            this.textBoxQuestion1Answer2.TabIndex = 28;
            this.textBoxQuestion1Answer2.Tag = "1-2";
            // 
            // checkBoxQuestion1Answer2
            // 
            this.checkBoxQuestion1Answer2.Font = new System.Drawing.Font("Roboto Thin", 12.75F);
            this.checkBoxQuestion1Answer2.Location = new System.Drawing.Point(43, 214);
            this.checkBoxQuestion1Answer2.Name = "checkBoxQuestion1Answer2";
            this.checkBoxQuestion1Answer2.Size = new System.Drawing.Size(44, 24);
            this.checkBoxQuestion1Answer2.TabIndex = 27;
            this.checkBoxQuestion1Answer2.Tag = "1-2";
            this.checkBoxQuestion1Answer2.Text = "2: ";
            this.checkBoxQuestion1Answer2.UseVisualStyleBackColor = true;
            // 
            // textBoxQuestion1Answer1
            // 
            this.textBoxQuestion1Answer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(7)))), ((int)(((byte)(24)))));
            this.textBoxQuestion1Answer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxQuestion1Answer1.Font = new System.Drawing.Font("Roboto Light", 12.75F);
            this.textBoxQuestion1Answer1.ForeColor = System.Drawing.Color.White;
            this.textBoxQuestion1Answer1.Location = new System.Drawing.Point(83, 180);
            this.textBoxQuestion1Answer1.MaxLength = 150;
            this.textBoxQuestion1Answer1.Name = "textBoxQuestion1Answer1";
            this.textBoxQuestion1Answer1.Size = new System.Drawing.Size(506, 28);
            this.textBoxQuestion1Answer1.TabIndex = 26;
            this.textBoxQuestion1Answer1.Tag = "1-1";
            // 
            // checkBoxQuestion1Answer1
            // 
            this.checkBoxQuestion1Answer1.Font = new System.Drawing.Font("Roboto Thin", 12.75F);
            this.checkBoxQuestion1Answer1.Location = new System.Drawing.Point(43, 182);
            this.checkBoxQuestion1Answer1.Name = "checkBoxQuestion1Answer1";
            this.checkBoxQuestion1Answer1.Size = new System.Drawing.Size(44, 24);
            this.checkBoxQuestion1Answer1.TabIndex = 25;
            this.checkBoxQuestion1Answer1.Tag = "1-1";
            this.checkBoxQuestion1Answer1.Text = "1: ";
            this.checkBoxQuestion1Answer1.UseVisualStyleBackColor = true;
            // 
            // textBoxQuestion1
            // 
            this.textBoxQuestion1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(7)))), ((int)(((byte)(24)))));
            this.textBoxQuestion1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxQuestion1.Font = new System.Drawing.Font("Roboto Light", 13.75F);
            this.textBoxQuestion1.ForeColor = System.Drawing.Color.White;
            this.textBoxQuestion1.Location = new System.Drawing.Point(31, 147);
            this.textBoxQuestion1.MaxLength = 150;
            this.textBoxQuestion1.Name = "textBoxQuestion1";
            this.textBoxQuestion1.Size = new System.Drawing.Size(692, 30);
            this.textBoxQuestion1.TabIndex = 23;
            this.textBoxQuestion1.Tag = "1";
            // 
            // textBoxTestName
            // 
            this.textBoxTestName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(7)))), ((int)(((byte)(24)))));
            this.textBoxTestName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxTestName.Font = new System.Drawing.Font("Roboto Light", 15.75F);
            this.textBoxTestName.ForeColor = System.Drawing.Color.White;
            this.textBoxTestName.Location = new System.Drawing.Point(35, 60);
            this.textBoxTestName.MaxLength = 150;
            this.textBoxTestName.Name = "textBoxTestName";
            this.textBoxTestName.Size = new System.Drawing.Size(782, 33);
            this.textBoxTestName.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Roboto Light", 16.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(30, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 36);
            this.label1.TabIndex = 19;
            this.label1.Text = "Название теста (150 символов): ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBoxAddQuestion
            // 
            this.pictureBoxAddQuestion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxAddQuestion.Image = global::QuizApp.Properties.Resources.add_2_icon;
            this.pictureBoxAddQuestion.Location = new System.Drawing.Point(399, 436);
            this.pictureBoxAddQuestion.Name = "pictureBoxAddQuestion";
            this.pictureBoxAddQuestion.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxAddQuestion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAddQuestion.TabIndex = 21;
            this.pictureBoxAddQuestion.TabStop = false;
            // 
            // buttonCreate
            // 
            this.buttonCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreate.Font = new System.Drawing.Font("Roboto", 15.75F);
            this.buttonCreate.ForeColor = System.Drawing.Color.White;
            this.buttonCreate.Location = new System.Drawing.Point(300, 426);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(254, 38);
            this.buttonCreate.TabIndex = 20;
            this.buttonCreate.Text = "Создать тест";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // TestCreatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(861, 470);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.panelTest);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Roboto Thin", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TestCreatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CreateTestForm";
            this.panelTest.ResumeLayout(false);
            this.panelTest.PerformLayout();
            this.groupBoxQuestion1.ResumeLayout(false);
            this.groupBoxQuestion1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonAddAttachment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonDeleteQuestion1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonDeleteQuestion1Answer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonDeleteQuestion1Answer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonQuestion1AddAnswer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAddQuestion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelTest;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTestName;
        private System.Windows.Forms.PictureBox pictureBoxAddQuestion;
        private System.Windows.Forms.GroupBox groupBoxQuestion1;
        private System.Windows.Forms.CheckBox checkBoxQuestion1Answer1;
        private System.Windows.Forms.TextBox textBoxQuestion1;
        private System.Windows.Forms.TextBox textBoxQuestion1Answer1;
        private System.Windows.Forms.TextBox textBoxQuestion1Answer2;
        private System.Windows.Forms.CheckBox checkBoxQuestion1Answer2;
        private System.Windows.Forms.PictureBox buttonQuestion1AddAnswer;
        private System.Windows.Forms.PictureBox buttonDeleteQuestion1Answer1;
        private System.Windows.Forms.PictureBox buttonDeleteQuestion1;
        private System.Windows.Forms.PictureBox buttonDeleteQuestion1Answer2;
        private System.Windows.Forms.PictureBox buttonAddAttachment;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}