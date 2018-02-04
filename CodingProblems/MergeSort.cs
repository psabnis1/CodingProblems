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
    public partial class MergeSort : Form
    {
        public MergeSort()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MergeSortMethod();
        }


        public void MergeSortMethod()
        {
            int[] tempArray = new int[] { 10, 88, 2, 66, 79, 52, 77, 3, 0, 100 };
            RecMergeSort(ref tempArray, 0, tempArray.Length - 1);
            textBox1.Text = String.Join(", ", tempArray);

        }
        public void RecMergeSort(ref int[] tempArray, int lbound, int ubound)
        {
            if (lbound == ubound)
                return;
            else
            {
                int mid = (int)(lbound + ubound) / 2;
                RecMergeSort(ref tempArray, lbound, mid);
                RecMergeSort(ref tempArray, mid + 1, ubound);
                //  RecMergeSort(tempArray, lbound, mid + 1, ubound);
            }
        }

    }
}
