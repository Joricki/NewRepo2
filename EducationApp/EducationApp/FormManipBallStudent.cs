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
    public partial class FormManipBallStudent : Form
    {
        DB db;
        DGVPrinter printer;
        public FormManipBallStudent()
        {
            db = new DB();
            printer = new DGVPrinter();
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            printer.CreateReport("Выгрузка информации об оценках", guna2DataGridView1);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string query = "select т.[ID Студента],[Наименование теста], Concat(Фамилия,' ',Имя,' ',Отчество) as ФИО, Оценка as Баллов\r\nfrom тесты т\r\nleft join студенты с on с.[ID Студента] = т.[ID Студента]";
            //если фильтр не пустой, то ищем с фильтром
            if (!string.IsNullOrEmpty(guna2TextBox1.Text))
            {
                switch (guna2ComboBox1.SelectedIndex)
                {
                    case 0:
                        query += $" where Фамилия+' '+Имя+' '+Отчество like N'%{guna2TextBox1.Text}%'";
                        break;
                    case 1:
                        query += $" where [Наименование теста] = N'{guna2TextBox1.Text}'";
                        break;
                }
            }

            if (db.ReturnData(query, guna2DataGridView1) != null)
            {
                MessageBox.Show("Поиск успешно выполнен", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FormManipBallStudent_Load(object sender, EventArgs e)
        {
            string query = "select т.[ID Студента],[Наименование теста], Concat(Фамилия,' ',Имя,' ',Отчество) as ФИО, Оценка as Баллов\r\nfrom тесты т\r\nleft join студенты с on с.[ID Студента] = т.[ID Студента]";
            db.ReturnData(query, guna2DataGridView1);
        }
    }
}
