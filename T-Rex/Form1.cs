using System;
using System.Drawing;
namespace T_Rex
{
    public partial class Form1 : Form
    {
        private const int FormWidth = 800;
        private const int FormHeight = 450;
        private const int JumpHeight = 100;
        private const int GroundHeight = 72;
        private const int ObstacleSpeed = 5;
        private const int TimerInterval = 10;
        private int maxScore = 0;
        private string[] ObstacleImages = {
            @"C:\Users\Endrit\source\repos\T-Rex\T-Rex\Recources\smallBush.png",
            @"C:\Users\Endrit\source\repos\T-Rex\T-Rex\Recources\bigBush.png"
        };
        private List<PictureBox> Obstacles;
        private bool isJumping;
        private int jumpHeightRemaining;
        private int timerTicks;
        private Random random;
        public Form1()
        {
            InitializeComponent();
            random = new Random();
            this.DoubleBuffered = true;
            Initializer();
        }
        private void Initializer()
        {
            Width = FormWidth;
            Height = FormHeight;

            character.Location = new Point(100, Height - GroundHeight - character.Image.Height);
            Controls.Add(character);
            Obstacles = new List<PictureBox>();
            InitializeObstacle();
            timer = new System.Windows.Forms.Timer();
            timer.Interval = TimerInterval;
            timer.Tick += Timer_Tick;
            timer.Start();

            KeyDown += MainForm_KeyDown;
        }
        private void InitializeObstacle()
        {
            var tmp_obstacle = new PictureBox();
            int listNumber = random.Next(0, 2);
            if (listNumber == 0)
            {
                tmp_obstacle.Location = new Point(Width, Height - 155);
                tmp_obstacle.Size = new Size(90, 90);
            }
            else
            {
                tmp_obstacle.Location = new Point(Width, Height - 210);
                tmp_obstacle.Size = new Size(70, 150);
            }
            tmp_obstacle.SizeMode = PictureBoxSizeMode.Zoom;
            tmp_obstacle.BackColor = Color.Transparent;
            tmp_obstacle.ImageLocation = ObstacleImages[listNumber];
            Controls.Add(tmp_obstacle);
            Obstacles.Add(tmp_obstacle);
        }
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && !isJumping)
            {
                isJumping = true;
                jumpHeightRemaining = JumpHeight;
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timerTicks++;
            if (timerTicks % 91 == 0)
            {
                InitializeObstacle();
            }
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

            for (int i = 0; i < Obstacles.Count; i++)
            {
                Obstacles[i].Left -= ObstacleSpeed;
                if (Obstacles[i].Right < 0)
                {
                    Obstacles.RemoveAt(i);
                }

                if (character.Bounds.IntersectsWith(Obstacles[i].Bounds))
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
                        Obstacles.ForEach((obstacle) =>
                        {
                            Controls.Remove(obstacle);
                        });
                        Initializer();
                    }
                }
            };
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

