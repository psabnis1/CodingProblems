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
    public partial class RemoveDuplicates : Form
    {
        public RemoveDuplicates()
        {
            InitializeComponent();
        }

        private void RemoveDuplicates_Load(object sender, EventArgs e)
        {
           RemoveDuplicatesFromArray();
          
        }

        public void RemoveDuplicatesFromArray()
        {
            var arr = new int[] { 1, 1, 1, 2, 4, 4, 5, 5, 5, 6, 6, 6 };
            var i = 0;

            while (true)
            {
                var j = i + 1;
                while (j < arr.Length && arr[i] == arr[j])
                {                    
                    arr[j] = -99;                    
                    j++;
                }
                if (j == arr.Length)
                    break;

                //arr[i + 1] = arr[j];

                i = j;
            }

            Array.Sort(arr);

        }

       
    }
}
