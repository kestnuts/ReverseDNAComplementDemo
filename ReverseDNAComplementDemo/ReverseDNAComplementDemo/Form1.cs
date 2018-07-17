using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ReverseDNAComplementDemo
{
    public partial class Form1 : Form
    {
        //regex to prevent user from entering anything that isn't a nucleotide
        string nucleotides = @"[^ACTGactg]+" ;
        //any validation errors will be added to this string
        string errorMsg = string.Empty;
        //will hold a randomly generated DNA strand
        string misterDNA = string.Empty;
        //for the reversed DNA strand
        string reverseDNA = string.Empty;
        //for the reverse complement of the DNA strand
        string reverseComplement = string.Empty;

        public Form1()
        {
            InitializeComponent();
        }

        private void userDNATextbox_TextChanged(object sender, EventArgs e)
        {
           

                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(userDNATextbox.Text))
            {
                errorMsg = string.Empty;
                if (Regex.IsMatch(userDNATextbox.Text, nucleotides))
                {
                    errorMsg += "A DNA string can only contain A, C, G, or T!";
                }
                else if (userDNATextbox.TextLength < 8)
                {
                    errorMsg += "Please input at least 8 characters.";

                }
                if (errorMsg != String.Empty)
                {
                    MessageBox.Show(errorMsg);
                }
                else
                {
                    dnaStringTextbox.Text = userDNATextbox.Text;
                    reversedDNATextBox.Text = DNA.ReverseString(userDNATextbox.Text);
                    reverseComplementTextBox.Text = DNA.ReverseDNAComplement(userDNATextbox.Text);
                }
            }
            else
            {
                int stringLength = (int)stringLengthUpDown.Value;
                misterDNA = DNA.RandomDNA(stringLength);
                reverseDNA = DNA.ReverseString(misterDNA);
                reverseComplement = DNA.ReverseDNAComplement(misterDNA);

                dnaStringTextbox.Text = misterDNA;
                reversedDNATextBox.Text = reverseDNA;
                reverseComplementTextBox.Text = reverseComplement;

            }
           
        }
    }
}
