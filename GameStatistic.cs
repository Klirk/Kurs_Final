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
    class GameStatistic
    {
        public int Score { get; set; }
        public GameStatistic(int score) 
        {
            Score = score; 
        }
        public virtual void PrintScore()
        { 
            MessageBox.Show("Game Over\nScore: " + Score); 
        }
       

    }
    class BestScore : GameStatistic
    {
        private int BestSc { get; set; }
        public BestScore(int bestsc, int score) : base(score)
        {
            BestSc = bestsc;
        }
        public override void PrintScore()
        {
            MessageBox.Show("Score: " + Score + "\nBest Score: " + BestSc);
        }
    }
}
