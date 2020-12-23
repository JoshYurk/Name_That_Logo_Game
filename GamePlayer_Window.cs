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

        public void ClearImage()
        {
            playerLogoPictureBox.Image = null;
        }

        public void LoadImage(Image image)
        {
            playerLogoPictureBox.Image = image;
        }

        public void LoadImage(string imageUrl)
        {
            playerLogoPictureBox.Load(imageUrl);
        }
    }
}
