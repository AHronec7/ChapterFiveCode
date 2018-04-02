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

namespace _5_6_Tutorial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GetCountriesButton_Click(object sender, EventArgs e)
        {
            try
            {

                // declare a variable to hold a country name.

                string countryname;

                //declare a streamreader variable

                StreamReader inputfile;

                // open the file and get a streamreader object

                inputfile = File.OpenText("countries.txt");

                // clear anything currently in the listbox

                CountriesListBox.Items.Clear();

                //read the files contents

                while (!inputfile.EndOfStream)
                {
                    // get a country name
                    countryname = inputfile.ReadLine();

                    //add the country name to the listbox
                    CountriesListBox.Items.Add(countryname);
                }

                // close the file
                inputfile.Close();
            }

            catch (Exception ex)
            {
                //display an error

                MessageBox.Show(ex.Message);
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
