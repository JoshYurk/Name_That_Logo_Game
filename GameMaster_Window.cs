using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Name_That_Logo_Game
{
    public partial class GameMaster_Window : Form
    {
        private static Button confirmation;
        private static Screen playerScreen;
        private static List<GamePlayer_Window> player_Windows;
        private static List<Screen> usedScreens;
        private static Form prompt;
        private static ListBox screenSelectListBox;
        int imageIndex = 0;
        private List<string> imageList;
        List<Image> images;
        private ImageSearchWindow imageSearchWindow;
        private bool playerWindowInitialized = false;

        public GameMaster_Window()
        {
            InitializeComponent();
        }

        public void ShowScreenSelectDialog(string caption)
        {
            prompt = new Form
            {
                Width = 475,
                Height = 200,
                Text = caption,
                SizeGripStyle = SizeGripStyle.Hide
            };
            screenSelectListBox = new ListBox() { Top = 10, Height = 100, Width = 400 };

            foreach (var screen in Screen.AllScreens)
            {
                if (!usedScreens.Contains(screen))
                {
                    int index = Array.IndexOf(Screen.AllScreens, screen) + 1;
                    string device_name = screen.DeviceName;
                    bool isPrimary = screen.Primary;

                    var item = index + ") " + device_name + (isPrimary ? " - Primary Screen" : "");

                    screenSelectListBox.Items.Add(item);
                }
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

        private static void Cancel_Click(object sender, EventArgs e)
        {
            prompt.Close();
        }

        private void Confirmation_Click(object sender, EventArgs e)
        {
            var playerWindow = new GamePlayer_Window();
            SetFormLocation(playerWindow, playerScreen);
            playerWindow.Show();

            playerWindow.Shown += PlayerWindow_Shown;
            usedScreens.Add(playerScreen);
            player_Windows.Add(playerWindow);
        }

        private static void ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (screenSelectListBox.SelectedIndex > -1)
            {
                playerScreen = Screen.AllScreens[screenSelectListBox.SelectedIndex];
                confirmation.Enabled = true;
            }
        }

        private static void SetFormLocation(Form form, Screen screen)
        {
            Rectangle bounds = screen.Bounds;
            form.SetBounds(bounds.X, bounds.Y, bounds.Width, bounds.Height);

            form.TopMost = true;
            form.FormBorderStyle = FormBorderStyle.None;
            form.WindowState = FormWindowState.Maximized;
        }

        private void ClearPlayerImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (GamePlayer_Window player_Window in player_Windows)
            {
                player_Window.ClearImage();
            }
        }

        private void GameMaster_Window_Load(object sender, EventArgs e)
        {
            imageList = new List<string>();
            images = new List<Image>();
            player_Windows = new List<GamePlayer_Window>();
            usedScreens = new List<Screen>();
        }

        private void PlayerWindow_Shown(object sender, EventArgs e)
        {
            playerWindowInitialized = true;

            maximizePlayerScreenToolStripMenuItem.Enabled = true;
            minimizePlayerScreenToolStripMenuItem.Enabled = true;
            resetPlayerScreenToolStripMenuItem.Enabled = true;
            clearPlayerImageToolStripMenuItem.Enabled = true;

            if (usedScreens.Count == Screen.AllScreens.Length)
            {
                initializePlayerScreenToolStripMenuItem.Enabled = false;
            }

            if (imageList.Count > 0 || images.Count > 0)
            {
                sendImageToPlayerWindow.Enabled = true;
            }
        }

        private void InitializePlayerScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowScreenSelectDialog("Screen Select");
        }

        private void MaximizePlayerScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (GamePlayer_Window playerWindow in player_Windows)
            {
                playerWindow.TopMost = true;
                playerWindow.FormBorderStyle = FormBorderStyle.None;
                playerWindow.WindowState = FormWindowState.Maximized;
            }
        }

        private void MinimizePlayerScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (GamePlayer_Window playerWindow in player_Windows)
            {
                playerWindow.TopMost = false;
                playerWindow.FormBorderStyle = FormBorderStyle.None;
                playerWindow.WindowState = FormWindowState.Minimized;
            }
        }

        private void NextImageButton_Click(object sender, EventArgs e)
        {
            imageIndex++;
            if (images.Count > 0)
            {
                if (imageIndex >= images.Count)
                {
                    imageIndex = 0;
                }

                imagePictureSlider.Image = images.ElementAt(imageIndex);
            }
            else if (imageList.Count > 0)
            {
                if (imageIndex >= imageList.Count)
                {
                    imageIndex = 0;
                }

                imagePictureSlider.Load(imageList[imageIndex]);
            }

            pictureCountLabel.Text = "Picture " + (imageIndex + 1) + "/" + imageList.Count;
        }

        private void PreviousImageButton_Click(object sender, EventArgs e)
        {
            imageIndex--;
            if (images.Count > 0)
            {
                if (imageIndex < 0)
                {
                    imageIndex = images.Count;
                }

                imagePictureSlider.Image = images.ElementAt(imageIndex);
            }
            else if (imageList.Count > 0)
            {
                if (imageIndex < 0)
                {
                    imageIndex = imageList.Count - 1;
                }

                imagePictureSlider.Load(imageList[imageIndex]);
            }

            pictureCountLabel.Text = "Picture " + (imageIndex + 1) + "/" + imageList.Count;
        }

        private void ResetPlayerScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (GamePlayer_Window playerWindow in player_Windows)
            {
                playerWindow.TopMost = false;
                playerWindow.FormBorderStyle = FormBorderStyle.Sizable;
                playerWindow.WindowState = FormWindowState.Normal;
                playerWindow.ControlBox = true;
            }
        }

        private void RetieveSearchedImagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imageList.Clear();
            imageList.AddRange(imageSearchWindow.RetrieveImages());
            imagePictureSlider.Load(imageList[0]);
            nextImageButton.Enabled = true;
            previousImageButton.Enabled = true;
            sendImageToPlayerWindow.Enabled = playerWindowInitialized;
            pictureCountLabel.Text = "Picture 1/" + imageList.Count;
        }

        private void SearchForImagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imageSearchWindow = new ImageSearchWindow();
            imageSearchWindow.Show();
            retieveSearchedImagesToolStripMenuItem.Enabled = true;
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
                sendImageToPlayerWindow.Enabled = playerWindowInitialized;
            }
        }

        private void SendImageToPlayerWindowButton_Click(object sender, EventArgs e)
        {
            foreach (GamePlayer_Window playerWindow in player_Windows)
            {
                if (images.Count > 0)
                {
                    Image image = images.ElementAt(imageIndex);
                    playerWindow.LoadImage(image);
                }
                else if (imageList.Count > 0)
                {
                    playerWindow.LoadImage(imageList[imageIndex]);
                }
            }
        }
    }
}
