﻿namespace CardDeckRevamp
{
    partial class GameOverScreen
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
            this.backButton = new System.Windows.Forms.Button();
            this.overLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(239, 253);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(122, 45);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "Return to Main Screen";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // overLabel
            // 
            this.overLabel.AutoSize = true;
            this.overLabel.ForeColor = System.Drawing.Color.White;
            this.overLabel.Location = new System.Drawing.Point(193, 121);
            this.overLabel.Name = "overLabel";
            this.overLabel.Size = new System.Drawing.Size(87, 16);
            this.overLabel.TabIndex = 1;
            this.overLabel.Text = "GAME OVER";
            // 
            // GameOverScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.Controls.Add(this.overLabel);
            this.Controls.Add(this.backButton);
            this.Name = "GameOverScreen";
            this.Size = new System.Drawing.Size(594, 564);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label overLabel;
    }
}
