using System;
using System.Drawing;
namespace T_Rex
{
    public partial class Form1 : Form
    {
        private const int FormWidth = 800;
        private const int FormHeight = 450;
        private const int GroundHeight = 72;
        private const int ObstacleSize = 120;
        private const int JumpHeight = 100;
        private const int ObstacleSpeed = 5;
        private const int TimerInterval = 10;
        private int maxScore = 0;
        private string[] ObstacleImages = {
            @"C:\Users\Endrit\source\repos\T-Rex\T-Rex\Recources\smallBush.png",
            @"C:\Users\Endrit\source\repos\T-Rex\T-Rex\Recources\bigBush.png"
        };
        private bool isJumping;
        private int jumpHeightRemaining;
        private Random random;
        public Form1()
        {
            InitializeComponent();
            random = new Random();
            Initializer();
        }
        public void Initializer()
        {
            Width = FormWidth;
            Height = FormHeight;

            //character.Size = new Size(CharacterSize, CharacterSize);
            character.Location = new Point(100, Height - GroundHeight - character.Image.Height);
            Controls.Add(character);

            obstacle.ImageLocation = ObstacleImages[0];
            //obstacle.Size = new Size(ObstacleSize, ObstacleSize);
            obstacle.SizeMode = PictureBoxSizeMode.Zoom;
            obstacle.Location = new Point(Width, Height - 60 - ObstacleSize);
            Controls.Add(obstacle);

            timer = new System.Windows.Forms.Timer();
            timer.Interval = TimerInterval;
            timer.Tick += Timer_Tick;
            timer.Start();

            KeyDown += MainForm_KeyDown;
        }
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && !isJumping)
            {
                isJumping = true;
                jumpHeightRemaining = JumpHeight;
            }
            else if (jumpHeightRemaining > 250)
            {

            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            score.Text = (Convert.ToInt32(score.Text) + 1).ToString();
            if (isJumping)
            {
                character.ImageLocation = @"C:\Users\Endrit\source\repos\T-Rex\T-Rex\Recources\cat_jumping.png";
                character.Top -= 5;
                jumpHeightRemaining -= 5;

                if (jumpHeightRemaining <= 0)
                {
                    isJumping = false;
                    character.ImageLocation = @"C:\Users\Endrit\source\repos\T-Rex\T-Rex\Recources\cat.png";
                }
            }
            else
            {
                if (character.Bottom < Height - GroundHeight)
                {
                    character.Top += 5;
                }
            }

            obstacle.Left -= ObstacleSpeed;

            if (obstacle.Right < 0)
            {
                int listNumber = random.Next(0, 2);
                if(listNumber == 0)
                {
                    obstacle.Location = new Point(Width, Height - 60 - ObstacleSize);
                } else
                {
                    obstacle.Location = new Point(Width, Height - 90 - ObstacleSize);
                }
                obstacle.ImageLocation = ObstacleImages[listNumber];
                obstacle.Left = Width;
            }

            if (character.Bounds.IntersectsWith(obstacle.Bounds))
            {
                timer.Stop();
                maxScore = Math.Max(maxScore, Convert.ToInt32(score.Text));
                DialogResult result = MessageBox.Show($"Game over!\nYour Score: {score.Text}\nMax Score: {maxScore}\nDo you want to play a new game?", "Game Over", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    Application.Exit();
                }
                else
                {
                    score.Text = "0";
                    Initializer();
                }
            }
        }
    }
}

