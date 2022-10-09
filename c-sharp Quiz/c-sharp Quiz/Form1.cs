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
            //questions are here .
            switch (n)
            {
                case 1:
                    typequestion("who made the C# ?","microsoft","oracle","jet brains","google");
                    break;
                case 2:
                    typequestion("how to change the existing int variable in c# ?", "int a =1;", "a 1;", "a = 1;", "a=> 1");
                    break;
            }


        }

        public void answer(int qusn, int choise)
        {
            //answers are here .
            switch (qusn)
            {
                case 1:
       //(question,option user choosed ,the true answer , add to score)
                    trueanswer(qusn,choise, 1, 1);
                    break;
                case 2:
                    trueanswer(qusn, choise, 3, 1);
                    finished(true);
                    break;
            }
        }
        public void trueanswer(int Question ,int yourchoice, int trueanswer , int addscore)
        {
            if (yourchoice == trueanswer) {
                score += addscore;
            }
            question(Question+1);
        }

        public void typequestion(String q, String a1, String a2, String a3, String a4 ) {
          
                qusnum += 1;
                label1.Text = q;
                button1.Text = a1;
                button2.Text = a2;
                button3.Text = a3;
                button4.Text = a4;
                button1.Show();
                button2.Show();
                button3.Show();
                button4.Show();
                startbt.Hide();

               

               
            

        }
        public void finished(Boolean isfinished)
        {
            if (isfinished)
            {
                button1.Hide();
                button2.Hide();
                button3.Hide();
                button4.Hide();
                startbt.Show();
                label1.Text = "Your score is : (score : " + score.ToString() + " )";
                startbt.Text = "Try again";
                qusnum = 0;
                score = 0;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

                answer(qusnum, 1);
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

                answer(qusnum, 2);
        }

        private void button3_Click(object sender, EventArgs e)
        {

                answer(qusnum, 3);
        }

        private void button4_Click(object sender, EventArgs e)
        {

                answer(qusnum, 4);
            }
        }
    }

