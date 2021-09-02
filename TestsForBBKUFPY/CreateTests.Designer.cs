
namespace TestsForBBKUFPY
{
    partial class CreateTests
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
            this.times = new System.Windows.Forms.TextBox();
            this.Quest = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rbTrue = new System.Windows.Forms.RadioButton();
            this.rbFalse = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.AddQuest = new System.Windows.Forms.Button();
            this.ListBoxQuestions = new System.Windows.Forms.ListBox();
            this.StartTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // times
            // 
            this.times.Location = new System.Drawing.Point(122, 38);
            this.times.Name = "times";
            this.times.Size = new System.Drawing.Size(120, 20);
            this.times.TabIndex = 0;
            // 
            // Quest
            // 
            this.Quest.Location = new System.Drawing.Point(62, 12);
            this.Quest.Name = "Quest";
            this.Quest.Size = new System.Drawing.Size(180, 20);
            this.Quest.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Время(в секундах):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Вопрос:";
            // 
            // rbTrue
            // 
            this.rbTrue.AutoSize = true;
            this.rbTrue.Location = new System.Drawing.Point(62, 69);
            this.rbTrue.Name = "rbTrue";
            this.rbTrue.Size = new System.Drawing.Size(40, 17);
            this.rbTrue.TabIndex = 4;
            this.rbTrue.TabStop = true;
            this.rbTrue.Text = "Да";
            this.rbTrue.UseVisualStyleBackColor = true;
            // 
            // rbFalse
            // 
            this.rbFalse.AutoSize = true;
            this.rbFalse.Location = new System.Drawing.Point(62, 102);
            this.rbFalse.Name = "rbFalse";
            this.rbFalse.Size = new System.Drawing.Size(44, 17);
            this.rbFalse.TabIndex = 5;
            this.rbFalse.TabStop = true;
            this.rbFalse.Text = "Нет";
            this.rbFalse.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ответ:";
            // 
            // AddQuest
            // 
            this.AddQuest.Location = new System.Drawing.Point(12, 125);
            this.AddQuest.Name = "AddQuest";
            this.AddQuest.Size = new System.Drawing.Size(104, 23);
            this.AddQuest.TabIndex = 7;
            this.AddQuest.Text = "добавить вопрос";
            this.AddQuest.UseVisualStyleBackColor = true;
            this.AddQuest.Click += new System.EventHandler(this.AddQuest_Click);
            // 
            // ListBoxQuestions
            // 
            this.ListBoxQuestions.FormattingEnabled = true;
            this.ListBoxQuestions.Location = new System.Drawing.Point(12, 154);
            this.ListBoxQuestions.Name = "ListBoxQuestions";
            this.ListBoxQuestions.Size = new System.Drawing.Size(259, 290);
            this.ListBoxQuestions.TabIndex = 8;
            // 
            // StartTest
            // 
            this.StartTest.Location = new System.Drawing.Point(167, 125);
            this.StartTest.Name = "StartTest";
            this.StartTest.Size = new System.Drawing.Size(104, 23);
            this.StartTest.TabIndex = 9;
            this.StartTest.Text = "пройти тест";
            this.StartTest.UseVisualStyleBackColor = true;
            this.StartTest.Click += new System.EventHandler(this.StartTest_Click);
            // 
            // CreateTests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 450);
            this.Controls.Add(this.StartTest);
            this.Controls.Add(this.ListBoxQuestions);
            this.Controls.Add(this.AddQuest);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rbFalse);
            this.Controls.Add(this.rbTrue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Quest);
            this.Controls.Add(this.times);
            this.Name = "CreateTests";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Тесты офлайн";
            this.Load += new System.EventHandler(this.CreateTests_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox times;
        private System.Windows.Forms.TextBox Quest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbTrue;
        private System.Windows.Forms.RadioButton rbFalse;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button AddQuest;
        private System.Windows.Forms.ListBox ListBoxQuestions;
        private System.Windows.Forms.Button StartTest;
    }
}