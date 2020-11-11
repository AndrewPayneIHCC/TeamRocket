using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TeamRock;

namespace NotJeopardy
{
    public partial class Display : Form
    {
        Timer t = new Timer();
        int timerCount = 15;
        int pointValue, questionCategory, questionNumber, chooseRight;
        public Display()
        {
            InitializeComponent();
        }

        public Display(int points, int category, int question)
        {
            questionNumber = question;
            questionCategory = category;
            pointValue = points;
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            t.Stop();
            if(chooseRight == 1)
            {
                if (radioButton1.Checked == true)
                {
                    MessageBox.Show("Correct! This questions' points have been added to your score.");
                    Game.score += pointValue;
                }
                else MessageBox.Show("Incorrect! No points have been added to your score.");
            }
            if (chooseRight == 2)
            {
                if (radioButton2.Checked == true)
                {
                    MessageBox.Show("Correct! This questions' points have been added to your score.");
                    Game.score += pointValue;
                }
                else MessageBox.Show("Incorrect! No points have been added to your score.");
            }
            if (chooseRight == 3)
            {
                if (radioButton3.Checked == true)
                {
                    MessageBox.Show("Correct! This questions' points have been added to your score.");
                    Game.score += pointValue;
                }
                else MessageBox.Show("Incorrect! No points have been added to your score.");
            }
            if (chooseRight == 4)
            {
                if (radioButton4.Checked == true)
                {
                    MessageBox.Show("Correct! This questions' points have been added to your score.");
                    Game.score += pointValue;
                }
                else MessageBox.Show("Incorrect! No points have been added to your score.");
            }
            if (questionNumber == 3)
            {
                if (Game.roundCounter > 1)
                {
                    MessageBox.Show("Advancing to the final round");
                    Final final = new Final();
                    final.Show();
                }
                else
                {
                    Start round2 = new Start();
                    round2.Show();
                }
            }
            if (questionNumber == 4)
            {
                Result result = new Result();
                result.Show();
            }
            this.Close();
        }

        private void Display_Load(object sender, EventArgs e)
        {
            t.Interval = 1000;
            t.Tick += new EventHandler(Timer_Tick);
            t.Start();
            int newCategory = questionCategory;
            //label6.Text = Game.highName;
            //label7.Text = Game.highScore.ToString();
            if (newCategory == 0)
            {
                int newQuestion = Game.rand.Next(0, Game.cat0List.Count());
                Question newQ = Game.cat0List[newQuestion];
                chooseLayout(newQ);

            }
            if (newCategory == 1)
            {

                int newQuestion = Game.rand.Next(0, Game.cat1List.Count());
                Question newQ = Game.cat1List[newQuestion];
                chooseLayout(newQ);
            }
            if (newCategory == 2)
            {

                int newQuestion = Game.rand.Next(0, Game.cat2List.Count());
                Question newQ = Game.cat2List[newQuestion];
                chooseLayout(newQ);
            }
            if (newCategory == 3)
            {

                int newQuestion = Game.rand.Next(0, Game.cat3List.Count());
                Question newQ = Game.cat3List[newQuestion];
                chooseLayout(newQ);
            }
            if (newCategory == 4)
            {

                int newQuestion = Game.rand.Next(0, Game.cat4List.Count());
                Question newQ = Game.cat4List[newQuestion];
                chooseLayout(newQ);
            }
            if (newCategory == 5)
            {

                int newQuestion = Game.rand.Next(0, Game.cat5List.Count());
                Question newQ = Game.cat5List[newQuestion];
                chooseLayout(newQ);
            }
            if (newCategory == 6)
            {

                int newQuestion = Game.rand.Next(0, Game.cat6List.Count());
                Question newQ = Game.cat6List[newQuestion];
                chooseLayout(newQ);
            }
            if (newCategory == 7)
            {

                int newQuestion = Game.rand.Next(0, Game.cat7List.Count());
                Question newQ = Game.cat7List[newQuestion];
                chooseLayout(newQ);
            }
            if (newCategory == 8)
            {

                int newQuestion = Game.rand.Next(0, Game.cat8List.Count());
                Question newQ = Game.cat8List[newQuestion];
                chooseLayout(newQ);
            }
            if (newCategory == 9)
            {

                int newQuestion = Game.rand.Next(0, Game.cat9List.Count());
                Question newQ = Game.cat9List[newQuestion];
                chooseLayout(newQ);
            }
            if (newCategory == 10)
            {

                int newQuestion = Game.rand.Next(0, Game.cat10List.Count());
                Question newQ = Game.cat10List[newQuestion];
                chooseLayout(newQ);
            }
            if (newCategory == 11)
            {

                int newQuestion = Game.rand.Next(0, Game.cat11List.Count());
                Question newQ = Game.cat11List[newQuestion];
                chooseLayout(newQ);
            }
            if (newCategory == 12)
            {

                int newQuestion = Game.rand.Next(0, Game.cat12List.Count());
                Question newQ = Game.cat12List[newQuestion];
                chooseLayout(newQ);
            }
            if (newCategory == 13)
            {

                int newQuestion = Game.rand.Next(0, Game.cat13List.Count());
                Question newQ = Game.cat13List[newQuestion];
                chooseLayout(newQ);
            }
            if (newCategory == 14)
            {

                int newQuestion = Game.rand.Next(0, Game.cat14List.Count());
                Question newQ = Game.cat14List[newQuestion];
                chooseLayout(newQ);
            }
        }

        private void Timer_Tick(object sender, EventArgs eArgs)
        {
            timerCount--;
            if (timerCount == 0)
            {
                t.Stop();
                MessageBox.Show("Time has ran out. No points awarded for question");
                if (chooseRight == 1)
                {
                    label1.Visible = false;
                    label2.Visible = false;
                    label3.Visible = false;
                }
                if (chooseRight == 2)
                {
                    label2.Visible = false;
                    label3.Visible = false;
                    lblDisplay.Visible = false;
                }
                if (chooseRight == 3)
                {
                    label1.Visible = false;
                    label3.Visible = false;
                    lblDisplay.Visible = false;
                }
                if (chooseRight == 4)
                {
                    label1.Visible = false;
                    label2.Visible = false;
                    lblDisplay.Visible = false;
                }
                System.Threading.Thread.Sleep(5000);
                this.Close();
            }
        }
        private void chooseLayout(Question newQ)
        {
            lblQuestions.Text = newQ.QText;
            chooseRight = Game.rand.Next(1, 5);
            if (chooseRight == 1)
            {
                lblDisplay.Text = newQ.Correct;
                label1.Text = newQ.Incorrect[0];
                label2.Text = newQ.Incorrect[1];
                label3.Text = newQ.Incorrect[2];
            }
            else if (chooseRight == 2)
            {

                label1.Text = newQ.Correct;
                label2.Text = newQ.Incorrect[0];
                label3.Text = newQ.Incorrect[1];
                lblDisplay.Text = newQ.Incorrect[2];
            }
            else if (chooseRight == 3)
            {

                label2.Text = newQ.Correct;
                label3.Text = newQ.Incorrect[0];
                lblDisplay.Text = newQ.Incorrect[1];
                label1.Text = newQ.Incorrect[2];
            }
            else
            {

                label3.Text = newQ.Correct;
                lblDisplay.Text = newQ.Incorrect[0];
                label1.Text = newQ.Incorrect[1];
                label2.Text = newQ.Incorrect[2];
            }
        }

    }
}
