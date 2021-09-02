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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void CreateTest_Click(object sender, EventArgs e)
        {
            Form creator = new CreateTests();
            creator.Show();
            this.Hide();
        }
    }
}
