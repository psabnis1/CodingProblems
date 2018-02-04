using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodingProblems
{
    public partial class PrimeNumber : Form
    {
        public PrimeNumber()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrintPrimeNumbers(Convert.ToInt32(textBox1.Text));
        }

        private void PrintPrimeNumbers(int number)
        {
            

            int[] bits = new int[number];

            string primes ="";
            for (int i = 0; i <= bits.Count() - 1; i++)
                bits[i] = 1;
            int lastBit = number;
            for (int i = 2; i <= lastBit - 1; i++)
                if (bits[i] == 1)
                    for (int j = 2 * i; j <= bits.Count() - 1; j++)
                        bits[j] = 0;
            int counter = 0;
            for (int i = 1; i <= bits.Count() - 1; i++)
                if (bits[i] == 1)
                {
                    primes += i.ToString();
                    counter++;
                    if ((counter % 7) == 0)
                        primes += "\n";
                    else
                        primes += "\n";
                }
         
            label1.Text = primes;
        }
    }
}
