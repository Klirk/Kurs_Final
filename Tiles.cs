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
                switch (value)
                {
                    case 0:
                        tile.BackColor = Color.Gray;
                        numbers.Text = "";
                        this.value = value;
                        break;
                    case 2:
                        tile.BackColor = Color.LightGray;
                        this.value = value;
                        break;
                    case 4:
                        tile.BackColor = Color.Yellow;
                        this.value = value;
                        break;
                    case 8:
                        tile.BackColor = Color.LightYellow;
                        this.value = value;
                        break;
                    case 16:
                        tile.BackColor = Color.LightPink;
                        this.value = value;
                        break;
                    case 32:
                        tile.BackColor = Color.DeepPink;
                        this.value = value;
                        break;
                    case 64:
                        tile.BackColor = Color.LightGreen;
                        this.value = value;
                        break;
                    case 128:
                        tile.BackColor = Color.Green;
                        this.value = value;
                        break;
                    case 256:
                        tile.BackColor = Color.LightBlue;
                        this.value = value;
                        break;
                    case 512:
                        tile.BackColor = Color.Blue;
                        this.value = value;
                        break;
                    case 1024:
                        tile.BackColor = Color.Coral;
                        this.value = value;
                        break;
                    case 2048:
                        tile.BackColor = Color.Red;
                        this.value = value;
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