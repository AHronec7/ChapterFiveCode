using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5_3_Tutorial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DisplaySpeedButton_Click(object sender, EventArgs e)
        {
            try { 



            // declare the constant variables 

            const int startspeed = 60;
            const int endspeed = 130;
            const int interval = 10;
            const double conversion = 0.6214;


            //variables

            int kph;    // killom per hour
            double mph;  // miles per hour



                // display the table of speeds

                for (kph = startspeed; kph <= endspeed; kph += interval)

                {

                    // calculate mph

                    mph = kph * conversion;

                    //display the conversion 

                    SpeedListBox.Items.Add(kph + " KPH is the same as " + mph + " MPH");

                }
            }
                
            catch  (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
