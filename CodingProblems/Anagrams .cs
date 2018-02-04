using System;
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
    public partial class Anagrams : Form
    {
        public Anagrams()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Text = CheckAnagram(textBox1.Text, textBox2.Text) ? "Anagram strings" : "Non Anagram Strings";
        }

        private bool CheckAnagram(string input1, string input2)
        {

            if (input1.Length != input2.Length)
                return false;

            char[] inputArray1 = input1.ToArray();
            char[] inputArray2 = input2.ToArray();

            int matchCounter = 0;

            foreach(var ch in inputArray1)
            {
                for(int i = 0; i < inputArray2.Length; i++)
                {
                    if (ch == '.')
                    {
                        MessageBox.Show("'.' is a reserved character!!!");
                        return false;
                    }
                    if(ch == inputArray2[i])
                    {
                        inputArray2[i] = '.';
                        matchCounter += 1;
                        break; 
                    }
                }
            }

            if(matchCounter == input1.Length)
                return true;

            return false;

        }
    }
}
