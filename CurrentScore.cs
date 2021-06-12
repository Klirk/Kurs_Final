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
    class CurrentScore : GameScore
    {
        public CurrentScore(int _score, Form form) : base(_score)
        {
            label.Location = new Point(12, 9);
            label.Text = "Score: 0";
            form.Controls.Add(label);

        }
        public override int PrintScore()
        {

            return score;

        }
        public override int Score
        {
            get
            {
                return score;
            }
            set
            {
                score = value;
                label.Text = "Score: " + score;
            }
        }
    }
}
