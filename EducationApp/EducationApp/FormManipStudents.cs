using System;
using System.Windows.Forms;

namespace EducationApp
{
    public partial class FormManipStudents : Form
    {
        DB db;
        DGVPrinter printer;
        public FormManipStudents()
        {
            db = new DB();
            printer = new DGVPrinter();
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (db.Execute($"delete Студенты where [id студента]={label3.Text}") != null)
            {
                SetDataCombobox();
                MessageBox.Show("Студент успешно удален", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void FormManipStudents_Load(object sender, EventArgs e)
        {
            db.ReturnData("select [id студента],Фамилия+' '+имя+' '+отчество as [ФИО], Группа, [Дата рождения] from студенты с", guna2DataGridView1);

            SetDataCombobox();
        }
        private void SetDataCombobox()
        {
            db.FillComboBox("select Фамилия+' '+Имя+' '+Отчество as ФИО FROM Студенты", "ФИО", guna2ComboBox1);
            if (guna2ComboBox1.Items.Count > 0)
            {
                guna2ComboBox1.StartIndex = 0;
            }
        }
        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label3.Text = db.GetSignleValue($"select [id студента] from студенты where Фамилия+' '+Имя+' '+Отчество=N'{guna2ComboBox1.SelectedItem}'", "ID Студента");
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(guna2TextBox1.Text) || string.IsNullOrEmpty(guna2TextBox2.Text) || string.IsNullOrEmpty(guna2TextBox3.Text) || string.IsNullOrEmpty(guna2TextBox4.Text))
            {
                MessageBox.Show("Заполните группу и ФИО.", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (db.Execute(" Insert into Студенты(Фамилия, Имя,Отчество, [Дата рождения], Группа)" +
                          $" values (N'{guna2TextBox1.Text}',N'{guna2TextBox2.Text}',N'{guna2TextBox3.Text}','{guna2DateTimePicker1.Value.ToString("yyyy.MM.dd")}',N'{guna2TextBox4.Text}')") != null)
            {
                SetDataCombobox();
                MessageBox.Show("Студент успешно добавлен.", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            string query = "select [id студента],Фамилия+' '+имя+' '+отчество as [ФИО], Группа, [Дата рождения] from студенты с";
            //если фильтр не пустой, то ищем с фильтром
            if (!string.IsNullOrEmpty(guna2TextBox5.Text))
            {
                switch (guna2ComboBox2.SelectedIndex)
                {
                    case 0:
                        query += $" where Фамилия+' '+Имя+' '+Отчество like N'%{guna2TextBox5.Text}%'";
                        break;
                    case 1:
                        query += $" where [Группа] = N'{guna2TextBox5.Text}'";
                        break;
                }
            }

            if (db.ReturnData(query, guna2DataGridView1) != null)
            {
                MessageBox.Show("Поиск успешно выполнен", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            printer.CreateReport("Выгрузка по студентам в система.", guna2DataGridView1);
        }
    }
}
