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
    class BestScore : GameScore
    {
        public BestScore(int bestscore, int _score, Form form) : base(_score)
        {
            label.Text = "Best score: 0";
            label.Location = new Point(12 * 2 + 250, 9);
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
                label.Text = "Best score: " + score;
            }
        }
    }
}
