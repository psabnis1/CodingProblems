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
    public partial class Assignments : Form
    {
        public Assignments()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          //  int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
            var sum = arr.Sum(element => element);
            Console.WriteLine(string.Format("Sum of array elements = {0}", sum));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] tokens_a0 = "5 6 7".Split(' ');
            int a0 = Convert.ToInt32(tokens_a0[0]);
            int a1 = Convert.ToInt32(tokens_a0[1]);
            int a2 = Convert.ToInt32(tokens_a0[2]);
            string[] tokens_b0 = "3 6 10".Split(' ');
            int b0 = Convert.ToInt32(tokens_b0[0]);
            int b1 = Convert.ToInt32(tokens_b0[1]);
            int b2 = Convert.ToInt32(tokens_b0[2]);

            int A_Points = 0;
            int B_Points = 0;

            for(var i = 0; i<3;i++)
            {
                if (Convert.ToInt32(tokens_a0[i]) > Convert.ToInt32(tokens_b0[i]))
                    A_Points++;
                else if (Convert.ToInt32(tokens_a0[i]) < Convert.ToInt32(tokens_b0[i]))
                    B_Points++;
            }

            Console.WriteLine(string.Format("{0} {1}", A_Points, B_Points));
        }

        private void Assignments_Load(object sender, EventArgs e)
        {

        }
    }
}
