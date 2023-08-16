# Cat Game

Cat game is a game that is made as Google's T-Rex look-alike by:

Endrit Ambari,

Dorant Tateshi,

Leon Saraqini

The code defines a namespace T_Rex and a class Form1 that extends the Form class. This class represents the main form of the game.

        // Constants for various dimensions and properties
        private const int FormWidth = 800;
        private const int FormHeight = 450;
        private const int GroundHeight = 72;
        private const int JumpHeight = 100;
        private const int ObstacleSpeed = 5;
        private const int TimerInterval = 10;
These constants define various properties of the game, such as the dimensions of the form, ground height, jump height, obstacle speed, and timer interval.

        // Fields for game elements and state
        private int maxScore = 0;
        private string[] ObstacleImages = {
            // Paths to obstacle image files
        };
        private List<PictureBox> Obstacles;
        private bool isJumping;
        private int jumpHeightRemaining;
        private int timerTicks;
        private Random random;
These fields store information about the game's state, including the maximum score achieved, paths to obstacle image files, a list of obstacle PictureBoxes, flags indicating whether the character is jumping, the remaining jump height, timer ticks, and a Random instance for generating random numbers.

        public Form1()
        {
            InitializeComponent();
            random = new Random();
            this.DoubleBuffered = true;
            Initializer();
        }
The constructor of the Form1 class initializes the form, sets up the random number generator, enables double buffering for smoother graphics, and calls the Initializer() method to set up the initial state of the game.

        private void Initializer()
        {
            Width = FormWidth;
            Height = FormHeight;

            // Set up character
            character.Location = new Point(100, Height - GroundHeight - character.Image.Height);
            Controls.Add(character);
            Obstacles = new List<PictureBox>();
            InitializeObstacle();

            // Set up timer
            timer = new Timer();
            timer.Interval = TimerInterval;
            timer.Tick += Timer_Tick;
            timer.Start();

            KeyDown += MainForm_KeyDown;
        }
The Initializer() method sets up the initial state of the game. It configures the form dimensions, sets up the character position, initializes the list of obstacles, sets up the timer for game updates, and attaches an event handler for keyboard input.

        private void InitializeObstacle()
        {
            // Create a new PictureBox to represent the obstacle
            var tmp_obstacle = new PictureBox();

            // Randomly choose an obstacle image from the predefined list
            int listNumber = random.Next(0, 2);

            // Set obstacle location and dimensions based on image type
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

            // Configure obstacle properties
            tmp_obstacle.SizeMode = PictureBoxSizeMode.Zoom;
            tmp_obstacle.BackColor = Color.Transparent;
            tmp_obstacle.ImageLocation = ObstacleImages[listNumber];

            // Add the obstacle to the form's Controls collection and the Obstacles list
            Controls.Add(tmp_obstacle);
            Obstacles.Add(tmp_obstacle);
        }
This method initializes a new obstacle, setting its location, size, image, and adding it to the list of obstacles.

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && !isJumping)
            {
                // Initiate a jump when Spacebar is pressed and not already jumping
                isJumping = true;
                jumpHeightRemaining = JumpHeight;
            }
        }
This method handles the KeyDown event, which is triggered when a key is pressed. It handles the character jumping logic.

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Increment timerTicks to keep track of game time
            timerTicks++;

            // Generate a new obstacle every 910 ms (approximately 91 ticks)
            if (timerTicks % 91 == 0)
            {
                InitializeObstacle();
            }

            // Update the player's score
            score.Text = (Convert.ToInt32(score.Text) + 1).ToString();

            // Handle player movement and jumping mechanics
            if (isJumping)
            {
                // Logic for character jumping
            }
            else
            {
                // Logic for character falling
            }

            // Update obstacle positions and remove off-screen obstacles
            for (int i = 0; i < Obstacles.Count; i++)
            {
                Obstacles[i].Left -= ObstacleSpeed;

                // Remove obstacles that have moved off-screen
                if (Obstacles[i].Right < 0)
                {
                    Obstacles.RemoveAt(i);
                }

                // Detect collision between character and obstacles
                if (character.Bounds.IntersectsWith(Obstacles[i].Bounds))
                {
                    // Stop the game timer
                    timer.Stop();

                    // Update the maximum score
                    maxScore = Math.Max(maxScore, Convert.ToInt32(score.Text));

                    // Display a game over message box
                    DialogResult result = MessageBox.Show($"Game over!\nYour Score: {score.Text}\nMax Score: {maxScore}\nDo you want to play a new game?", "Game Over",                 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    
                    // Handle user choice
                    if (result == DialogResult.No)
                    {
                        // Exit the application
                        Application.Exit();
                    }
                    else
                    {
                        // Reset the score and obstacles, then restart the game
                        score.Text = "0";
                        Obstacles.ForEach((obstacle) =>
                        {
                            Controls.Remove(obstacle);
                        });
                        Initializer();
                    }
                }
            }
        }
The Timer_Tick method is the core of the game loop. It updates the game state on each timer tick, including character movement, obstacle movement, and collision detection.
