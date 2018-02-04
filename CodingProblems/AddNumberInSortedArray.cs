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
    public partial class AddNumberInSortedArray : Form
    {     

        public AddNumberInSortedArray()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           var newArray = AddNumberInArray(Convert.ToInt32(textBox1.Text));
            label1.Text = string.Join(",", newArray);
        }

        private int[] AddNumberInArray(int newNumber)
        {
            int[] newArray,currentArray;

            if (label1.Text == "")
            {
                return ( new int[] { newNumber });
            }

             currentArray = (label1.Text.Split(',').ToArray()).Select(item => Convert.ToInt32(item)).ToArray();
            
            newArray = new int[currentArray.Length +1 ];
            Array.Copy(currentArray, newArray, currentArray.Length);
            
            newArray[currentArray.Length] = newNumber;
           
            var newNumberIndex = currentArray.Length;

            while (newNumberIndex > 0)
            {
                if (newArray[newNumberIndex] <= newArray[newNumberIndex - 1])
                {
                    newArray[newNumberIndex] = newArray[newNumberIndex - 1];
                    newArray[newNumberIndex - 1] = newNumber;
                    newNumberIndex -= 1;
                }
                else
                {
                   break;
                }
            }

            return newArray;
        }

        private void AddNumberInSortedArray_Load(object sender, EventArgs e)
        {
            label1.Text = "";
        }
    }
}
