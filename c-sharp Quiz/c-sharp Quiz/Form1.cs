using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace c_sharp_Quiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = "Click on start to start the quiz";
            button1.Hide();
            button2.Hide();
            button3.Hide();
            button4.Hide();
        }
        public int score;
        public int qusnum;
        public void question(int n)
        {
            //questions
            switch (n)
            {
                case 1:
                    label1.Text = "who made the C# ?";
                    button1.Show();
                    button2.Show();
                    button3.Show();
                    button4.Show();
                    startbt.Hide();
                    button1.Text = "microsoft";
                    button2.Text = "oracle";
                    button3.Text = "jet brains";
                    button4.Text = "google";
                    qusnum = 1;
                    break;
                case 2:
                    label1.Text = "how to change the existing int variable in c# ?";
                    button1.Show();
                    button2.Show();
                    button3.Show();
                    button4.Show();
                    startbt.Hide();
                    button1.Text = "int a = 1;";
                    button2.Text = "a 1;";
                    button3.Text = "a = 1;";
                    button4.Text = "a => 1";
                    qusnum = 2;
                    break;
            }


        }

        public void answer(int qusn, int choise)
        {
            switch (qusn)
            {
                case 1:
                    if (choise == 1)
                    {
                        score += 1;
                    }
                    question(2);
                    break;
                case 2:
                    if (choise == 3)
                    {
                        score += 1;
                    }
                    finished(true);

                    break;
            }
        }
        public void finished(Boolean finish)
        {
            if (finish)
            {
                if (score == 2)
                {
                    label1.Text = "You answered all correctly ! (score :" + score.ToString() + ")";
                    button1.Hide();
                    button2.Hide();
                    button3.Hide();
                    button4.Hide();
                    startbt.Show();
                    startbt.Text = "try again";

                }
                else
                {
                    if (score == 1)
                    {
                        label1.Text = "You answered half of the questions correctly (score :" + score.ToString() + ")";
                        button1.Hide();
                        button2.Hide();
                        button3.Hide();
                        button4.Hide();
                        startbt.Show();
                        startbt.Text = "try again";
                    }
                    else
                    {
                        label1.Text = "fail !(score :" + score.ToString() + ")";
                        button1.Hide();
                        button2.Hide();
                        button3.Hide();
                        button4.Hide();
                        startbt.Show();
                        startbt.Text = "try again";
                    }

                }
                qusnum = 0;
                score = 0;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (qusnum == 1)
            {
                answer(1, 1);

            }
            else if (qusnum == 2)
            {
                answer(2, 1);
            }
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void startbt_Click(object sender, EventArgs e)
        {
            question(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (qusnum == 1)
            {
                answer(1, 2);
            }
            else if (qusnum == 2)
            {
                answer(2, 2);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (qusnum == 1)
            {
                answer(1, 3);
            }
            else if (qusnum == 2)
            {
                answer(2, 3);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (qusnum == 1)
            {
                answer(1, 4);
            }
            else if (qusnum == 2)
            {
                answer(2, 4);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
