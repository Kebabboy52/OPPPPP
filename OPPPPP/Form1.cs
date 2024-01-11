using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OPPPPP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCan_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonLog_Click(object sender, EventArgs e)
        {
            if (new User(textBoxLog.Text, textBoxPass.Text).CheckUser())
            {
                this.Hide();
                var formMain = new FormMain();
                formMain.Closed += (s, args) => this.Close();
                formMain.Show();
            }
            else
            {
                this.Close();
            }

        }
    }
}
