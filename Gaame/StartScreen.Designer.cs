﻿namespace Gaame
{
    partial class StartScreen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartScreen));
            this.StartGame = new System.Windows.Forms.Button();
            this.labelPairs = new System.Windows.Forms.Label();
            this.labelTheme = new System.Windows.Forms.Label();
            this.textBoxPairs = new System.Windows.Forms.TextBox();
            this.comboBoxTheme = new System.Windows.Forms.ComboBox();
            this.labelDecks = new System.Windows.Forms.Label();
            this.comboBoxDecks = new System.Windows.Forms.ComboBox();
            this.labelTimer = new System.Windows.Forms.Label();
            this.textBoxTimer = new System.Windows.Forms.TextBox();
            this.AddPlayer = new System.Windows.Forms.Button();
            this.RemovePlayer = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.listView1 = new System.Windows.Forms.ListView();
            this.pictureBoxBanner = new System.Windows.Forms.PictureBox();
            this.comboBoxGameType = new System.Windows.Forms.ComboBox();
            this.labelGameType = new System.Windows.Forms.Label();
            this.checkBoxMusic = new System.Windows.Forms.CheckBox();
            this.checkBoxSFX = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBanner)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // StartGame
            // 
            this.StartGame.BackColor = System.Drawing.Color.Transparent;
            this.StartGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.StartGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartGame.FlatAppearance.BorderSize = 0;
            this.StartGame.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.StartGame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.StartGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartGame.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartGame.ForeColor = System.Drawing.SystemColors.ControlText;
            this.StartGame.Image = global::Gaame.Properties.Resources.bttn_StartGame;
            this.StartGame.Location = new System.Drawing.Point(413, 345);
            this.StartGame.Margin = new System.Windows.Forms.Padding(0);
            this.StartGame.Name = "StartGame";
            this.StartGame.Size = new System.Drawing.Size(160, 54);
            this.StartGame.TabIndex = 0;
            this.StartGame.UseVisualStyleBackColor = false;
            this.StartGame.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelPairs
            // 
            this.labelPairs.AutoSize = true;
            this.labelPairs.BackColor = System.Drawing.Color.Transparent;
            this.labelPairs.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPairs.Location = new System.Drawing.Point(84, 330);
            this.labelPairs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPairs.Name = "labelPairs";
            this.labelPairs.Size = new System.Drawing.Size(169, 24);
            this.labelPairs.TabIndex = 2;
            this.labelPairs.Text = "Number of pairs:";
            // 
            // labelTheme
            // 
            this.labelTheme.AutoSize = true;
            this.labelTheme.BackColor = System.Drawing.Color.Transparent;
            this.labelTheme.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTheme.Location = new System.Drawing.Point(177, 359);
            this.labelTheme.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTheme.Name = "labelTheme";
            this.labelTheme.Size = new System.Drawing.Size(81, 24);
            this.labelTheme.TabIndex = 3;
            this.labelTheme.Text = "Theme:";
            // 
            // textBoxPairs
            // 
            this.textBoxPairs.Location = new System.Drawing.Point(275, 329);
            this.textBoxPairs.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxPairs.MaxLength = 3;
            this.textBoxPairs.Name = "textBoxPairs";
            this.textBoxPairs.Size = new System.Drawing.Size(132, 22);
            this.textBoxPairs.TabIndex = 5;
            this.textBoxPairs.Text = "4";
            this.textBoxPairs.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // comboBoxTheme
            // 
            this.comboBoxTheme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTheme.FormattingEnabled = true;
            this.comboBoxTheme.Items.AddRange(new object[] {
            "Social Icons",
            "Smileys",
            "Flags"});
            this.comboBoxTheme.Location = new System.Drawing.Point(275, 359);
            this.comboBoxTheme.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxTheme.Name = "comboBoxTheme";
            this.comboBoxTheme.Size = new System.Drawing.Size(132, 24);
            this.comboBoxTheme.TabIndex = 6;
            // 
            // labelDecks
            // 
            this.labelDecks.AutoSize = true;
            this.labelDecks.BackColor = System.Drawing.Color.Transparent;
            this.labelDecks.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDecks.Location = new System.Drawing.Point(185, 391);
            this.labelDecks.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDecks.Name = "labelDecks";
            this.labelDecks.Size = new System.Drawing.Size(75, 24);
            this.labelDecks.TabIndex = 7;
            this.labelDecks.Text = "Decks:";
            // 
            // comboBoxDecks
            // 
            this.comboBoxDecks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDecks.FormattingEnabled = true;
            this.comboBoxDecks.Items.AddRange(new object[] {
            "Theme",
            "Gold & Blue",
            "Gold & Grey",
            "Black & Orange",
            "Brown & Beige",
            "Gold & Purple"});
            this.comboBoxDecks.Location = new System.Drawing.Point(275, 391);
            this.comboBoxDecks.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxDecks.Name = "comboBoxDecks";
            this.comboBoxDecks.Size = new System.Drawing.Size(132, 24);
            this.comboBoxDecks.TabIndex = 9;
            // 
            // labelTimer
            // 
            this.labelTimer.AutoSize = true;
            this.labelTimer.BackColor = System.Drawing.Color.Transparent;
            this.labelTimer.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimer.Location = new System.Drawing.Point(117, 455);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(139, 24);
            this.labelTimer.TabIndex = 10;
            this.labelTimer.Text = "Round Timer:";
            // 
            // textBoxTimer
            // 
            this.textBoxTimer.Location = new System.Drawing.Point(275, 457);
            this.textBoxTimer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxTimer.MaxLength = 5;
            this.textBoxTimer.Name = "textBoxTimer";
            this.textBoxTimer.Size = new System.Drawing.Size(132, 22);
            this.textBoxTimer.TabIndex = 11;
            this.textBoxTimer.Text = "20";
            this.textBoxTimer.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // AddPlayer
            // 
            this.AddPlayer.BackColor = System.Drawing.Color.Transparent;
            this.AddPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.AddPlayer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddPlayer.FlatAppearance.BorderSize = 0;
            this.AddPlayer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.AddPlayer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.AddPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddPlayer.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.AddPlayer.ForeColor = System.Drawing.Color.Black;
            this.AddPlayer.Image = global::Gaame.Properties.Resources.bttn_Add;
            this.AddPlayer.Location = new System.Drawing.Point(417, 215);
            this.AddPlayer.Margin = new System.Windows.Forms.Padding(0);
            this.AddPlayer.Name = "AddPlayer";
            this.AddPlayer.Size = new System.Drawing.Size(143, 44);
            this.AddPlayer.TabIndex = 13;
            this.AddPlayer.UseVisualStyleBackColor = false;
            this.AddPlayer.Click += new System.EventHandler(this.button2_Click);
            // 
            // RemovePlayer
            // 
            this.RemovePlayer.BackColor = System.Drawing.Color.Transparent;
            this.RemovePlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.RemovePlayer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RemovePlayer.FlatAppearance.BorderSize = 0;
            this.RemovePlayer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.RemovePlayer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.RemovePlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemovePlayer.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold);
            this.RemovePlayer.Image = global::Gaame.Properties.Resources.bttn_Remove;
            this.RemovePlayer.Location = new System.Drawing.Point(412, 260);
            this.RemovePlayer.Margin = new System.Windows.Forms.Padding(0);
            this.RemovePlayer.Name = "RemovePlayer";
            this.RemovePlayer.Size = new System.Drawing.Size(160, 53);
            this.RemovePlayer.TabIndex = 14;
            this.RemovePlayer.UseVisualStyleBackColor = false;
            this.RemovePlayer.Click += new System.EventHandler(this.button3_Click);
            // 
            // listView1
            // 
            this.listView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(141, 146);
            this.listView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(265, 162);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // pictureBoxBanner
            // 
            this.pictureBoxBanner.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxBanner.Image = global::Gaame.Properties.Resources.Banner_;
            this.pictureBoxBanner.Location = new System.Drawing.Point(59, 4);
            this.pictureBoxBanner.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxBanner.Name = "pictureBoxBanner";
            this.pictureBoxBanner.Size = new System.Drawing.Size(464, 135);
            this.pictureBoxBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxBanner.TabIndex = 15;
            this.pictureBoxBanner.TabStop = false;
            // 
            // comboBoxGameType
            // 
            this.comboBoxGameType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGameType.FormattingEnabled = true;
            this.comboBoxGameType.Items.AddRange(new object[] {
            "Classic",
            "ComboScore"});
            this.comboBoxGameType.Location = new System.Drawing.Point(275, 425);
            this.comboBoxGameType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxGameType.Name = "comboBoxGameType";
            this.comboBoxGameType.Size = new System.Drawing.Size(132, 24);
            this.comboBoxGameType.TabIndex = 16;
            // 
            // labelGameType
            // 
            this.labelGameType.AutoSize = true;
            this.labelGameType.BackColor = System.Drawing.Color.Transparent;
            this.labelGameType.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGameType.Location = new System.Drawing.Point(133, 425);
            this.labelGameType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelGameType.Name = "labelGameType";
            this.labelGameType.Size = new System.Drawing.Size(124, 24);
            this.labelGameType.TabIndex = 17;
            this.labelGameType.Text = "Game Type:";
            // 
            // checkBoxMusic
            // 
            this.checkBoxMusic.AutoSize = true;
            this.checkBoxMusic.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxMusic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxMusic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxMusic.Location = new System.Drawing.Point(16, 458);
            this.checkBoxMusic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxMusic.Name = "checkBoxMusic";
            this.checkBoxMusic.Size = new System.Drawing.Size(71, 21);
            this.checkBoxMusic.TabIndex = 18;
            this.checkBoxMusic.Text = "Music";
            this.checkBoxMusic.UseVisualStyleBackColor = false;
            this.checkBoxMusic.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBoxSFX
            // 
            this.checkBoxSFX.AutoSize = true;
            this.checkBoxSFX.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxSFX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxSFX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxSFX.Location = new System.Drawing.Point(16, 427);
            this.checkBoxSFX.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBoxSFX.Name = "checkBoxSFX";
            this.checkBoxSFX.Size = new System.Drawing.Size(59, 21);
            this.checkBoxSFX.TabIndex = 19;
            this.checkBoxSFX.Text = "SFX";
            this.checkBoxSFX.UseVisualStyleBackColor = false;
            this.checkBoxSFX.CheckedChanged += new System.EventHandler(this.checkBoxSFX_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(453, 432);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 25);
            this.button1.TabIndex = 20;
            this.button1.Text = "Classic";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(453, 455);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(71, 25);
            this.button2.TabIndex = 21;
            this.button2.Text = "Combo";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(432, 416);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "HighScore list";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Gaame.Properties.Resources.icon_arrowR;
            this.pictureBox2.Location = new System.Drawing.Point(436, 436);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(23, 18);
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::Gaame.Properties.Resources.icon_arrowR;
            this.pictureBox3.Location = new System.Drawing.Point(436, 458);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(23, 18);
            this.pictureBox3.TabIndex = 25;
            this.pictureBox3.TabStop = false;
            // 
            // StartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(579, 503);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.checkBoxSFX);
            this.Controls.Add(this.checkBoxMusic);
            this.Controls.Add(this.labelGameType);
            this.Controls.Add(this.comboBoxGameType);
            this.Controls.Add(this.pictureBoxBanner);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.RemovePlayer);
            this.Controls.Add(this.AddPlayer);
            this.Controls.Add(this.textBoxTimer);
            this.Controls.Add(this.labelTimer);
            this.Controls.Add(this.comboBoxDecks);
            this.Controls.Add(this.labelDecks);
            this.Controls.Add(this.comboBoxTheme);
            this.Controls.Add(this.textBoxPairs);
            this.Controls.Add(this.labelTheme);
            this.Controls.Add(this.labelPairs);
            this.Controls.Add(this.StartGame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "StartScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "G3 Memory";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
            this.Load += new System.EventHandler(this.StartScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBanner)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartGame;
        private System.Windows.Forms.Label labelPairs;
        private System.Windows.Forms.Label labelTheme;
        private System.Windows.Forms.TextBox textBoxPairs;
        private System.Windows.Forms.ComboBox comboBoxTheme;
        private System.Windows.Forms.Label labelDecks;
        private System.Windows.Forms.ComboBox comboBoxDecks;
        private System.Windows.Forms.Label labelTimer;
        private System.Windows.Forms.TextBox textBoxTimer;
        private System.Windows.Forms.Button RemovePlayer;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.PictureBox pictureBoxBanner;
        private System.Windows.Forms.ComboBox comboBoxGameType;
        private System.Windows.Forms.Label labelGameType;
        private System.Windows.Forms.CheckBox checkBoxMusic;
        private System.Windows.Forms.CheckBox checkBoxSFX;
        private System.Windows.Forms.Button AddPlayer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

