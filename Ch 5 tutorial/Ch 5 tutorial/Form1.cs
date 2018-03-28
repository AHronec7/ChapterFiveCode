using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch_5_tutorial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            const decimal interest_rate = 0.005m;

            // declaring the variables 

            decimal balance;
            int months;
            int count = 1;


            // get the starting balance

            if (decimal.TryParse(StartingBalanceBox.Text, out balance))
            {

                if (int.TryParse(NumberOfMonthsBox.Text, out months))

                {
                    // the following loop calculates the ending balance

                    while (count <= months)

                    {

                        // add this months interest to the balance

                        balance = balance + (interest_rate * balance);

                        // add 1 to the loop 

                        count = count + 1;

                    }


                    // display the ending balance 

                    EndingBalanceBox.Text = balance.ToString("c");
                }

                else

                {

                    // invalid number of months entered


                    MessageBox.Show("invalid number of months entered");


                }
            }

            else
            {

                // invalid number of months entered
                MessageBox.Show("invalid number of months was entered ");
            }


               


                
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {

            // clear out the boxes
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
