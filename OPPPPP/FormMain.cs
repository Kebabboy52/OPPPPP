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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            textBoxLog.Text = "Введите логин";
            textBoxPass.Text = "Введите пароль";
        }

        private void buttonSort_Click(object sender, EventArgs e)
        { 
        }
           


        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonEnter_Click(object sender, EventArgs e)
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

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void textBoxLog_Enter(object sender, EventArgs e)
        {
            if (textBoxLog.Text == "Введите логин") 
            textBoxLog.Text = "";
        }

        private void textBoxLog_Leave(object sender, EventArgs e)
        {
            if (textBoxLog.Text == "")
                textBoxLog.Text = "Введите логин";
        }

        private void textBoxPass_Enter(object sender, EventArgs e)
        {
            if (textBoxPass.Text == "Введите пароль")
                textBoxPass.Text = "";
        }

        

        private void textBoxPass_Leave(object sender, EventArgs e)
        {
            if (textBoxPass.Text == "")
                textBoxPass.Text = "Введите пароль";
        }
    }
    
}
