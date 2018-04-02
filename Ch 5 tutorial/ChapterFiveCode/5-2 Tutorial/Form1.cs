using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5_2_Tutorial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            //const decimal

            const decimal Intrate = 0.005m;

            // declare the local variables

            decimal balance;
            int months;
            int count = 1;


            // get the starting balance

            if (decimal.TryParse(StartingBalanceBox.Text, out balance))

            {

                // get the number of months 

                if (int.TryParse(NumberOfMonthsBox.Text, out months))
                {


                    // a loop that calculates the ending balance

                    while (count <= months)
                    {
                        // add the months interest 

                        balance = balance + (Intrate * balance);

                        // display the months balance 

                        listBox1.Items.Add("the ending balance " + "for month " + count +
                          " is " + balance.ToString("c"));


                        //add 1 to the loop counter 

                        count = count + 1;



                    }



                    // display the ending balance 

                    EndingBalanceBox.Text = balance.ToString("c");

                }

                else
                {
                    //invalid number of months entered
                    MessageBox.Show("invalid number of months entered");


                }
            }

            else
            {
                //invalid starting balance entered
                MessageBox.Show("invalid starting balance entered");
            }
                
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            StartingBalanceBox.Text = "";
            NumberOfMonthsBox.Text = "";
            EndingBalanceBox.Text = "";
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
