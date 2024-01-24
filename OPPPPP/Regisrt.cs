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
            DBManager dBManager = new DBManager("C:\\Users\\kizar\\DBBBB.db");
            if (dBManager.AddUser(textBoxLogReg.Text,textBoxPassReg.Text) )
            {
                MessageBox.Show("Усешно");
            }
            else
            {
                MessageBox.Show("Не удалось");
            }
            //if (dBManager.AddUser("C:\\Users\\kizar\\DBBBB.db", textBoxLog.Text, textBoxPass.Text))
            //{
            //    MessageBox.Show("Успешно");
            //}
            //else
            //{
            //    MessageBox.Show("Провал");
            //}
            
           
        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBoxLog_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAuthSwap_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormMain main_form = new FormMain();
            main_form.ShowDialog();
        }
    }
}
