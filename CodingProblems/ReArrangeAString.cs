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
    public partial class ReArrangeAString : Form
    {
        public ReArrangeAString()
        {
            InitializeComponent();
        }

        private void ReArrangeAString_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var inputString = textBox1.Text;
            var position = Convert.ToInt16(textBox2.Text);
            textBox3.Text = reArrange(inputString, position);
        }

        private string reArrange(string input, int position)
        {
            var inputArray = input.ToCharArray();

            for(int i=0;i<position; i++)
            {
                var temp = inputArray[0];

                for(int j=0;j<inputArray.Length-1;j++)
                {
                    inputArray[j] = inputArray[j + 1];
                }
                inputArray[inputArray.Length-1] = temp;
            }
            return string.Concat(inputArray);
        }
    }
}
