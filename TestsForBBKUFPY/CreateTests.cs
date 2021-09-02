using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestsForBBKUFPY
{
    public partial class CreateTests : Form
    {
        public CreateTests()
        {
            InitializeComponent();
        }
        List<string> questions = new List<string>();
        List<string> answers = new List<string>();
        int time;
        private void CreateTests_Load(object sender, EventArgs e)
        {
            
        }

        private void AddQuest_Click(object sender, EventArgs e) 
        {
            if (Quest.Text != "")
            {
                if (rbTrue.Checked || rbFalse.Checked)
                {
                    questions.Add(Quest.Text);
                    if (rbTrue.Checked) answers.Add("Да");
                    else answers.Add("Нет");
                    ListBoxQuestions.Items.Add(Convert.ToString(questions.Count() + "." + questions[questions.Count - 1]));
                }
                else
                {
                    MessageBox.Show("Выберете вариант ответа", "Ошибка!");
                }
            }
            else
            {
                MessageBox.Show("Заполните поле с вопросом", "Ошибка!");
            }
        }

        private void StartTest_Click(object sender, EventArgs e) 
        {
            if (int.TryParse(times.Text, out int num))
            {
                if (questions.Count >= 1)
                {
                    time = Convert.ToInt32(times.Text);
                    Form solution = new TestSolution();
                    Info.__questions = questions;
                    Info.__answers = answers;
                    Info.__time = time;
                    solution.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Добавьте хотя бы один вопрос", "Ошибка!");
                }
            }
            else
            {
                MessageBox.Show("Проверьте поле со временем", "Ошибка!");
            }
        }
    }
}
