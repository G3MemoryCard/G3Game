namespace Gaame
{
    partial class AddPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPlayer));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.checkBoxAI = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAPAdd = new System.Windows.Forms.Button();
            this.buttonAPCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // checkBoxAI
            // 
            this.checkBoxAI.AutoSize = true;
            this.checkBoxAI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxAI.Location = new System.Drawing.Point(118, 46);
            this.checkBoxAI.Name = "checkBoxAI";
            this.checkBoxAI.Size = new System.Drawing.Size(15, 14);
            this.checkBoxAI.TabIndex = 1;
            this.checkBoxAI.UseVisualStyleBackColor = true;
            this.checkBoxAI.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(152, 42);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // buttonAPAdd
            // 
            this.buttonAPAdd.BackColor = System.Drawing.Color.Transparent;
            this.buttonAPAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAPAdd.FlatAppearance.BorderSize = 0;
            this.buttonAPAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonAPAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonAPAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAPAdd.Image = global::Gaame.Properties.Resources.bttn_Add;
            this.buttonAPAdd.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonAPAdd.Location = new System.Drawing.Point(34, 82);
            this.buttonAPAdd.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAPAdd.Name = "buttonAPAdd";
            this.buttonAPAdd.Size = new System.Drawing.Size(118, 48);
            this.buttonAPAdd.TabIndex = 4;
            this.buttonAPAdd.UseVisualStyleBackColor = false;
            this.buttonAPAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonAPCancel
            // 
            this.buttonAPCancel.BackColor = System.Drawing.Color.Transparent;
            this.buttonAPCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAPCancel.FlatAppearance.BorderSize = 0;
            this.buttonAPCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonAPCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonAPCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAPCancel.ForeColor = System.Drawing.Color.Transparent;
            this.buttonAPCancel.Image = global::Gaame.Properties.Resources.bttn_Cancel;
            this.buttonAPCancel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.buttonAPCancel.Location = new System.Drawing.Point(152, 82);
            this.buttonAPCancel.Margin = new System.Windows.Forms.Padding(0);
            this.buttonAPCancel.Name = "buttonAPCancel";
            this.buttonAPCancel.Size = new System.Drawing.Size(117, 45);
            this.buttonAPCancel.TabIndex = 5;
            this.buttonAPCancel.UseVisualStyleBackColor = false;
            this.buttonAPCancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(116, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "AI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(149, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Skill";
            // 
            // AddPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(297, 139);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonAPCancel);
            this.Controls.Add(this.buttonAPAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.checkBoxAI);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddPlayer";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddPlayer";
            this.Load += new System.EventHandler(this.AddPlayer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBoxAI;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAPAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonAPCancel;
    }
}