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
    public partial class FindMaxNumber : Form
    {
        public FindMaxNumber()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            textBox2.Text = GetMaxNumber(textBox1.Text);

        }

        public string GetMaxNumber(string inputString)
        {          

            var arrayOfCharacters = inputString.ToArray();

            var IntegerArray = arrayOfCharacters.Select(item => Convert.ToInt16((item.ToString()))).ToArray();

            while (true)
            {
                bool numberSwapped = false;
                for (var i = 0; i < IntegerArray.Length - 1; i++)
                {
                    if (IntegerArray[i] < IntegerArray[i + 1])
                    {
                        var temp = IntegerArray[i];
                        IntegerArray[i] = IntegerArray[i + 1];
                        IntegerArray[i + 1] = temp;
                        numberSwapped = true;
                    }
                }
                if (numberSwapped == false)
                    break;              
            }

            var stringArray = IntegerArray.Select(val => Convert.ToString(val)).ToArray();

           return string.Join("", stringArray);
        }

        private void FindMaxNumber_Load(object sender, EventArgs e)
        {

        }
    }
}
