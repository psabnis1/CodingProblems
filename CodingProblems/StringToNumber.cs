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
    public partial class StringToNumber : Form
    {
        public StringToNumber()
        {
            InitializeComponent();
        }

        private void btnConvertToNumber_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;

            MessageBox.Show(StrToInt(input).ToString());

        }

        int StrToInt(string str)
        {
            int response = 0;
            foreach (char c in str)
            {
                response *= 10;
                response += c - '0';
            }
            return response;
        }

    }
}
