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
    public partial class UserName : Form
    {
        public UserName()
        {
            InitializeComponent();
        }

        private void UserName_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text.Trim().Length != 0)
            {
                Game.user = txtUserName.Text;
                Start s = new Start();
                s.Show();
                this.Close();
            }
            else MessageBox.Show("You must enter a name");
        }
    }
}
