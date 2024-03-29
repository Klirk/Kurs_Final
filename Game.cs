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
    public partial class Game : Form
    {
        
        public Game()
        {
            InitializeComponent();
            Icon = Tetris.Properties.Resources.Icon;
            map = new Map(this);
            
        }
        Map map;
        private void Game_Load(object sender, EventArgs e)
        {
            this.KeyDown += new KeyEventHandler(KeyBoardEvent_);
            map.GenTiles(this);
            map.GenNewTile();
            map.GenNewTile();
        }

        private void KeyBoardEvent_(object sender, KeyEventArgs e)
        {
            map.Move(e);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

}
