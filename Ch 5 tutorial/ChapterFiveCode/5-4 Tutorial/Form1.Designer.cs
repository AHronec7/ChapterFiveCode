namespace _5_4_Tutorial
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
            this.label1 = new System.Windows.Forms.Label();
            this.FriendTextBox = new System.Windows.Forms.TextBox();
            this.WriteNameButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter a friends name";
            // 
            // FriendTextBox
            // 
            this.FriendTextBox.Location = new System.Drawing.Point(257, 22);
            this.FriendTextBox.Name = "FriendTextBox";
            this.FriendTextBox.Size = new System.Drawing.Size(185, 20);
            this.FriendTextBox.TabIndex = 1;
            // 
            // WriteNameButton
            // 
            this.WriteNameButton.Location = new System.Drawing.Point(116, 83);
            this.WriteNameButton.Name = "WriteNameButton";
            this.WriteNameButton.Size = new System.Drawing.Size(75, 23);
            this.WriteNameButton.TabIndex = 2;
            this.WriteNameButton.Text = "Write Name";
            this.WriteNameButton.UseVisualStyleBackColor = true;
            this.WriteNameButton.Click += new System.EventHandler(this.WriteNameButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(355, 83);
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
            this.ClientSize = new System.Drawing.Size(549, 123);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.WriteNameButton);
            this.Controls.Add(this.FriendTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Friend File";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FriendTextBox;
        private System.Windows.Forms.Button WriteNameButton;
        private System.Windows.Forms.Button ExitButton;
    }
}

