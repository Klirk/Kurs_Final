﻿using System;
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
    class Map
    {
        Label label1 = new Label();
        private Tiles[,] tile = new Tiles[4, 4];
        private CurrentScore score;
        private BestScore best;
        public Map(Form form)
        {


            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    PictureBox _map = new PictureBox();
                    _map.Location = new Point(15 + 80 * j, 80 + 80 * i);
                    _map.BackColor = Color.Gray;
                    _map.Size = new Size(70, 70);
                    form.Controls.Add(_map);
                }
            }
            score = new CurrentScore(0, form);
            best = new BestScore(0,0, form);
        }
        public void GenTiles(Form form)
        {
            for (int i = 0; i < 4; i++)
            {


                for (int j = 0; j < 4; j++)
                {
                    tile[i, j] = new Tiles(form, 15 + 80 * j, 80 + 80 * i);
                }
            }
        }
        public void GenNewTile()
        {
            Random random = new Random();
            int a = random.Next(0, 4);
            int b = random.Next(0, 4);
            double c = random.NextDouble();
            while (tile[a, b].Value != 0)
            {
                a = random.Next(0, 4);
                b = random.Next(0, 4);
            }
            if (c < 0.9)
            {
                tile[a, b].Value = 2;
            }
            else
            {
                tile[a, b].Value = 4;
            }
        }
        public void Move(KeyEventArgs e)
        {
            int Lable;
            int x = 1;
            bool Check = false;
            switch (e.KeyCode.ToString())
            {
                case "Right":
                case "D":
                    for (int i = 0; i < 4; i++)
                    {
                        x = 1;
                        Lable = 4;
                        for (int j = 2; j >= 0; j--)
                        {

                            if (tile[i, j].Value != 0)
                            {
                                for (int l = j + 1; l < Lable; l++)
                                {

                                    if (tile[i, l].Value == 0)
                                    {
                                        tile[i, l].Value = tile[i, l - 1].Value;
                                        tile[i, l - 1].Value = 0;
                                        Check = true;
                                    }
                                    else
                                    {
                                        int a = tile[i, l - 1].Value;
                                        int b = tile[i, l].Value;
                                        if (a == b)
                                        {
                                            Scr(a);
                                            tile[i, l].Value = a * 2;
                                            tile[i, l - 1].Value = 0;
                                            Lable -= x;
                                            Check = true;
                                            break;
                                        }
                                        else
                                        {
                                            x += 1;
                                        }
                                    }

                                }
                            }
                        }
                    }
                    break;
                case "Left":
                case "A":
                    for (int i = 0; i < 4; i++)
                    {
                        x = 1;
                        Lable = 0;
                        for (int j = 1; j < 4; j++)
                        {

                            if (tile[i, j].Value != 0)
                            {
                                for (int l = j - 1; l >= Lable; l--)
                                {

                                    if (tile[i, l].Value == 0)
                                    {
                                        tile[i, l].Value = tile[i, l + 1].Value;
                                        tile[i, l + 1].Value = 0;
                                        Check = true;
                                    }
                                    else
                                    {
                                        int a = tile[i, l + 1].Value;
                                        int b = tile[i, l].Value;
                                        if (a == b)
                                        {
                                            Scr(a);
                                            tile[i, l].Value = a * 2;
                                            tile[i, l + 1].Value = 0;
                                            Lable += x;
                                            Check = true;
                                            break;
                                        }
                                        else
                                        {
                                            x += 1;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    break;
                case "Up":
                case "W":
                    for (int j = 0; j < 4; j++)
                    {
                        x = 1;
                        Lable = 0;
                        for (int i = 1; i < 4; i++)
                        {

                            if (tile[i, j].Value != 0)
                            {
                                for (int l = i - 1; l >= Lable; l--)
                                {

                                    if (tile[l, j].Value == 0)
                                    {
                                        tile[l, j].Value = tile[l + 1, j].Value;
                                        tile[l + 1, j].Value = 0;
                                        Check = true;
                                    }
                                    else
                                    {
                                        int a = tile[l + 1, j].Value;
                                        int b = tile[l, j].Value;
                                        if (a == b)
                                        {
                                            Scr(a);
                                            tile[l, j].Value = a * 2;
                                            tile[l + 1, j].Value = 0;
                                            Lable += x;
                                            Check = true;
                                            break;
                                        }
                                        else
                                        {
                                            x += 1;
                                        }
                                    }
                                }
                            }
                        }
                    }
                    break;
                case "Down":
                case "S":
                    for (int j = 0; j < 4; j++)
                    {
                        x = 1;
                        Lable = 4;
                        for (int i = 2; i >= 0; i--)
                        {

                            if (tile[i, j].Value != 0)
                            {

                                for (int l = i + 1; l < Lable; l++)
                                {

                                    if (tile[l, j].Value == 0)
                                    {
                                        tile[l, j].Value = tile[l - 1, j].Value;
                                        tile[l - 1, j].Value = 0;
                                        Check = true;
                                    }
                                    else
                                    {
                                        int a = tile[l - 1, j].Value;
                                        int b = tile[l, j].Value;
                                        if (a == b)
                                        {
                                            Scr(a);
                                            tile[l, j].Value = a * 2;
                                            tile[l - 1, j].Value = 0;
                                            Lable -= x;
                                            Check = true;
                                            break;
                                        }
                                        else
                                        {
                                            x += 1;
                                        }
                                    }

                                }
                            }
                        }
                    }
                    break;
                case "F5":
                case "R":
                    Rest();
                    break;
            }
            if (Check == true)
            {
                GenNewTile();
            }
            Lost();

        }

        public void Rest()
        {
            MessageBox.Show("Game Over!\nScore: " + score.PrintScore() + "\nBest score: " + best.PrintScore());
            score.Score = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    tile[i, j].Value = 0;
                }
            }
            GenNewTile();
            GenNewTile();
        }
        public void Scr(int a)
        {
            score.Score += a * 2;
            if (best.Score <= score.Score)
            {
                best.Score = score.Score;
            }
        }
        public void Lost()
        {
            int check = 0;
            int check1 = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (tile[i, j].Value == 0)
                    {
                        check += 1;
                        break;
                    }
                }
            }
            if (check == 0)
            {
                for (int i = 1; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if(tile[i - 1, j].Value == tile[i, j].Value)
                        {
                            check1 += 1;
                        }
                        else if (tile[j, i - 1].Value == tile[j,i].Value)
                        {
                            check1 += 1;
                        }
                    }
                }
                if (check1 == 0)
                {
                    Rest();
                }
            }
           
        }
    }
}



