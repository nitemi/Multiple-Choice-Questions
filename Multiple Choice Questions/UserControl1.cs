using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multiple_Choice_Questions
{
    public partial class UserControl1: UserControl
    {
        int correctAnswer;
        int questionNumber = 1;
        int score;
        int totalQuestion;
        public UserControl1()
        {
            InitializeComponent();

            askQuestion(questionNumber);

            totalQuestion = 6;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

            var senderObject = (TextBox)sender;

            int textBoxTag =  Convert.ToInt32(senderObject.Tag);

            if(textBoxTag == correctAnswer)
            {
                score++;

            }
            if(questionNumber == totalQuestion)
            {
                score = 0;
                questionNumber = 0;
                askQuestion(questionNumber);
            }
            questionNumber++;
            askQuestion(questionNumber);
        }
        private void askQuestion(int qnum)
        {
            switch(qnum)
            {
                case 1:
                    //pictureBox1.Image = Properties.Resources.question;
                    
                    textBox5.Text = "1. What is a Noun?";

                    textBox1.Text = "naming word";
                    textBox2.Text = "filming word";
                    textBox3.Text = "laughing word";
                    textBox4.Text = "figuring word";

                    correctAnswer = 1;

                    break;

                    case 2:
                    //pictureBox1.Image = Properties.Resources.question;
                    
                    textBox5.Text = "The sum of angle in a triangle is ______";

                    textBox1.Text = "190 degree";
                    textBox2.Text = "360 degree";
                    textBox3.Text = "290 degree";
                    textBox4.Text = "180 degree";

                    correctAnswer = 4;
                    
                    break;

                    case 3:
                    //pictureBox1.Image = Properties.Resources.question;
                    
                    textBox5.Text = "The following words are verbs except______.";

                    textBox1.Text = "dance";
                    textBox2.Text = "blessing";
                    textBox3.Text = "jump";
                    textBox4.Text = "throw";

                    correctAnswer = 2;

                    break;

                    case 4:
                    //pictureBox1.Image = Properties.Resources.question;
                    
                    textBox5.Text = "Mixed fraction contains a whole number and _________.";

                    textBox1.Text = "proper fraction";
                    textBox2.Text = "mixed fraction";
                    textBox3.Text = "improper fraction";
                    textBox4.Text = "decimal fraction";

                    correctAnswer = 1;

                    break;

                    case 5:
                    //pictureBox1.Image = Properties.Resources.question;
                    
                    textBox5.Text = "Change 0.25 to a fraction in its lowest term";

                    textBox1.Text = "1/4";
                    textBox2.Text = "2/5";
                    textBox3.Text = "3/5";
                    textBox4.Text = "1/3";
                    
                    correctAnswer = 1;

                    break;

                    case 6:
                    //pictureBox1.Image = Properties.Resources.question;
                    
                    textBox5.Text = "Ade loves to play ______.";

                    textBox1.Text = "fooball";
                    textBox2.Text = "futball";
                    textBox3.Text = "football";
                    textBox4.Text = "fullball";
                    
                    correctAnswer = 3;

                    break;
            }
        }
    }
}
