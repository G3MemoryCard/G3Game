namespace Gaame
{
    partial class EndScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EndScreen));
            this.btnPlayAgain = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnScrBoard = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelWinningPlayer = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.BackColor = System.Drawing.Color.Transparent;
            this.btnPlayAgain.BackgroundImage = global::Gaame.Properties.Resources.bttn_playAgain;
            this.btnPlayAgain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPlayAgain.FlatAppearance.BorderSize = 0;
            this.btnPlayAgain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayAgain.ForeColor = System.Drawing.Color.Transparent;
            this.btnPlayAgain.Location = new System.Drawing.Point(79, 142);
            this.btnPlayAgain.Margin = new System.Windows.Forms.Padding(0);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(106, 37);
            this.btnPlayAgain.TabIndex = 3;
            this.btnPlayAgain.UseVisualStyleBackColor = false;
            this.btnPlayAgain.Click += new System.EventHandler(this.btnPlayAgain_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = global::Gaame.Properties.Resources.bttn_Exit;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(192, 142);
            this.btnExit.Margin = new System.Windows.Forms.Padding(0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(107, 37);
            this.btnExit.TabIndex = 4;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnScrBoard
            // 
            this.btnScrBoard.BackgroundImage = global::Gaame.Properties.Resources.bttn_Scoreboard;
            this.btnScrBoard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnScrBoard.FlatAppearance.BorderSize = 0;
            this.btnScrBoard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScrBoard.Location = new System.Drawing.Point(192, 187);
            this.btnScrBoard.Margin = new System.Windows.Forms.Padding(0);
            this.btnScrBoard.Name = "btnScrBoard";
            this.btnScrBoard.Size = new System.Drawing.Size(107, 37);
            this.btnScrBoard.TabIndex = 7;
            this.btnScrBoard.UseVisualStyleBackColor = true;
            this.btnScrBoard.Click += new System.EventHandler(this.btnScrBoard_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Gaame.Properties.Resources.Banner_Congrats;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(48, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(285, 75);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // labelWinningPlayer
            // 
            this.labelWinningPlayer.BackColor = System.Drawing.Color.Transparent;
            this.labelWinningPlayer.Font = new System.Drawing.Font("Buxton Sketch", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWinningPlayer.Location = new System.Drawing.Point(1, 95);
            this.labelWinningPlayer.Name = "labelWinningPlayer";
            this.labelWinningPlayer.Size = new System.Drawing.Size(380, 46);
            this.labelWinningPlayer.TabIndex = 9;
            this.labelWinningPlayer.Text = "WinningPlayer";
            this.labelWinningPlayer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::Gaame.Properties.Resources.bttn_Highscore;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(79, 187);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 37);
            this.button1.TabIndex = 10;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EndScreen
            // 
            this.AcceptButton = this.btnPlayAgain;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(384, 231);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelWinningPlayer);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnScrBoard);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPlayAgain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EndScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "G3 Memory";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPlayAgain;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnScrBoard;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelWinningPlayer;
        private System.Windows.Forms.Button button1;
    }
}

