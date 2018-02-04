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
    public partial class QuestionPaperFromQuestionBanks : Form
    {
        public Dictionary<string, int> QuestionBanks;
        public QuestionPaperFromQuestionBanks()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QuestionBanks = new Dictionary<string, int>();
            textBox5.Text = GetQuestionPaper();
        }

        public string GetQuestionPaper()
        {
            var questionBanks = new List<List<string>>();
            questionBanks.Add(GetQuestionBank('A', Convert.ToInt32(textBox1.Text)));
            questionBanks.Add(GetQuestionBank('B', Convert.ToInt32(textBox2.Text)));
            questionBanks.Add(GetQuestionBank('C', Convert.ToInt32(textBox3.Text)));
            questionBanks.Add(GetQuestionBank('D', Convert.ToInt32(textBox4.Text)));

            questionBanks = questionBanks.OrderBy(item => item.Count).ToList();

            

            return "";
        }

        //public string GetQuestionPaper()
        //{
        //    var questionBanks = new List<List<string>>();
        //    questionBanks.Add(GetQuestionBank('A', Convert.ToInt32(textBox1.Text)));
        //    questionBanks.Add(GetQuestionBank('B', Convert.ToInt32(textBox2.Text)));
        //    questionBanks.Add(GetQuestionBank('C', Convert.ToInt32(textBox3.Text)));
        //    questionBanks.Add(GetQuestionBank('D', Convert.ToInt32(textBox4.Text)));

        //    questionBanks = questionBanks.OrderByDescending(item => item.Count).ToList();

        //    var qbWithMaxQuestions = QuestionBanks.OrderByDescending(item => item.Value).FirstOrDefault();
        //    var totalQuestions = QuestionBanks.Sum(item => item.Value);


        //    if (qbWithMaxQuestions.Value > (totalQuestions - qbWithMaxQuestions.Value))
        //    {
        //        MessageBox.Show("Invalid input");
        //        return "";
        //    }

        //    var questionPaper = new List<string>();

        //    var set2 = new List<string>();

        //    for (var i = 0; i < questionBanks[1].Count; i++)
        //    {
        //        set2.Add(questionBanks[1][i]);
        //        if (i < questionBanks[2].Count)
        //            set2.Add(questionBanks[2][i]);
        //    }

        //    var index = 0;

        //    set2.Reverse();

        //    var set3 = new List<string>();

        //    for (index = 0; index < questionBanks[3].Count(); index++)
        //    {
        //        set3.Add(questionBanks[3][index]);
        //        set3.Add(set2[index]);
        //    }

        //    set3.AddRange(set2.GetRange(index, set2.Count - index));

        //    var count = set3.Count >= questionBanks[0].Count ? set3.Count : questionBanks[0].Count;

        //    for (var i = 0; i < count; i++)
        //    {
        //        if (i < questionBanks[0].Count)
        //            questionPaper.Add(questionBanks[0][i]);
        //        if (i < set3.Count)
        //            questionPaper.Add(set3[i]);
        //    }

        //    return String.Join(", ", questionPaper);
        //}

        public List<string> GetQuestionBank(char Set, int numberOfQuestions)
        {
            var questionBank = new List<string>();

            for (int i = 1; i <= numberOfQuestions; i++)
            {
                questionBank.Add(string.Concat(Set, i.ToString()));
            }

            QuestionBanks.Add(Set.ToString(), numberOfQuestions);
            return questionBank;
        }


    }
}
