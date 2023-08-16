namespace T_Rex
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            character = new PictureBox();
            obstacle = new PictureBox();
            timer = new System.Windows.Forms.Timer(components);
            label = new Label();
            score = new Label();
            ((System.ComponentModel.ISupportInitialize)character).BeginInit();
            ((System.ComponentModel.ISupportInitialize)obstacle).BeginInit();
            SuspendLayout();
            // 
            // character
            // 
            character.BackColor = Color.Transparent;
            character.Image = (Image)resources.GetObject("character.Image");
            character.Location = new Point(164, 305);
            character.Margin = new Padding(3, 2, 3, 2);
            character.Name = "character";
            character.Size = new Size(86, 76);
            character.SizeMode = PictureBoxSizeMode.StretchImage;
            character.TabIndex = 0;
            character.TabStop = false;
            // 
            // obstacle
            // 
            obstacle.BackColor = Color.Transparent;
            obstacle.Image = (Image)resources.GetObject("obstacle.Image");
            obstacle.Location = new Point(443, 256);
            obstacle.Margin = new Padding(3, 2, 3, 2);
            obstacle.Name = "obstacle";
            obstacle.Size = new Size(49, 125);
            obstacle.SizeMode = PictureBoxSizeMode.Zoom;
            obstacle.TabIndex = 1;
            obstacle.TabStop = false;
            // 
            // label
            // 
            label.AutoSize = true;
            label.BackColor = Color.Transparent;
            label.Font = new Font("Tempus Sans ITC", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label.ForeColor = Color.White;
            label.Location = new Point(555, 7);
            label.Name = "label";
            label.Size = new Size(52, 19);
            label.TabIndex = 3;
            label.Text = "Score:";
            // 
            // score
            // 
            score.AutoSize = true;
            score.BackColor = Color.Transparent;
            score.Font = new Font("Tempus Sans ITC", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            score.ForeColor = Color.White;
            score.Location = new Point(616, 7);
            score.Name = "score";
            score.Size = new Size(20, 19);
            score.TabIndex = 4;
            score.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(score);
            Controls.Add(label);
            Controls.Add(obstacle);
            Controls.Add(character);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)character).EndInit();
            ((System.ComponentModel.ISupportInitialize)obstacle).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox character;
        private PictureBox obstacle;
        private System.Windows.Forms.Timer timer;
        private Label label;
        private Label score;
    }
}