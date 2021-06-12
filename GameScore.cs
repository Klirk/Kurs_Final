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
   
}
