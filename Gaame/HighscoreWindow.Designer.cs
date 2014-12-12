namespace Gaame
{
    partial class HighscoreWindow
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.buttonHSClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackgroundImage = global::Gaame.Properties.Resources.BG_Blue_pic1;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Font = new System.Drawing.Font("Buxton Sketch", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(309, 311);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // buttonHSClose
            // 
            this.buttonHSClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHSClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHSClose.Image = global::Gaame.Properties.Resources.bttn_Close;
            this.buttonHSClose.Location = new System.Drawing.Point(105, 254);
            this.buttonHSClose.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonHSClose.Name = "buttonHSClose";
            this.buttonHSClose.Size = new System.Drawing.Size(108, 23);
            this.buttonHSClose.TabIndex = 1;
            this.buttonHSClose.UseVisualStyleBackColor = true;
            this.buttonHSClose.Click += new System.EventHandler(this.button1_Click);
            // 
            // HighscoreWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(309, 311);
            this.ControlBox = false;
            this.Controls.Add(this.buttonHSClose);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HighscoreWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Highscore";
            this.Load += new System.EventHandler(this.HighscoreWindow_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button buttonHSClose;
    }
}