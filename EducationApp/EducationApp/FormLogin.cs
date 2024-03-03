using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EducationApp
{
    public partial class FormLogin : Form
    {
        private DB db;
        public FormLogin()
        {
            db = new DB();
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            PersonalData PersData = new PersonalData();
            string Login = guna2TextBox1.Text;
            string Password = guna2TextBox2.Text;

            if (PersData.SetPersonalData(Login, Password))
            {
                FormMain FM = new FormMain();
                FM.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Авторизоваться не удалось.\r\nПроверьте коректность логина и пароля.", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                guna2TextBox2.UseSystemPasswordChar = true;
            else
                guna2TextBox2.UseSystemPasswordChar = false;
        }
    }
}
