using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Name_That_Logo_Game
{
    public partial class GamePlayer_Window : Form
    {
        public GamePlayer_Window()
        {
            InitializeComponent();
        }

        public void LoadImage(Image image)
        {
            playerLogoPictureBox.Image = image;
        }
    }
}
