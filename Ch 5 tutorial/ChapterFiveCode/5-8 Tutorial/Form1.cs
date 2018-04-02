using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5_8_Tutorial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TailsPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void TossButton_Click(object sender, EventArgs e)
        {
            try
            {

                // variable to indicate which side is up

                int sideup;

                //create a random object 

                Random rand = new Random();

                //get a random int in the range of 0 to 1 
                // 0 means tails and 1 means heads


                sideup = rand.Next(2);

                //display the side that is up

                if (sideup == 0)
                {
                    // display tails up
                    TailsPictureBox.Visible = true;
                    TailsPictureBox.Visible = false;
                }

                else
                {

                    //display heads up

                    HeadsPictureBox.Visible = true;
                    HeadsPictureBox.Visible = false;
                }
            }

            catch (Exception ex)
            {
                //display message
                MessageBox.Show(ex.Message);
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
