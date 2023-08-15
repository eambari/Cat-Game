using System;
using System.Drawing;
namespace T_Rex
{
    public partial class Form1 : Form
    {
        private const int FormWidth = 800;
        private const int FormHeight = 400;
        private const int GroundHeight = 50;
        private const int ObstacleSize = 30;
        private const int JumpHeight = 100;
        private const int ObstacleSpeed = 5;
        private const int TimerInterval = 10;

        private bool isJumping;
        private int jumpHeightRemaining;
        public Form1()
        {
            InitializeComponent();
            Width = FormWidth;
            Height = FormHeight;

            //character.Size = new Size(CharacterSize, CharacterSize);
            character.Location = new Point(100, Height - GroundHeight - character.Image.Height);
            Controls.Add(character);

            obstacle.BackColor = Color.Red;
            obstacle.Size = new Size(ObstacleSize, ObstacleSize);
            obstacle.Location = new Point(Width, Height - 50 - ObstacleSize);
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
            } else if (e.KeyCode == Keys.Space && isJumping)
            {
                
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (isJumping)
            {
                character.ImageLocation = @"C:\Users\Endrit\source\repos\T-Rex\T-Rex\Recources\cat_jumping.png";
                character.Top -= 5;
                jumpHeightRemaining -= 5;

                if (jumpHeightRemaining <= 0)
                {
                    isJumping = false;
                    character.ImageLocation = @"C:\Users\Endrit\source\repos\T-Rex\T-Rex\Recources\Domestic cat shape free vector icons designed by Freepik.png";
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
                obstacle.Left = Width;
            }

            if (character.Bounds.IntersectsWith(obstacle.Bounds))
            {
                timer.Stop();
                MessageBox.Show("Game Over!");
            }
        }
    }
}

