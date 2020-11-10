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

        private void button1_Click(object sender, EventArgs e)
        {
            Display ad = new Display();
            ad.Show();
        }

        private void Start_Load(object sender, EventArgs e)
        {

        }
    }
}
