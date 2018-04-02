namespace _5_8_Tutorial
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
            this.TailsPictureBox = new System.Windows.Forms.PictureBox();
            this.HeadsPictureBox = new System.Windows.Forms.PictureBox();
            this.TossButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TailsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeadsPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // TailsPictureBox
            // 
            this.TailsPictureBox.Image = global::_5_8_Tutorial.Properties.Resources.coin_tails;
            this.TailsPictureBox.Location = new System.Drawing.Point(248, 1);
            this.TailsPictureBox.Name = "TailsPictureBox";
            this.TailsPictureBox.Size = new System.Drawing.Size(230, 233);
            this.TailsPictureBox.TabIndex = 1;
            this.TailsPictureBox.TabStop = false;
            this.TailsPictureBox.Click += new System.EventHandler(this.TailsPictureBox_Click);
            // 
            // HeadsPictureBox
            // 
            this.HeadsPictureBox.Image = global::_5_8_Tutorial.Properties.Resources.coin_heads;
            this.HeadsPictureBox.Location = new System.Drawing.Point(248, 1);
            this.HeadsPictureBox.Name = "HeadsPictureBox";
            this.HeadsPictureBox.Size = new System.Drawing.Size(231, 233);
            this.HeadsPictureBox.TabIndex = 0;
            this.HeadsPictureBox.TabStop = false;
            // 
            // TossButton
            // 
            this.TossButton.Location = new System.Drawing.Point(229, 336);
            this.TossButton.Name = "TossButton";
            this.TossButton.Size = new System.Drawing.Size(75, 23);
            this.TossButton.TabIndex = 2;
            this.TossButton.Text = "Toss";
            this.TossButton.UseVisualStyleBackColor = true;
            this.TossButton.Click += new System.EventHandler(this.TossButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(467, 336);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 3;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 431);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.TossButton);
            this.Controls.Add(this.TailsPictureBox);
            this.Controls.Add(this.HeadsPictureBox);
            this.Name = "Form1";
            this.Text = "Coin Toss";
            ((System.ComponentModel.ISupportInitialize)(this.TailsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeadsPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox HeadsPictureBox;
        private System.Windows.Forms.PictureBox TailsPictureBox;
        private System.Windows.Forms.Button TossButton;
        private System.Windows.Forms.Button ExitButton;
    }
}

