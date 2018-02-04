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
    public partial class StairCase : Form
    {
        public StairCase()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            PrintStairCase(100);
        }

        static void PrintStairCase(int n)
        {

            string output = "";

            var count = n;

            for (int i = 0; i <= n; i++)
            {
                var str = "";
                for (int j = 0; j < count; j++)
                    str = string.Concat(str, " ");

                for (int j = count; j < n; j++)
                    str = string.Concat(str, "#");

                count--;

               output =  string.Concat(output, str, "\n");

            }

            output = output.TrimEnd('\n');

            Console.Write(output);
            
        }


        static int sum(int[] numbers)
        {
            var sum = 0;
            for (var i = 1; i < numbers.Count(); i++ )
            {
                sum = sum + numbers[i];
            }
            return sum;

    }




    }
}
