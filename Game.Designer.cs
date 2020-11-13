namespace Simple_Game
{
    partial class SimpleGameForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picDisplay = new System.Windows.Forms.PictureBox();
            this.Load_button = new System.Windows.Forms.Button();
            this.spin_button = new System.Windows.Forms.Button();
            this.shoot_on_head_button = new System.Windows.Forms.Button();
            this.shoot_away_button = new System.Windows.Forms.Button();
            this.play_again_button = new System.Windows.Forms.Button();
            this.Exit_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // picDisplay
            // 
            this.picDisplay.Location = new System.Drawing.Point(317, 36);
            this.picDisplay.Name = "picDisplay";
            this.picDisplay.Size = new System.Drawing.Size(234, 152);
            this.picDisplay.TabIndex = 0;
            this.picDisplay.TabStop = false;
            // 
            // Load_button
            // 
            this.Load_button.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Load_button.Location = new System.Drawing.Point(257, 214);
            this.Load_button.Name = "Load_button";
            this.Load_button.Size = new System.Drawing.Size(112, 44);
            this.Load_button.TabIndex = 1;
            this.Load_button.Text = "Load";
            this.Load_button.UseVisualStyleBackColor = false;
            this.Load_button.Click += new System.EventHandler(this.Load_button_Click);
            // 
            // spin_button
            // 
            this.spin_button.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.spin_button.Location = new System.Drawing.Point(439, 214);
            this.spin_button.Name = "spin_button";
            this.spin_button.Size = new System.Drawing.Size(112, 44);
            this.spin_button.TabIndex = 2;
            this.spin_button.Text = "Spin";
            this.spin_button.UseVisualStyleBackColor = false;
            this.spin_button.Click += new System.EventHandler(this.spin_button_Click);
            // 
            // shoot_on_head_button
            // 
            this.shoot_on_head_button.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.shoot_on_head_button.Location = new System.Drawing.Point(257, 277);
            this.shoot_on_head_button.Name = "shoot_on_head_button";
            this.shoot_on_head_button.Size = new System.Drawing.Size(112, 44);
            this.shoot_on_head_button.TabIndex = 3;
            this.shoot_on_head_button.Text = "Shoot on head";
            this.shoot_on_head_button.UseVisualStyleBackColor = false;
            this.shoot_on_head_button.Click += new System.EventHandler(this.shoot_on_head_button_Click);
            // 
            // shoot_away_button
            // 
            this.shoot_away_button.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.shoot_away_button.Location = new System.Drawing.Point(439, 275);
            this.shoot_away_button.Name = "shoot_away_button";
            this.shoot_away_button.Size = new System.Drawing.Size(112, 46);
            this.shoot_away_button.TabIndex = 4;
            this.shoot_away_button.Text = "Shoot away";
            this.shoot_away_button.UseVisualStyleBackColor = false;
            this.shoot_away_button.Click += new System.EventHandler(this.shoot_away_button_Click);
            // 
            // play_again_button
            // 
            this.play_again_button.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.play_again_button.Location = new System.Drawing.Point(676, 392);
            this.play_again_button.Name = "play_again_button";
            this.play_again_button.Size = new System.Drawing.Size(112, 46);
            this.play_again_button.TabIndex = 5;
            this.play_again_button.Text = "Play again";
            this.play_again_button.UseVisualStyleBackColor = false;
            this.play_again_button.Click += new System.EventHandler(this.playagain_button);
            // 
            // Exit_button
            // 
            this.Exit_button.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Exit_button.Location = new System.Drawing.Point(12, 392);
            this.Exit_button.Name = "Exit_button";
            this.Exit_button.Size = new System.Drawing.Size(112, 46);
            this.Exit_button.TabIndex = 6;
            this.Exit_button.Text = "Exit";
            this.Exit_button.UseVisualStyleBackColor = false;
            this.Exit_button.Click += new System.EventHandler(this.Exit_button_Click);
            // 
            // SimpleGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Simple_Game.Properties.Resources.force;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Exit_button);
            this.Controls.Add(this.play_again_button);
            this.Controls.Add(this.shoot_away_button);
            this.Controls.Add(this.shoot_on_head_button);
            this.Controls.Add(this.spin_button);
            this.Controls.Add(this.Load_button);
            this.Controls.Add(this.picDisplay);
            this.Name = "SimpleGameForm";
            this.Text = "Simple game";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picDisplay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picDisplay;
        private System.Windows.Forms.Button Load_button;
        private System.Windows.Forms.Button spin_button;
        private System.Windows.Forms.Button shoot_on_head_button;
        private System.Windows.Forms.Button shoot_away_button;
        private System.Windows.Forms.Button play_again_button;
        private System.Windows.Forms.Button Exit_button;
    }
}

