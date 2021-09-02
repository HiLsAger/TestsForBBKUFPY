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
    public partial class Final : Form
    {
        public Final()
        {
            InitializeComponent();
        }

        private void Final_Load(object sender, EventArgs e)
        {
            label1.Text = "Ваш счёт: " + Convert.ToString(Info.success+1) + " из " + Convert.ToString(Info.__answers.Count); //установка счётчика
        }

        private void inMenu_Click(object sender, EventArgs e)
        {
            Form mm = new MainMenu();
            mm.Show();
            Info.Clear();
            this.Close();
        }
    }
}
