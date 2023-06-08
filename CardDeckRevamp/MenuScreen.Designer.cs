namespace CardDeckRevamp
{
    partial class MenuScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.exitButton = new System.Windows.Forms.Button();
            this.leaderButton = new System.Windows.Forms.Button();
            this.playButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(100, 297);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(355, 30);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // leaderButton
            // 
            this.leaderButton.Location = new System.Drawing.Point(100, 243);
            this.leaderButton.Name = "leaderButton";
            this.leaderButton.Size = new System.Drawing.Size(355, 39);
            this.leaderButton.TabIndex = 4;
            this.leaderButton.Text = "Leaderboard";
            this.leaderButton.UseVisualStyleBackColor = true;
            this.leaderButton.Click += new System.EventHandler(this.leaderButton_Click);
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(100, 192);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(355, 42);
            this.playButton.TabIndex = 3;
            this.playButton.Text = "Play ";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // MenuScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.leaderButton);
            this.Controls.Add(this.playButton);
            this.Name = "MenuScreen";
            this.Size = new System.Drawing.Size(535, 569);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button leaderButton;
        private System.Windows.Forms.Button playButton;
    }
}
