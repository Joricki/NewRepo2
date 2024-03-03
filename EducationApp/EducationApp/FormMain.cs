using System;
using System.Windows.Forms;

namespace EducationApp
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        private Form acriveForm = null;
        private void openForm(Form childForm)
        {
            if (acriveForm != null)
                acriveForm.Close();
            acriveForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel2.Controls.Add(childForm);
            panel2.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            openForm(new FormTesting());
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            openForm(new FormTheoreticalMaterial());
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            //заполним персональный блок на главной форме
            label4.Text = $"{PersonalData.Role}:";
            label1.Text = $"{PersonalData.Fam} {PersonalData.Name}\r\n{PersonalData.FatherName}";
            //установим права досутпа в соответствии с ролью
            CheckRole(PersonalData.Role);
        }
        public string CheckRole(string inputRole) //определение роли и ее прав доступа к функционалу
        {
            switch (inputRole.ToUpper())
            {
                case ("ПРЕПОДАВАТЕЛЬ"):
                    guna2Button1.Dispose();
                    MessageBox.Show($"Добро пожаловать {PersonalData.Name} {PersonalData.FatherName}", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return inputRole;
                case ("СТУДЕНТ"):
                    guna2Button4.Dispose();
                    guna2Button6.Dispose();
                    MessageBox.Show($"Добро пожаловать {PersonalData.Name} {PersonalData.FatherName}", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return inputRole;
                default:
                    panel1.Dispose();
                    MessageBox.Show("Учетная запись некорректна.\rОбратитесь в тех. поддержку.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return inputRole;
            }
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            openForm(new FormManipStudents());
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            openForm(new FormManipBallStudent());
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            openForm(new FormPractical());
        }
    }
}
