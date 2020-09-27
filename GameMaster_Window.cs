using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Name_That_Logo_Game
{
    public partial class GameMaster_Window : Form
    {
        GamePlayer_Window playerWindow;
        int imageIndex = 0;
        List<Image> images;

        public GameMaster_Window()
        {
            InitializeComponent();
        }

        private void GameMaster_Window_Load(object sender, EventArgs e)
        {
            images = new List<Image>();
            var screens = Screen.AllScreens;
            playerWindow = new GamePlayer_Window();
            setFormLocation(playerWindow, screens[1]);
            playerWindow.Show();
        }

        private void setFormLocation(Form form, Screen screen)
        {
            Rectangle bounds = screen.Bounds;
            form.SetBounds(bounds.X, bounds.Y, bounds.Width, bounds.Height);

            form.TopMost = true;
            form.FormBorderStyle = FormBorderStyle.None;
            form.WindowState = FormWindowState.Maximized;
        }

        private void selectImageButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowReadOnly = true;
            openFileDialog1.Multiselect = true;
            openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                foreach (string file in openFileDialog1.FileNames)
                {
                    Image loadedImage = Image.FromFile(file);

                    images.Add(loadedImage);
                }

                imagePictureSlider.Image = images.ElementAt(imageIndex);
            }
        }

        private void nextImageButton_Click(object sender, EventArgs e)
        {
            imageIndex++;
            if (imageIndex >= images.Count)
            {
                imageIndex = 0;
            }

            imagePictureSlider.Image = images.ElementAt(imageIndex);
        }

        private void previousImageButton_Click(object sender, EventArgs e)
        {
            imageIndex--;
            if (imageIndex < 0)
            {
                imageIndex = images.Count;
            }

            imagePictureSlider.Image = images.ElementAt(imageIndex);
        }

        private void sendImageToPlayerWindowButton_Click(object sender, EventArgs e)
        {
            Image image = images.ElementAt(imageIndex);
            playerWindow.LoadImage(image);            
        }

        private void maximizePlayerScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            playerWindow.TopMost = true;
            playerWindow.FormBorderStyle = FormBorderStyle.None;
            playerWindow.WindowState = FormWindowState.Maximized;
        }

        private void minimizePlayerScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            playerWindow.TopMost = false;
            playerWindow.FormBorderStyle = FormBorderStyle.None;
            playerWindow.WindowState = FormWindowState.Minimized;
        }

        private void resetPlayerScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            playerWindow.TopMost = false;
            playerWindow.FormBorderStyle = FormBorderStyle.Sizable;
            playerWindow.WindowState = FormWindowState.Normal;
            playerWindow.ControlBox = true;
        }

        private void clearPlayerImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            playerWindow.LoadImage(null);
        }
    }
}
