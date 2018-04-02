using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _5_7_Tutorial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            try
            {


                // variables

                decimal sales;
                decimal total = 0m;

                // declare a streamreader variable

                StreamReader inputfile;

                //open the file and get a steamreader object

                inputfile = File.OpenText("sales.txt");

                //Read the files contents

                while (!inputfile.EndOfStream)
                {
                    //get a sales amount
                    sales = decimal.Parse(inputfile.ReadLine());

                    //add the sales amount to the total

                    total += sales;

                }

                // close the file
                inputfile.Close();

                // display the total

                TotalLabel.Text = total.ToString("c");

            }

            catch (Exception ex)
            {
                // display an erro

                MessageBox.Show(ex.Message);
            }
            

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
