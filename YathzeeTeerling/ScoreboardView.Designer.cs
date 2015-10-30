namespace YathzeeTeerling
{
    partial class ScoreboardView
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
            this.scoreLabel = new System.Windows.Forms.Label();
            this.highscoreLabel = new System.Windows.Forms.Label();
            this.aantalWorpenLabel = new System.Windows.Forms.Label();
            this.scoreValueLabel = new System.Windows.Forms.Label();
            this.highscoreValueLabel = new System.Windows.Forms.Label();
            this.aantalWorpenValueLabel = new System.Windows.Forms.Label();
            this.maxWorpenLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Location = new System.Drawing.Point(34, 31);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(65, 25);
            this.scoreLabel.TabIndex = 0;
            this.scoreLabel.Text = "score";
            // 
            // highscoreLabel
            // 
            this.highscoreLabel.AutoSize = true;
            this.highscoreLabel.Location = new System.Drawing.Point(34, 86);
            this.highscoreLabel.Name = "highscoreLabel";
            this.highscoreLabel.Size = new System.Drawing.Size(159, 25);
            this.highscoreLabel.TabIndex = 1;
            this.highscoreLabel.Text = "highscoreLabel";
            // 
            // aantalWorpenLabel
            // 
            this.aantalWorpenLabel.AutoSize = true;
            this.aantalWorpenLabel.Location = new System.Drawing.Point(34, 141);
            this.aantalWorpenLabel.Name = "aantalWorpenLabel";
            this.aantalWorpenLabel.Size = new System.Drawing.Size(147, 25);
            this.aantalWorpenLabel.TabIndex = 2;
            this.aantalWorpenLabel.Text = "aantal worpen";
            // 
            // scoreValueLabel
            // 
            this.scoreValueLabel.AutoSize = true;
            this.scoreValueLabel.Location = new System.Drawing.Point(256, 31);
            this.scoreValueLabel.Name = "scoreValueLabel";
            this.scoreValueLabel.Size = new System.Drawing.Size(24, 25);
            this.scoreValueLabel.TabIndex = 3;
            this.scoreValueLabel.Text = "0";
            this.scoreValueLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // highscoreValueLabel
            // 
            this.highscoreValueLabel.AutoSize = true;
            this.highscoreValueLabel.Location = new System.Drawing.Point(256, 86);
            this.highscoreValueLabel.Name = "highscoreValueLabel";
            this.highscoreValueLabel.Size = new System.Drawing.Size(24, 25);
            this.highscoreValueLabel.TabIndex = 4;
            this.highscoreValueLabel.Text = "0";
            // 
            // aantalWorpenValueLabel
            // 
            this.aantalWorpenValueLabel.AutoSize = true;
            this.aantalWorpenValueLabel.Location = new System.Drawing.Point(256, 141);
            this.aantalWorpenValueLabel.Name = "aantalWorpenValueLabel";
            this.aantalWorpenValueLabel.Size = new System.Drawing.Size(24, 25);
            this.aantalWorpenValueLabel.TabIndex = 5;
            this.aantalWorpenValueLabel.Text = "0";
            // 
            // maxWorpenLabel
            // 
            this.maxWorpenLabel.AutoSize = true;
            this.maxWorpenLabel.Location = new System.Drawing.Point(276, 141);
            this.maxWorpenLabel.Name = "maxWorpenLabel";
            this.maxWorpenLabel.Size = new System.Drawing.Size(36, 25);
            this.maxWorpenLabel.TabIndex = 6;
            this.maxWorpenLabel.Text = "/ 3";
            // 
            // ScoreboardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.maxWorpenLabel);
            this.Controls.Add(this.aantalWorpenValueLabel);
            this.Controls.Add(this.highscoreValueLabel);
            this.Controls.Add(this.scoreValueLabel);
            this.Controls.Add(this.aantalWorpenLabel);
            this.Controls.Add(this.highscoreLabel);
            this.Controls.Add(this.scoreLabel);
            this.Name = "ScoreboardView";
            this.Size = new System.Drawing.Size(428, 381);
            this.Load += new System.EventHandler(this.ScoreboardView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label highscoreLabel;
        private System.Windows.Forms.Label aantalWorpenLabel;
        private System.Windows.Forms.Label scoreValueLabel;
        private System.Windows.Forms.Label highscoreValueLabel;
        private System.Windows.Forms.Label aantalWorpenValueLabel;
        private System.Windows.Forms.Label maxWorpenLabel;
    }
}
