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
            ((System.ComponentModel.ISupportInitialize)character).BeginInit();
            ((System.ComponentModel.ISupportInitialize)obstacle).BeginInit();
            SuspendLayout();
            // 
            // character
            // 
            character.Image = (Image)resources.GetObject("character.Image");
            character.Location = new Point(186, 394);
            character.Name = "character";
            character.Size = new Size(98, 102);
            character.SizeMode = PictureBoxSizeMode.StretchImage;
            character.TabIndex = 0;
            character.TabStop = false;
            // 
            // obstacle
            // 
            obstacle.Location = new Point(557, 434);
            obstacle.Name = "obstacle";
            obstacle.Size = new Size(125, 62);
            obstacle.SizeMode = PictureBoxSizeMode.Zoom;
            obstacle.TabIndex = 1;
            obstacle.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(obstacle);
            Controls.Add(character);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)character).EndInit();
            ((System.ComponentModel.ISupportInitialize)obstacle).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox character;
        private PictureBox obstacle;
        private System.Windows.Forms.Timer timer;
    }
}