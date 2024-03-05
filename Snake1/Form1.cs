using System.Security.AccessControl;

namespace Snake1
{
    public partial class Form1 : Form
    {
        private List<Circle> Snake = new List<Circle>();
        private Circle food = new Circle();

        int maxwidth;
        int maxheight;

        int score;
        int highscore;

        Random rand = new Random();

        bool goLeft, goRight, goUp, goDown;

        public Form1()
        {
            InitializeComponent();

            new Settings();
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left && Settings.directions!="right")
            {
                goLeft = true;
            }
            if(e.KeyCode == Keys.Right && Settings.directions!="left") { 
                goRight = true;
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {

        }

        private void StartGame(object sender, EventArgs e)
        {

        }

        private void TakeSnapShot(object sender, EventArgs e)
        {

        }

        private void GameTimerEvent(object sender, EventArgs e)
        {

        }

        private void UpdatePictureBoxGraphics(object sender, PaintEventArgs e)
        {

        }
        
        private void RestartGame()
        {

        }
        private void EatFood()
        {

        }
        private void GameOver()
        {

        }
    }
}
