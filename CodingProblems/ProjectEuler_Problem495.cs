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
    public partial class ProjectEuler_Problem495 : Form
    {
        public Dictionary<int, List<int>> multiplesList = new Dictionary<int, List<int>>();

        public ProjectEuler_Problem495()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var number = Convert.ToInt32(textBox1.Text);
            var distinctIntegers = Convert.ToInt32(textBox2.Text);
            Write_n_ProductOf_k(number, distinctIntegers);
        }

        public void Write_n_ProductOf_k(int n,int k)
            {
            List<int> multiples = GetMultiples(n);
            
            multiplesList.Add(n,multiples);

            foreach (var multiple in multiples)
            {
                var tempMultiples = GetMultiples(multiple);
                if (tempMultiples.Count > 1 && !(multiplesList.ContainsKey(multiple)))
                    multiplesList.Add(multiple, tempMultiples);
            }
            
            var products = new List<int[]>();

            multiples = GetAdditionalMultiples(multiples, n, k);

            // multiples.Reverse();

            var multipleIndex = 0;


            while(true)
            {

                for(var i=0;i<k;i++)
                {




                }


            }

            

        }

       // public int[] GetProduct()

        public List<int> GetMultiples(int number)
        {
            List<int> multiples = new List<int>();

            for (var i = 1; i < 10; i++)
            {
                if (number % i == 0)
                    multiples.Add(i);

                if (i + 1 == number)
                    break;
            }

            return multiples;

        }

        public List<int> GetAdditionalMultiples(List<int> input, int n, int k)
        {
            var multiples = new List<int>();

            for(var i=0;i < input.Count-1; i++)
            {
                for(var j = i+1; j < input.Count; j++)
                {
                    var multiple = input[i] * input[j];
                    if (multiple >= n / k)
                        break;
                    if(n%multiple ==0 )
                    multiples.Add(multiple);
                }
            }

            input.AddRange(multiples.Distinct());

            return (input.Distinct().ToList());
        }
    }
}

/*Backup*/

//foreach(var multiple in multiples)
//{               
//    var num = n / multiple;

//    var numberMultiples = (GetMultiples(num));
//    numberMultiples.Reverse();

//    if (numberMultiples.Count > k/2)
//    {
//        foreach(var n1 in numberMultiples)
//        {
//            int[] product = new int[4];
//            product[0] = multiple;
//            //product[1]



//        }


//    }


//}
