namespace CardDeckRevamp
{
    partial class EnterName
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
            this.playButton = new System.Windows.Forms.Button();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.nameOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.White;
            this.playButton.Location = new System.Drawing.Point(190, 228);
            this.playButton.Name = "playButton";
            this.playButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.playButton.Size = new System.Drawing.Size(155, 65);
            this.playButton.TabIndex = 0;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(190, 167);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(160, 22);
            this.nameInput.TabIndex = 1;
            // 
            // nameOutput
            // 
            this.nameOutput.AutoSize = true;
            this.nameOutput.ForeColor = System.Drawing.Color.White;
            this.nameOutput.Location = new System.Drawing.Point(196, 86);
            this.nameOutput.Name = "nameOutput";
            this.nameOutput.Size = new System.Drawing.Size(137, 16);
            this.nameOutput.TabIndex = 2;
            this.nameOutput.Text = "Enter Username Here";
            // 
            // EnterName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.Controls.Add(this.nameOutput);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.playButton);
            this.Name = "EnterName";
            this.Size = new System.Drawing.Size(621, 425);
            this.Load += new System.EventHandler(this.EnterName_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.Label nameOutput;
    }
}
