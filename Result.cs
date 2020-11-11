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
    public partial class Result : Form
    {
        public Result()
        {
            InitializeComponent();
        }

        private void Result_Load(object sender, EventArgs e)
        {
            lblScore.Text = Game.user;
            lblScoreNum.Text = Game.score.ToString();
            lblHScore.Text = Game.highName;
            lblHighNum.Text = Game.highScore.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgain_Click(object sender, EventArgs e)
        {
            Game newGame = new Game();
            newGame.Show();
            this.Close();
        }
    }
}
