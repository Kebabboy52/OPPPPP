using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Drawing.Text;
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
            DBManager dBManager = new DBManager("C:\\Users\\kizar\\DBBBB.db");
            if (dBManager.AuthUser(textBoxLog.Text, textBoxPass.Text))
            {       
                
                MessageBox.Show("Успешно");
                FormShifr formShifr1 = new FormShifr();
                formShifr1.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Не удалось");
            }
            //if (new User(textBoxLog.Text, textBoxPass.Text).CheckUser())
            //{
            //    this.Hide();
            //    var formMain = new FormMain();
            //    formMain.Closed += (s, args) => this.Close();
            //    formMain.Show();
            //}
            //else
            //{
            //    this.Close();
            //}
            string login = textBoxLog.Text;
            if (login.Contains('\'') || login.Contains('-'))
            {

                MessageBox.Show("Логин содержить недопустимые символы");
                return;
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxLog_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //обработка события при нажатии на кнопку показать/скрыть пароль
            if (textBoxPass.PasswordChar == '*')
            {
                textBoxPass.PasswordChar = '\0';
            }
            else
            {
                textBoxPass.PasswordChar = '*';
            }
        }

        private void buttonRegSwap_Click(object sender, EventArgs e)
        {
            this.Hide();
            Regisrt reg_form = new Regisrt();
            reg_form.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
