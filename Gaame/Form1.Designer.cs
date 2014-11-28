namespace Gaame
{
    partial class Form1
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
            this.labelPlayer = new System.Windows.Forms.Label();
            this.labelWon = new System.Windows.Forms.Label();
            this.textBoxPlayerWinner = new System.Windows.Forms.TextBox();
            this.btnPlayAgain = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.labelCongratulations = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelPlayer
            // 
            this.labelPlayer.AutoSize = true;
            this.labelPlayer.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPlayer.Location = new System.Drawing.Point(82, 72);
            this.labelPlayer.Name = "labelPlayer";
            this.labelPlayer.Size = new System.Drawing.Size(58, 19);
            this.labelPlayer.TabIndex = 0;
            this.labelPlayer.Text = "Player";
            this.labelPlayer.Click += new System.EventHandler(this.labelPlayer_Click);
            // 
            // labelWon
            // 
            this.labelWon.AutoSize = true;
            this.labelWon.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWon.Location = new System.Drawing.Point(171, 72);
            this.labelWon.Name = "labelWon";
            this.labelWon.Size = new System.Drawing.Size(81, 19);
            this.labelWon.TabIndex = 1;
            this.labelWon.Text = "has won!";
            // 
            // textBoxPlayerWinner
            // 
            this.textBoxPlayerWinner.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPlayerWinner.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxPlayerWinner.Enabled = false;
            this.textBoxPlayerWinner.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPlayerWinner.Location = new System.Drawing.Point(146, 71);
            this.textBoxPlayerWinner.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPlayerWinner.MaxLength = 200;
            this.textBoxPlayerWinner.Name = "textBoxPlayerWinner";
            this.textBoxPlayerWinner.ReadOnly = true;
            this.textBoxPlayerWinner.Size = new System.Drawing.Size(19, 20);
            this.textBoxPlayerWinner.TabIndex = 2;
            this.textBoxPlayerWinner.Text = "1";
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.Location = new System.Drawing.Point(127, 122);
            this.btnPlayAgain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(88, 32);
            this.btnPlayAgain.TabIndex = 3;
            this.btnPlayAgain.Text = "&Play Again";
            this.btnPlayAgain.UseVisualStyleBackColor = true;
            this.btnPlayAgain.Click += new System.EventHandler(this.btnPlayAgain_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(221, 122);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(88, 32);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // labelCongratulations
            // 
            this.labelCongratulations.AutoSize = true;
            this.labelCongratulations.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCongratulations.Location = new System.Drawing.Point(72, 30);
            this.labelCongratulations.Name = "labelCongratulations";
            this.labelCongratulations.Size = new System.Drawing.Size(205, 29);
            this.labelCongratulations.TabIndex = 5;
            this.labelCongratulations.Text = "Congratulations!";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnPlayAgain;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(400, 215);
            this.ControlBox = false;
            this.Controls.Add(this.labelCongratulations);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPlayAgain);
            this.Controls.Add(this.textBoxPlayerWinner);
            this.Controls.Add(this.labelWon);
            this.Controls.Add(this.labelPlayer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "G3 Memory";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPlayer;
        private System.Windows.Forms.Label labelWon;
        private System.Windows.Forms.TextBox textBoxPlayerWinner;
        private System.Windows.Forms.Button btnPlayAgain;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label labelCongratulations;
    }
}

