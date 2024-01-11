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
    public partial class Regisrt : Form
    {
        public Regisrt()
        {
            InitializeComponent();
        }

        private void Regisrt_Load(object sender, EventArgs e)
        {

        }

        private void buttonReg_Click(object sender, EventArgs e)
        {
            DBManager dB = new DBManager();
            if (dB.AddNewUser("C:\\db 7322 opp.db", textBoxLog.Text, textBoxPass.Text))
            {
                MessageBox.Show("Успешно");
            }
            else
            {
                MessageBox.Show("Провал");
            }
        }
    }
}
