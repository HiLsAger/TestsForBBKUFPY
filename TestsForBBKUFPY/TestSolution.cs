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
    public partial class TestSolution : Form
    {
        public TestSolution()
        {
            InitializeComponent();
        }
        int isTrue;
        int questNum = 0;
        int nowtime;
        private void TestSolution_Load(object sender, EventArgs e)
        {
            progressBar1.Maximum = Info.__questions.Count;
            nowtime = Info.__time;
            quest.Text = Info.__questions[questNum];
            label1.Text = Convert.ToString(Info.__time);
            timer1.Interval = Info.__time * 1000;
            timer1.Start();
            timer2.Start();
            questNum++;
        }

        private void Next_Click(object sender, EventArgs e) //Переключение и анализ ответа
        {
            if(rbTrue.Checked || rbFalse.Checked) //проверка на выюор ответа
            {
                if (questNum <= Info.__questions.Count - 1)
                {
                    if (rbTrue.Checked) if (rbTrue.Text == Info.__answers[questNum])
                    {
                        isTrue++;
                    }
                    if (rbFalse.Checked) if (rbFalse.Text == Info.__answers[questNum])
                    {
                        isTrue++;
                    }
                    progressBar1.Value = questNum;
                    quest.Text = Info.__questions[questNum];
                    //label1.Text = Convert.ToString(isTrue);
                    nowtime = Info.__time;
                    label1.Text = Convert.ToString(nowtime);
                    timer1.Stop();
                    timer1.Start();
                    timer2.Stop();
                    timer2.Start();
                    questNum++;
                }
                else
                {
                    timer1.Stop();
                    timer2.Stop();
                    Info.success = isTrue-1;
                    Form fin = new Final();
                    fin.Show();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Выберете вариант", "Ошибка!");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            questNum++;
            if (questNum <= Info.__questions.Count)
            {
                progressBar1.Value = questNum;
                quest.Text = Info.__questions[questNum];
                nowtime = Info.__time;
                timer2.Stop();
                timer2.Start();
                label1.Text = Convert.ToString(nowtime);
            }
            else
            {
                timer1.Stop();
                timer2.Stop();
                Info.success = isTrue-1;
                Form fin = new Final();
                fin.Show();
                this.Close();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            nowtime -= 1;
            label1.Text = Convert.ToString(nowtime);
        }
    }
}
