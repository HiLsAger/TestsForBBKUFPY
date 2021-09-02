
namespace TestsForBBKUFPY
{
    partial class MainMenu
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
            this.CreateTest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CreateTest
            // 
            this.CreateTest.Location = new System.Drawing.Point(76, 171);
            this.CreateTest.Name = "CreateTest";
            this.CreateTest.Size = new System.Drawing.Size(172, 102);
            this.CreateTest.TabIndex = 0;
            this.CreateTest.Text = "Создать тест";
            this.CreateTest.UseVisualStyleBackColor = true;
            this.CreateTest.Click += new System.EventHandler(this.CreateTest_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 450);
            this.Controls.Add(this.CreateTest);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Тесты офлайн";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CreateTest;
    }
}

