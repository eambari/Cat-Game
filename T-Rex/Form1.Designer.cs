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
            timer = new System.Windows.Forms.Timer(components);
            label = new Label();
            score = new Label();
            ((System.ComponentModel.ISupportInitialize)character).BeginInit();
            SuspendLayout();
            // 
            // character
            // 
            character.BackColor = Color.Transparent;
            character.Image = (Image)resources.GetObject("character.Image");
            character.Location = new Point(185, 402);
            character.Name = "character";
            character.Size = new Size(98, 101);
            character.SizeMode = PictureBoxSizeMode.StretchImage;
            character.TabIndex = 0;
            character.TabStop = false;
            // 
            // label
            // 
            label.AutoSize = true;
            label.BackColor = Color.Transparent;
            label.Font = new Font("Tempus Sans ITC", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label.ForeColor = Color.White;
            label.Location = new Point(634, 9);
            label.Name = "label";
            label.Size = new Size(64, 24);
            label.TabIndex = 3;
            label.Text = "Score:";
            // 
            // score
            // 
            score.AutoSize = true;
            score.BackColor = Color.Transparent;
            score.Font = new Font("Tempus Sans ITC", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            score.ForeColor = Color.White;
            score.Location = new Point(704, 9);
            score.Name = "score";
            score.Size = new Size(24, 24);
            score.TabIndex = 4;
            score.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(914, 600);
            Controls.Add(score);
            Controls.Add(label);
            Controls.Add(character);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Cat Game";
            ((System.ComponentModel.ISupportInitialize)character).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox character;
        private System.Windows.Forms.Timer timer;
        private Label label;
        private Label score;
    }
}