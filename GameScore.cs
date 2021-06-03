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
    abstract class GameScore
    {
        public Label label = new Label();
        public int score = 0;
        public GameScore(int _score)
        {
            label.Font = new Font("Times new Romans", 13, FontStyle.Bold);
            label.Size = new Size(250, 30);
            score = _score;
        }
        public abstract int PrintScore();
        public abstract int Score { get; set; }
    }
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
