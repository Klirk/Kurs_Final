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
    abstract class Score
    {
        public int score;
        public Score(int _score) 
        {
            score = _score;
        }
        public abstract void PrintScore();
    }
    class CurrentScore : Score
    {
        public CurrentScore(int _score) : base(_score)
        {
        }
        public override void PrintScore()
        {
            MessageBox.Show("Game over!\nScore: " + score);
        }

    }
    class BestScore : Score
    {
        private int BestScr;
        public BestScore(int bestsc, int _score) : base(_score)
        {
            BestScr = bestsc;
        }
        public override void PrintScore()
        {
            CurrentScore current = new CurrentScore(score);
            current.PrintScore();
            MessageBox.Show("Score: " + score + "\nBest Score: " + BestScr);
        }
    }
}
