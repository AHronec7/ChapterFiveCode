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
namespace _5_4_Tutorial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void WriteNameButton_Click(object sender, EventArgs e)
        {
            try
            {


                // declare a streamwriter variable

                StreamWriter outputfile;

                //create a file and get a streamwriter object 

                outputfile = File.CreateText("names.txt");

                //write the friends name to the file 


                outputfile.WriteLine("FriendTextBox.Text");

                //close the file

                outputfile.Close();

                //let the user know the name was written

                MessageBox.Show("The name was written ");

            }

            catch (Exception ex)

            {
                //display an error message   

                MessageBox.Show(ex.Message);

            }
               
                
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
