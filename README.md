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
        private const int ObstacleSize = 120;
        private const int JumpHeight = 100;
        private const int ObstacleSpeed = 5;
        private const int TimerInterval = 10;
These constants define various properties of the game, such as the dimensions of the form, ground height, obstacle size, jump height, obstacle speed, and timer interval.

        // Fields for game elements and state
        private int maxScore = 0;
        private string[] ObstacleImages = {
            // Paths to obstacle image files
        };
        private bool isJumping;
        private int jumpHeightRemaining;
        private Random random;
These fields store information about the game's state, including the maximum score achieved, paths to obstacle image files, flags indicating whether the character is jumping, the remaining jump height, and a Random instance for generating random numbers.

        public Form1()
        {
            InitializeComponent();
            random = new Random();
            Initializer();
        }
The constructor of Form1 class initializes the form, sets up the random number generator, and calls the Initializer() method to set up the initial state of the game.

        public void Initializer()
        {
            Width = FormWidth;
            Height = FormHeight;

            // Set up character
            character.Location = new Point(100, Height - GroundHeight - character.Image.Height);
            Controls.Add(character);

            // Set up obstacle
            obstacle.ImageLocation = ObstacleImages[0];
            obstacle.SizeMode = PictureBoxSizeMode.Zoom;
            obstacle.Location = new Point(Width, Height - 60 - ObstacleSize);
            Controls.Add(obstacle);

            // Set up timer
            timer = new System.Windows.Forms.Timer();
            timer.Interval = TimerInterval;
            timer.Tick += Timer_Tick;
            timer.Start();

            KeyDown += MainForm_KeyDown;
        }
The Initializer() method sets up the initial state of the game. It configures the form dimensions, sets up the character and obstacle positions, initializes a timer for game updates, and attaches event handlers for keyboard input.

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && !isJumping)
            {
                isJumping = true;
                jumpHeightRemaining = JumpHeight;
            }
            else if (jumpHeightRemaining > 250)
            {
                // Additional logic for extended jump height
            }
        }
This method handles the KeyDown event, which is triggered when a key is pressed. If the spacebar is pressed and the character is not already jumping, it initiates a jump. Additionally, there is an empty conditional block that seems to be reserved for extending the jump height.

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Update score
            score.Text = (Convert.ToInt32(score.Text) + 1).ToString();

            if (isJumping)
            {
                // Logic for character jumping
            }
            else
            {
                // Logic for character falling
            }

            // Update obstacle position
            obstacle.Left -= ObstacleSpeed;

            // Logic for handling obstacle movement and resetting
            if (obstacle.Right < 0)
            {
                // Logic for resetting obstacle
            }

            // Logic for collision detection and game over
            if (character.Bounds.IntersectsWith(obstacle.Bounds))
            {
                // Logic for game over and restarting
            }
          }
        }
      }
The Timer_Tick method is the core of the game loop, which updates the game state on each timer tick. It increments the score, updates the character's position based on jumping and falling states, moves the obstacle, checks for obstacle reset and collision with the character, and handles game over scenarios.
