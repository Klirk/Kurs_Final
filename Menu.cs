using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kurs_Final
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Game game = new Game();
            game.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Курсовая работа, студента pz-19-1d", "Game 2048");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
