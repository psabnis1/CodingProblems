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
    public partial class MoveStringChars : Form
    {
        public MoveStringChars()
        {
            InitializeComponent();
        }

        private void MoveStringChars_Load(object sender, EventArgs e)
        {
            MoveString();
        }

        public void MoveString()
        {
            var str = "Shraddha Kulkarni";
            char[] arr = str.ToArray();

            int p = 3, index = 0;
            while (index < p && index < arr.Length)
            {
                var val = arr[0];
                for (var i = 0; i < arr.Length - 1; i++)
                {
                    arr[i] = arr[i + 1];
                }
                arr[arr.Length - 1] = val;
                index += 1;
            }
            str = string.Join("", arr);
        }
    }
}
