using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NotJeopardy;

namespace TeamRock
{
    public partial class Final : Form
    {
        int finalCat;
        public Final()
        {
            InitializeComponent();
        }

        private void Final_Load(object sender, EventArgs e)
        {

            int newRand = Game.rand.Next(0, 7);
            finalCat = Game.categoryList[newRand];

            LblFinalCat.Text = Game.Categories[finalCat];
            lblFinalPoint.Text = "10";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Display finalQ = new Display(10, finalCat, 4);
            finalQ.Show();
            this.Close();
        }
    }
}
