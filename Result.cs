using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            if (Game.score > Game.highScore)
            {
                MessageBox.Show("Congratulations! You have the new high score.");
                Game.highScore = Game.score;
                Game.highName = Game.user;
            }
            lblScore.Text = Game.user;
            lblScoreNum.Text = Game.score.ToString();
            lblHScore.Text = Game.highName;
            lblHighNum.Text = Game.highScore.ToString();

            FileStream outFile = new FileStream("HSCORE.DAT", FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(outFile);
            writer.WriteLine(Game.highName + "," + Game.highScore);
            writer.Close();
            outFile.Close();
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
