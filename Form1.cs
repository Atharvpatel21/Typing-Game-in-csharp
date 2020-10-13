using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Typing_Game
{
    public partial class Form1 : Form
    {

        string[] words = { "internet", "programming", "mooict", "coding", "sky", "banana", "developer","puzzles" };

        Random rmd = new Random();

        int correct = 0;
        int incorrect = 0;

        public Form1()
        {
            InitializeComponent();

            lblword.Text = words[rmd.Next(0 , words.Length) ];
        }

        private void CheckGame(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                 if(textBox1.Text == lblword.Text)
                {
                    correct++;
                    lblword.Text = words[rmd.Next(0, words.Length)];
                    textBox1.Text = null;
                }
                 else
                {
                    incorrect++;
                    lblword.Text = words[rmd.Next(0, words.Length)];
                    textBox1.Text = null;
                }
                lblRight.Text = "Correct:" + correct;
                lblWrong.Text = "Incorrect:" + incorrect;
            }
        }
    }
}
