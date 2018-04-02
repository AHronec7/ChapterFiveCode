namespace _5_6_Tutorial
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
            this.CountriesListBox = new System.Windows.Forms.ListBox();
            this.GetCountriesButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "The Countries Of South America";
            // 
            // CountriesListBox
            // 
            this.CountriesListBox.FormattingEnabled = true;
            this.CountriesListBox.Location = new System.Drawing.Point(53, 57);
            this.CountriesListBox.Name = "CountriesListBox";
            this.CountriesListBox.Size = new System.Drawing.Size(289, 238);
            this.CountriesListBox.TabIndex = 1;
            // 
            // GetCountriesButton
            // 
            this.GetCountriesButton.Location = new System.Drawing.Point(83, 334);
            this.GetCountriesButton.Name = "GetCountriesButton";
            this.GetCountriesButton.Size = new System.Drawing.Size(90, 23);
            this.GetCountriesButton.TabIndex = 2;
            this.GetCountriesButton.Text = "Get Countries";
            this.GetCountriesButton.UseVisualStyleBackColor = true;
            this.GetCountriesButton.Click += new System.EventHandler(this.GetCountriesButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(257, 334);
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
            this.ClientSize = new System.Drawing.Size(417, 374);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.GetCountriesButton);
            this.Controls.Add(this.CountriesListBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox CountriesListBox;
        private System.Windows.Forms.Button GetCountriesButton;
        private System.Windows.Forms.Button ExitButton;
    }
}

