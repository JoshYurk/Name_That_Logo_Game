using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Name_That_Logo_Game
{
    public partial class GameMaster_Window : Form
    {
        private static GamePlayer_Window playerWindow;
        int imageIndex = 0;

        List<Image> images;
        private static Form prompt;
        private static ListBox screenSelectListBox;
        private static Screen playerScreen;
        private static Button confirmation;

        public GameMaster_Window()
        {
            InitializeComponent();
        }

        private void GameMaster_Window_Load(object sender, EventArgs e)
        {
            images = new List<Image>();
            playerWindow = new GamePlayer_Window();
        }

        private static void SetFormLocation(Form form, Screen screen)
        {
            Rectangle bounds = screen.Bounds;
            form.SetBounds(bounds.X, bounds.Y, bounds.Width, bounds.Height);

            form.TopMost = true;
            form.FormBorderStyle = FormBorderStyle.None;
            form.WindowState = FormWindowState.Maximized;
        }

        private void SelectImageButton_Click(object sender, EventArgs e)
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
                nextImageButton.Enabled = true;
                previousImageButton.Enabled = true;
                sendImageToPlayerWindow.Enabled = true;
            }
        }

        private void NextImageButton_Click(object sender, EventArgs e)
        {
            imageIndex++;
            if (imageIndex >= images.Count)
            {
                imageIndex = 0;
            }

            imagePictureSlider.Image = images.ElementAt(imageIndex);
        }

        private void PreviousImageButton_Click(object sender, EventArgs e)
        {
            imageIndex--;
            if (imageIndex < 0)
            {
                imageIndex = images.Count;
            }

            imagePictureSlider.Image = images.ElementAt(imageIndex);
        }

        private void SendImageToPlayerWindowButton_Click(object sender, EventArgs e)
        {
            Image image = images.ElementAt(imageIndex);
            playerWindow.LoadImage(image);
        }

        private void MaximizePlayerScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            playerWindow.TopMost = true;
            playerWindow.FormBorderStyle = FormBorderStyle.None;
            playerWindow.WindowState = FormWindowState.Maximized;
        }

        private void MinimizePlayerScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            playerWindow.TopMost = false;
            playerWindow.FormBorderStyle = FormBorderStyle.None;
            playerWindow.WindowState = FormWindowState.Minimized;
        }

        private void ResetPlayerScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            playerWindow.TopMost = false;
            playerWindow.FormBorderStyle = FormBorderStyle.Sizable;
            playerWindow.WindowState = FormWindowState.Normal;
            playerWindow.ControlBox = true;
        }

        private void ClearPlayerImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            playerWindow.LoadImage(null);
        }

        public static void ShowDialog(string caption)
        {
            prompt = new Form
            {
                Width = 475,
                Height = 200,
                Text = caption,
                SizeGripStyle = SizeGripStyle.Hide
            };
            screenSelectListBox = new ListBox() { Top = 10, Height = 100, Width = 400 } ;

            foreach (var screen in Screen.AllScreens)
            {
                int index = Array.IndexOf(Screen.AllScreens, screen) + 1;
                string device_name = screen.DeviceName;
                bool isPrimary = screen.Primary;

                var item = index + ") " + device_name + (isPrimary ? " - Primary Screen" : "");

                screenSelectListBox.Items.Add(item);
            }

            screenSelectListBox.SelectedIndexChanged += ListBox_SelectedIndexChanged;
            confirmation = new Button() { Text = "Ok", Left = 250, Width = 100, Top = 130 };
            confirmation.Click += Confirmation_Click;
            confirmation.Enabled = false;
            Button cancel = new Button() { Text = "Cancel", Left = 350, Width = 100, Top = 130 };
            cancel.Click += Cancel_Click;
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(cancel);
            prompt.Controls.Add(screenSelectListBox);
            prompt.ShowDialog();
        }

        private static void ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            playerScreen = Screen.AllScreens[screenSelectListBox.SelectedIndex];
            confirmation.Enabled = true;
        }

        private static void Cancel_Click(object sender, EventArgs e)
        {
            prompt.Close();
        }

        private static void Confirmation_Click(object sender, EventArgs e)
        {
            SetFormLocation(playerWindow, playerScreen);
            playerWindow.Show();
        }

        private void InitializePlayerScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowDialog("Screen Select");
        }
    }
}
