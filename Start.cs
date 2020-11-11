using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotJeopardy
{ 
    public partial class Start : Form
    {
        int firstCat, secondCat, thirdCat, fourthCat, points, questionCounter;
        public Start()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Start ad = new Start();
            ad.Show();
        }

        private void Start_Load(object sender, EventArgs e)
        {
            questionCounter = 0;
            Game.roundCounter++;
            if (Game.roundCounter == 1)
            {
                button1.Text = "1";
                button4.Text = "2";
                button12.Text = "3";
                button2.Text = "1";
                button5.Text = "2";
                button11.Text = "3";
                button3.Text = "1";
                button6.Text = "2";
                button10.Text = "3";
                button14.Text = "1";
                button13.Text = "2";
                button9.Text = "3";
                int newRand = Game.rand.Next(0, 15);
                firstCat = Game.categoryList[newRand];
                Game.categoryList.Remove(firstCat);
                newRand = Game.rand.Next(0, 14);
                secondCat = Game.categoryList[newRand];
                Game.categoryList.Remove(secondCat);
                newRand = Game.rand.Next(0, 13);
                thirdCat = Game.categoryList[newRand];
                Game.categoryList.Remove(thirdCat);
                newRand = Game.rand.Next(0, 12);
                fourthCat = Game.categoryList[newRand];
                Game.categoryList.Remove(fourthCat);

                label1.Text = Game.Categories[firstCat];
                label2.Text = Game.Categories[secondCat];
                label3.Text = Game.Categories[thirdCat];
                label4.Text = Game.Categories[fourthCat];
            }
            if (Game.roundCounter == 2)
            {
                button1.Text = "2";
                button4.Text = "4";
                button12.Text = "6";
                button2.Text = "2";
                button5.Text = "4";
                button11.Text = "6";
                button3.Text = "2";
                button6.Text = "4";
                button10.Text = "6";
                button14.Text = "2";
                button13.Text = "4";
                button9.Text = "6";
                int newRand = Game.rand.Next(0, 11);
                firstCat = Game.categoryList[newRand];
                Game.categoryList.Remove(firstCat);
                newRand = Game.rand.Next(0, 10);
                secondCat = Game.categoryList[newRand];
                Game.categoryList.Remove(secondCat);
                newRand = Game.rand.Next(0, 9);
                thirdCat = Game.categoryList[newRand];
                Game.categoryList.Remove(thirdCat);
                newRand = Game.rand.Next(0, 8);
                fourthCat = Game.categoryList[newRand];
                Game.categoryList.Remove(fourthCat);

                label1.Text = Game.Categories[firstCat];
                label2.Text = Game.Categories[secondCat];
                label3.Text = Game.Categories[thirdCat];
                label4.Text = Game.Categories[fourthCat];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            questionCounter++;
            Display ad = new Display(Convert.ToInt32(button1.Text),firstCat,questionCounter);
            ad.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Visible = false;
            questionCounter++;
            Display ad = new Display(Convert.ToInt32(button1.Text), firstCat, questionCounter);
            ad.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            button12.Visible = false;
            questionCounter++;
            Display ad = new Display(Convert.ToInt32(button1.Text), firstCat, questionCounter);
            ad.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Visible = false;
            questionCounter++;
            Display ad = new Display(Convert.ToInt32(button1.Text), secondCat, questionCounter);
            ad.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Visible = false;
            questionCounter++;
            Display ad = new Display(Convert.ToInt32(button1.Text), secondCat, questionCounter);
            ad.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            button11.Visible = false;
            questionCounter++;
            Display ad = new Display(Convert.ToInt32(button1.Text), secondCat, questionCounter);
            ad.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Visible = false;
            questionCounter++;
            Display ad = new Display(Convert.ToInt32(button1.Text), thirdCat, questionCounter);
            ad.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Visible = false;
            questionCounter++;
            Display ad = new Display(Convert.ToInt32(button1.Text), thirdCat, questionCounter);
            ad.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button10.Visible = false;
            questionCounter++;
            Display ad = new Display(Convert.ToInt32(button1.Text), thirdCat, questionCounter);
            ad.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            button14.Visible = false;
            questionCounter++;
            Display ad = new Display(Convert.ToInt32(button1.Text), fourthCat, questionCounter);
            ad.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            button13.Visible = false;
            questionCounter++;
            Display ad = new Display(Convert.ToInt32(button1.Text), fourthCat, questionCounter);
            ad.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Visible = false;
            questionCounter++;
            Display ad = new Display(Convert.ToInt32(button1.Text), fourthCat, questionCounter);
            ad.Show();
        }
    }
}
