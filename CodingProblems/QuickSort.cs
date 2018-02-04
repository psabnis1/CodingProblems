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
    public partial class QuickSort : Form
    {
        public QuickSort()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] a = { 5, 3, 6, 4, 2, 9, 1, 8, 7 };
            QuickSortMethod(a);

        }

        

        static void QuickSortMethod(int[] a)
        {
            QuickSortMethod(a, 0, a.Length - 1);
        }

        static void QuickSortMethod(int[] a, int start, int end)
        {
            var leftArray = new List<int>();
            var rightArray = new List<int>();

            var pivot = a[start];

            var current = start + 1;
            while(current <= end)
            {
                if(a[current]<=pivot)
                {
                    leftArray.Add(a[current]);
                }
                else if(a[current]>pivot)
                {
                    rightArray.Add(a[current]);
                }

                if (a[end] <= pivot)
                {
                    leftArray.Add(a[end]);
                }
                else if (a[end] > pivot)
                {
                    rightArray.Add(a[end]);
                }

                current++;
                end--;

            }

        }

        private void QuickSort_Load(object sender, EventArgs e)
        {
            Add(4);

        }

        private void Add(int i)
        {
            // do something
        }

        private void Add(int i =4, int j =0)
        {
            // do something
        }
    }
}
   