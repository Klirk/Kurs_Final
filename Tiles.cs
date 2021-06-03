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
    class Tiles
    {

        Label numbers = new Label();
        PictureBox tile = new PictureBox();
        private int value = 0;

        public int Value
        {

            get
            {
                return value;
            }
            set
            {
                numbers.Text = value.ToString();
                this.value = value;
                switch (value)
                {
                    case 0:
                        tile.BackColor = Color.Gray;
                        numbers.Text = "";
                        
                        break;
                    case 2:
                        tile.BackColor = Color.LightGray;
                        break;
                    case 4:
                        tile.BackColor = Color.Yellow;
                        break;
                    case 8:
                        tile.BackColor = Color.LightYellow;
                        break;
                    case 16:
                        tile.BackColor = Color.LightPink;
                        break;
                    case 32:
                        tile.BackColor = Color.DeepPink;
                        break;
                    case 64:
                        tile.BackColor = Color.LightGreen;
                        break;
                    case 128:
                        tile.BackColor = Color.Green;
                        break;
                    case 256:
                        tile.BackColor = Color.LightBlue;
                        break;
                    case 512:
                        tile.BackColor = Color.Blue;
                        break;
                    case 1024:
                        tile.BackColor = Color.Coral;
                        break;
                    case 2048:
                        tile.BackColor = Color.Red;
                        break;
                }
            }
        }
        public Tiles(Form Game, int a, int b)
        {


            numbers = new Label();
            numbers.AutoSize = false;
            numbers.TextAlign = ContentAlignment.MiddleCenter;
            numbers.Text = "2";
            numbers.ForeColor = Color.Black;
            numbers.Font = new Font("Times New Romans", 15);
            numbers.Size = new Size(70, 70);
            tile = new PictureBox();
            tile.Controls.Add(numbers);
            tile.BackColor = Color.Yellow;
            tile.Size = new Size(70, 70);
            tile.Location = new Point(a, b);
            Game.Controls.Add(tile);
            tile.BringToFront();
            Value = 0;
        }
    }
}