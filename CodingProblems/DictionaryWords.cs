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
    public partial class DictionaryWords : Form
    {
        public DictionaryWords()
        {
            InitializeComponent();
        }

        private void DictionaryWords_Load(object sender, EventArgs e)
        {
            //Print();
        }

        private void Print()
        {
            char[] arr = { 'e', 'o', 'b', 'g', 'a', 'm', 'l' };
            List<string> dict = new List<string>() { "go", "bat", "me", "eat", "goal", "boy", "run" };
            string words = "";
            foreach (var word in dict)
            {
                if (!string.IsNullOrEmpty(VerifyIfExists(word, arr)))
                    words = string.Concat(words, word, ", ");
            }

            words = words.TrimEnd(new []{',',' ' });

            textBox1.Text = words;
        }


        private string VerifyIfExists(string word, char[] arr)
        {
            string wordFromArray = "";
            foreach (var letter in word.ToArray())
            {
                if (arr.Contains(letter))
                {
                    wordFromArray = string.Concat(wordFromArray, letter);

                    if (!(word.Contains(wordFromArray)))
                        return null;
                }
                else
                    return null;
            }

            if (word.Equals(wordFromArray))
                return word;

            return null;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Print();
        }
    }
}
