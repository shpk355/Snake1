using System.Security.AccessControl;
using System.Xml;

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
            if(e.KeyCode == Keys.Up && Settings.directions != "down")
            {
                goUp = true;
            }
            if(e.KeyCode == Keys.Down && Settings.directions != "up")
            {
                goDown = true;
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }
        }

        private void StartGame(object sender, EventArgs e)
        {
            RestartGame();
        }

        private void TakeSnapShot(object sender, EventArgs e)
        {

        }

        private void GameTimerEvent(object sender, EventArgs e)
        {
            if (goLeft)
            {
                Settings.directions = "left";
            }
            if (goRight)
            {
                Settings.directions = "right";
            }
            if (goDown)
            {
                Settings.directions = "down";
            }
            if (goUp)
            {
                Settings.directions = "up";
            }

            for(int i = Snake.Count; i >= 0; i--)
            {
                if (i == 0)
                {
                    switch(Settings.directions)
                    {
                        case "left":
                            Snake[i].X--;
                            break;
                        case "right":
                            Snake[i].X++;
                            break;
                        case "up":
                            Snake[i].Y--;
                            break;
                        case "down":
                            Snake[i].Y++;
                            break;

                    }
                }
            }
        }

        private void UpdatePictureBoxGraphics(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;
            Brush snakeColour;

            for(int i = 0; i < Snake.Count; i++)
            {
                if(i == 0)
                {
                    snakeColour = Brushes.Green;
                }
                else
                {
                    snakeColour = Brushes.Yellow;
                }

                canvas.FillRectangle(snakeColour, new Rectangle
                    (
                        Snake[i].X = Settings.Width,
                        Snake[i].Y = Settings.Height,
                        Settings.Width, Settings.Height
                    )
                    );



            }
            canvas.FillEllipse(Brushes.DarkRed, new Rectangle(food.X = Settings.Width,
                        food.Y = Settings.Height,
                        Settings.Width, Settings.Height
                    )
                    );
        }

        private void RestartGame()
        {
            maxwidth = pictureBox1.Width / Settings.Width - 1;
            maxheight = pictureBox1.Height / Settings.Height - 1;

            Snake.Clear();
            button1.Enabled = false;
            button2.Enabled = false;
            score = 0;
            label1.Text = "Score " + score;

            Circle Head = new Circle{X = 10, Y = 5};
            Snake.Add(Head);

            for(int i = 0; i < 10; i++)
            {
                Circle Body = new Circle { };
                Snake.Add(Body);
            }

            food = new Circle { X = rand.Next(2, maxwidth), Y  = rand.Next(2, maxheight)};

            gametimer.Start();

        }

        private void EatFood()
        {

        }
        private void GameOver()
        {

        }
    }
}
