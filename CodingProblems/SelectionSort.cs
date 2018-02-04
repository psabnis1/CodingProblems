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
    public partial class SelectionSort : Form
    {
        public SelectionSort()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = GetSortedArray();
        }

        public string GetSortedArray()
        {
            var arr = new int[] { 55, 78, 93, 6, 42, 85, 100, 8 };
            int min, temp;
            for(var outer = 0; outer < arr.Length; outer++ )
            {
                 min = outer;
                for(var inner = outer + 1; inner <arr.Length;inner++)
                {
                    if (arr[inner] < arr[min])
                        min = inner;
                }

                if (min != outer)
                {
                    temp = arr[outer];
                    arr[outer] = arr[min];
                    arr[min] = temp;
                }
            }

            return String.Join(",", arr);
        }

        private void SelectionSort_Load(object sender, EventArgs e)
        {

        }
    }
}
