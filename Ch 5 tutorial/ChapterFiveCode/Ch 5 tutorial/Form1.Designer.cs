namespace Ch_5_tutorial
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.StartingBalanceBox = new System.Windows.Forms.TextBox();
            this.NumberOfMonthsBox = new System.Windows.Forms.TextBox();
            this.EndingBalanceBox = new System.Windows.Forms.TextBox();
            this.Calculate = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Starting Balance";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Number Of Months";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ending Balance ";
            // 
            // StartingBalanceBox
            // 
            this.StartingBalanceBox.Location = new System.Drawing.Point(270, 22);
            this.StartingBalanceBox.Name = "StartingBalanceBox";
            this.StartingBalanceBox.Size = new System.Drawing.Size(100, 20);
            this.StartingBalanceBox.TabIndex = 3;
            // 
            // NumberOfMonthsBox
            // 
            this.NumberOfMonthsBox.Location = new System.Drawing.Point(270, 79);
            this.NumberOfMonthsBox.Name = "NumberOfMonthsBox";
            this.NumberOfMonthsBox.Size = new System.Drawing.Size(100, 20);
            this.NumberOfMonthsBox.TabIndex = 4;
            // 
            // EndingBalanceBox
            // 
            this.EndingBalanceBox.Location = new System.Drawing.Point(270, 218);
            this.EndingBalanceBox.Name = "EndingBalanceBox";
            this.EndingBalanceBox.Size = new System.Drawing.Size(100, 20);
            this.EndingBalanceBox.TabIndex = 5;
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(31, 342);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(75, 23);
            this.Calculate.TabIndex = 6;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(191, 342);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 7;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(353, 342);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(75, 23);
            this.ExitButton.TabIndex = 8;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 406);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.EndingBalanceBox);
            this.Controls.Add(this.NumberOfMonthsBox);
            this.Controls.Add(this.StartingBalanceBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Balance";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox StartingBalanceBox;
        private System.Windows.Forms.TextBox NumberOfMonthsBox;
        private System.Windows.Forms.TextBox EndingBalanceBox;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button ExitButton;
    }
}

