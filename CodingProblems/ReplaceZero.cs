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
    public partial class ReplaceZero : Form
    {
        public ReplaceZero()
        {
            InitializeComponent();
        }

        private void ReplaceZero_Load(object sender, EventArgs e)
        {
            var input = new[] { 1, 0, 0, 2, 3, 4, 0,0,100,0,0 };
            //var count = 3;
            textBox1.Text = string.Join(",", Replace(input));///, count));
        }

        private int[] Replace(int[] input)
        {
            var resultIndex = 0;
            var replaceArray = new[] { 10, 20, 30 };

            var totalItems = input.Count();
            var replaceArrayItemsCount = replaceArray.Count();

            for (var count = 0; count < totalItems; count++)
            {                
                if (input[resultIndex] != 0)
                {
                    resultIndex++;
                    continue;
                }

                Array.Resize(ref input, (input.Count()-1 + replaceArrayItemsCount));

                for (var replaceIndex= 0; replaceIndex < replaceArrayItemsCount;replaceIndex++)
                {
                    input[resultIndex] = replaceArray[replaceIndex];
                    resultIndex++;

                    if (replaceIndex == replaceArrayItemsCount - 1)
                        break;

                    for (var index = input.Count()-1; index > resultIndex; index--)
                    {
                        input[index] = input[index - 1];
                    }                    
                }
            }

            return input;
        }



        //private int[] Replace(int[] input, int count)
        //{
        //    var countFinalNumber = (input.Length + (count * 2));
        //    var result = new int[countFinalNumber];
        //    var resultIndex = 0;
        //    var replaceArray = new[] { 10, 20, 30 };

        //    foreach (var item in input)
        //    {
        //        if(item == 0)
        //        {
        //           foreach(var element in replaceArray)
        //            {
        //                result[resultIndex] = element;
        //                resultIndex += 1;
        //            }
        //            continue;
        //        }
        //        result[resultIndex] = item;
        //        resultIndex += 1;
        //    }

        //    return result;
        //}
    }
}
