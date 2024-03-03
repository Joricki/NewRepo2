using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace EducationApp
{
    public partial class FormTesting : Form
    {
        private int scrore = 0; //баллов у студента
        private int maxBall = 5;//максимальный балл. Ониже макс кол-во вопросов
        private int currentTestNumber = 0; //текуший номер вопрос
        private int ActiveResponseOption = 0; //вариант ответа который выбрал студент
        private DB db;
        public FormTesting()
        {
            db = new DB();
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            //если это первый вопрос, то выведем условия теста.
            if (currentTestNumber == 0)
            {
                DialogResult result = MessageBox.Show("Вы уверены, что хотите начать тестирование?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                //если нажал "нет"
                if (result != DialogResult.Yes)
                {
                    MessageBox.Show("Действие отменено.", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                currentTestNumber++; //начинаем с первого вопроса
                SetVisibleQuestionTest(true);//сделаем видимыми все необходимое для теста 
                guna2Button1.Visible = false;//уберем кнопку "Начать"
                label1.Visible = false;//скроем текст "Нажмите Начать"
                guna2Button3.Enabled = false; //заблокируем прохождение кнопки "Начать" На втором тесте. Что бы не шло два теста параллельно.
                guna2Button2.PerformClick();//вызовем ручной клик кнопки "Далее".
            }
        }
        private void SetVisibleQuestionTest(bool isVisible)
        {
            if (isVisible == true)
            {
                groupBox1.Visible = true;
                label3.Visible = true;
                guna2RadioButton1.Visible = true;
                guna2RadioButton2.Visible = true;
                guna2RadioButton3.Visible = true;
                guna2RadioButton4.Visible = true;
            }
            else
            {
                groupBox1.Visible = false;
                label3.Visible = false;
                guna2RadioButton1.Visible = false;
                guna2RadioButton2.Visible = false;
                guna2RadioButton3.Visible = false;
                guna2RadioButton4.Visible = false;
            }
        }
        private void SetVisibleQuestionTest2(bool isVisible)
        {
            if (isVisible == true)
            {
                guna2GroupBox1.Visible = true;
                label4.Visible = true;
                guna2RadioButton8.Visible = true;
                guna2RadioButton7.Visible = true;
                guna2RadioButton6.Visible = true;
                guna2RadioButton5.Visible = true;
            }
            else
            {
                guna2GroupBox1.Visible = false;
                label4.Visible = false;
                guna2RadioButton8.Visible = false;
                guna2RadioButton7.Visible = false;
                guna2RadioButton6.Visible = false;
                guna2RadioButton5.Visible = false;
            }
        }
        //здесь храним информацию о тесте #1
        private void GetQuestion(int question)
        {
            groupBox1.Text = $"Вопрос {question}";
            switch (question)
            {
                case 1:
                    label3.Text = "Алгоритм решения задачи - это…";
                    guna2RadioButton1.Text = "1. Специальная программа, которая преобразует последовательность команд на язык машины";
                    guna2RadioButton2.Text = "2. Область оперативной памяти, где можно выделять отдельные участки для размещения данных и освобождать их";
                    guna2RadioButton3.Text = "3. Точное предписание, определяющее процесс перехода от исх. данных к рез-там, обладающее определенным св-вом"; //+
                    guna2RadioButton4.Text = "4. Запись последовательности выполнения команд на языке программирования с использованием подпрограмм";
                    break;
                case 2:
                    label3.Text = "Какие виды алгоритмов существуют в языке Turbo Pascal";
                    guna2RadioButton1.Text = "1. Составной, оперативный, выделенный";
                    guna2RadioButton2.Text = "2. Встроенный, внешний, повторный";
                    guna2RadioButton3.Text = "3. Последовательный, групповой, повторений";
                    guna2RadioButton4.Text = "4. Линейный, ветвления, циклический"; //+
                    break;
                case 3:
                    label3.Text = "Пояснить свойство массовости алгоритма:";
                    guna2RadioButton1.Text = "1. Алгоритм выполняется за определенное число шагов";
                    guna2RadioButton2.Text = "2. Алгоритм должен иметь данные, чьи значения должны поступать в начале выполнения алгоритма";
                    guna2RadioButton3.Text = "3. Алгоритм приводит от выходных данных к результату за конечное число шагов";
                    guna2RadioButton4.Text = "4. Алгоритм применяется не для одной задачи, а для любой задачи данного класса"; //+
                    break;
                case 4:
                    label3.Text = "За что отвечает свойство потенциальной осуществимости алгоритма?";
                    guna2RadioButton1.Text = "1. Алгоритм выполняется за определенное число шагов";
                    guna2RadioButton2.Text = "2. Алгоритм применяется не для одной задачи, а для любой задачи данного класса";
                    guna2RadioButton3.Text = "3. Алгоритм должен иметь данные, чьи значения должны поступать в начале выполнения алгоритма";
                    guna2RadioButton4.Text = "4. Алгоритм приводит от выходных данных к результату за конечное число шагов"; //+
                    break;
                case 5:
                    label3.Text = "Что понимают под дискретным характером алгоритма?";
                    guna2RadioButton1.Text = "1. Алгоритм выполняется за определенное число шагов";//+
                    guna2RadioButton2.Text = "2. Алгоритм применяется не для одной задачи, а для любой задачи данного класса";
                    guna2RadioButton3.Text = "3. Алгоритм приводит от выходных данных к результату за конечное число шагов";
                    guna2RadioButton4.Text = "4. Алгоритм должен иметь данные, чьи значения должны поступать в начале выполнения алгоритма";
                    break;
            }
        }
        //здесь храним информацию о тесте #1
        private void GetQuestion2(int question)
        {
            guna2GroupBox1.Text = $"Вопрос {question}";
            switch (question)
            {
                case 1:
                    label4.Text = "Алгоритм решения задачи - это…";
                    guna2RadioButton8.Text = "1. Специальная программа, которая преобразует последовательность команд на язык машины";
                    guna2RadioButton7.Text = "2. Область оперативной памяти, где можно выделять отдельные участки для размещения данных и освобождать их";
                    guna2RadioButton6.Text = "3. Точное предписание, определяющее процесс перехода от исх. данных к рез-там, обладающее определенным св-вом"; //+
                    guna2RadioButton5.Text = "4. Запись последовательности выполнения команд на языке программирования с использованием подпрограмм";
                    break;
                case 2:
                    label4.Text = "Какие виды алгоритмов существуют в языке Turbo Pascal";
                    guna2RadioButton8.Text = "1. Составной, оперативный, выделенный";
                    guna2RadioButton7.Text = "2. Встроенный, внешний, повторный";
                    guna2RadioButton6.Text = "3. Последовательный, групповой, повторений";
                    guna2RadioButton5.Text = "4. Линейный, ветвления, циклический"; //+
                    break;
                case 3:
                    label4.Text = "Пояснить свойство массовости алгоритма:";
                    guna2RadioButton8.Text = "1. Алгоритм выполняется за определенное число шагов";
                    guna2RadioButton7.Text = "2. Алгоритм должен иметь данные, чьи значения должны поступать в начале выполнения алгоритма";
                    guna2RadioButton6.Text = "3. Алгоритм приводит от выходных данных к результату за конечное число шагов";
                    guna2RadioButton5.Text = "4. Алгоритм применяется не для одной задачи, а для любой задачи данного класса"; //+
                    break;
                case 4:
                    label4.Text = "За что отвечает свойство потенциальной осуществимости алгоритма?";
                    guna2RadioButton8.Text = "1. Алгоритм выполняется за определенное число шагов";
                    guna2RadioButton7.Text = "2. Алгоритм применяется не для одной задачи, а для любой задачи данного класса";
                    guna2RadioButton6.Text = "3. Алгоритм должен иметь данные, чьи значения должны поступать в начале выполнения алгоритма";
                    guna2RadioButton5.Text = "4. Алгоритм приводит от выходных данных к результату за конечное число шагов"; //+
                    break;
                case 5:
                    label4.Text = "Что понимают под дискретным характером алгоритма?";
                    guna2RadioButton8.Text = "1. Алгоритм выполняется за определенное число шагов";//+
                    guna2RadioButton7.Text = "2. Алгоритм применяется не для одной задачи, а для любой задачи данного класса";
                    guna2RadioButton6.Text = "3. Алгоритм приводит от выходных данных к результату за конечное число шагов";
                    guna2RadioButton5.Text = "4. Алгоритм должен иметь данные, чьи значения должны поступать в начале выполнения алгоритма";
                    break;
            }
        }
        //от теста #1. здесь храним правильные ответы и в зависимости от этого увеличиваем оценку студенту.
        //Передаем номер вопроса и вариант ответа 
        private int CheckAnswerForCorrectness(int question, int AnswerOption)
        {
            // Создайте словарь для хранения правильных ответов
            Dictionary<int, int> correctAnswers = new Dictionary<int, int>
            {
                //вопрос;верный ответ;
                {1, 3},
                {2, 4},
                {3, 4},
                {4, 4},
                {5, 1}
            };

            // Добавим 1 балл, если верно ответил
            if (correctAnswers.ContainsKey(question) && correctAnswers[question] == AnswerOption)
            {
                return 1;
            }
            return 0;
        }
        //от теста #2. здесь храним правильные ответы и в зависимости от этого увеличиваем оценку студенту.
        //Передаем номер вопроса и вариант ответа 
        private int CheckAnswerForCorrectness2(int question, int AnswerOption)
        {
            // Создайте словарь для хранения правильных ответов
            Dictionary<int, int> correctAnswers = new Dictionary<int, int>
            {
                //вопрос;верный ответ;
                {1, 3},
                {2, 4},
                {3, 4},
                {4, 4},
                {5, 1}
            };

            // Добавим 1 балл, если верно ответил
            if (correctAnswers.ContainsKey(question) && correctAnswers[question] == AnswerOption)
            {
                return 1;
            }
            return 0;
        }
        //сбросить текущий выбор. Тест #1
        private void ResetSelection()
        {
            guna2RadioButton1.Checked = false;
            guna2RadioButton2.Checked = false;
            guna2RadioButton3.Checked = false;
            guna2RadioButton4.Checked = false;
        }
        //сбросить текущий выбор. Тест #2
        private void ResetSelection2()
        {
            guna2RadioButton8.Checked = false;
            guna2RadioButton7.Checked = false;
            guna2RadioButton6.Checked = false;
            guna2RadioButton5.Checked = false;
        }

        private void FormTesting_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = false;//при загрузке скроем блок с вопросами и ответами #1 теста
            guna2GroupBox1.Visible = false;//при загрузке скроем блок с вопросами и ответами #2 теста

            //->Установим доступ к тестам, в завимисоти от прохождения.
            //Первый тест
            if (Convert.ToInt32(db.GetSignleValue($"select count(*) as [Количество] from Тесты where [Наименование теста]=N'Практический тест №1' and [id студента]={PersonalData.IdStudentOrTeacnher}", "Количество")) == 1)
            {
                //тест уже пройден студентом
                guna2Button1.Visible = false;
                label1.Text = "Тест уже пройден";
            }
            //Второй тест
            if (Convert.ToInt32(db.GetSignleValue($"select count(*) as [Количество] from Тесты where [Наименование теста]=N'Практический тест №2' and [id студента]={PersonalData.IdStudentOrTeacnher}", "Количество")) == 1)
            {
                //тест уже пройден студентом
                guna2Button3.Visible = false;
                label2.Text = "Тест уже пройден";
            }
            //<-
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            //проверим, что вопрос не последний
            if (currentTestNumber <= maxBall)
            {
                //заполним форму данными(номер вопроса, вопрос, варианты ответа)
                GetQuestion(currentTestNumber);
                //если студент ничего не выбрал. То говорим, что бы выбрать хотя-бы один вариант
                //ActiveResponseOption==-1 Это выбор несуществующего варианта ответа, если студент не выбрал вариант ответа, то тест пропускат вопрос.
                if (ActiveResponseOption == -1 || guna2RadioButton1.Checked || guna2RadioButton2.Checked || guna2RadioButton3.Checked || guna2RadioButton4.Checked)
                {
                    //посмотрим какой вариант выбран
                    ActiveResponseOption = guna2RadioButton1.Checked ? 1 : 0;
                    ActiveResponseOption = guna2RadioButton2.Checked ? 2 : ActiveResponseOption;
                    ActiveResponseOption = guna2RadioButton3.Checked ? 3 : ActiveResponseOption;
                    ActiveResponseOption = guna2RadioButton4.Checked ? 4 : ActiveResponseOption;
                    //оценим выбор студента(+1 или +0)
                    scrore += CheckAnswerForCorrectness(currentTestNumber, ActiveResponseOption);
                    //сбросим выбраный вариант ответа
                    ResetSelection();
                    //перейдем к следующему вопросу
                    currentTestNumber++;
                    //заполним форму следующим вопросом
                    GetQuestion(currentTestNumber);
                    //обнулим выбраный вариант ответа. 
                    ActiveResponseOption = 0;
                }
            }

            //проверим что это последний вопрос
            if (currentTestNumber > maxBall)
            {
                SetVisibleQuestionTest(false); //скроем все элементы
                groupBox1.Text = string.Empty; //сбросим номер теста.
                guna2Button2.Visible = false; //скроем кнопку "ответить"
                guna2Button3.Enabled = true;//вернем кнопку "Начать" с теста #2.

                //->Отобразим текст, соответствующий ситуации и переместим его левее, чем было.
                label1.Visible = true;
                label1.Text = "Тест уже пройден.";
                //<-

                //->зафиксируем прохождение теста
                db.Execute("insert into Тесты ([ID Студента],[Оценка],[Наименование теста])" +
                 $" values ({PersonalData.IdStudentOrTeacnher},{scrore},N'Практический тест №1')");
                //<-

                MessageBox.Show($"Верно {scrore} из {maxBall} впоросов.", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //->вернем все значения переменных обратно. 
                scrore = 0; //баллов у студента
                maxBall = 5;//максимальный балл. Ониже макс кол-во вопросов
                currentTestNumber = 0; //текуший номер вопрос
                ActiveResponseOption = 0; //вариант ответа который выбрал студент
                //<-
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabControl1_TabIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            //если это первый вопрос, то выведем условия теста.
            if (currentTestNumber == 0)
            {
                DialogResult result = MessageBox.Show("Вы уверены, что хотите начать тестирование?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                //если нажал "нет"
                if (result != DialogResult.Yes)
                {
                    MessageBox.Show("Действие отменено.", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                currentTestNumber++; //начинаем с первого вопроса
                SetVisibleQuestionTest2(true);//сделаем видимыми все необходимое для теста 
                guna2Button3.Visible = false;//уберем кнопку "Начать"
                label2.Visible = false;//скроем текст "Нажмите Начать"
                guna2Button1.Enabled = false; //заблокируем прохождение кнопки "Начать" На ПЕРВОМ тесте. Что бы не шло два теста параллельно.
                guna2Button4.PerformClick();//вызовем ручной клик кнопки "Далее".
            }
        }

        private void guna2Button4_Click_1(object sender, EventArgs e)
        {
            //проверим, что вопрос не последний
            if (currentTestNumber <= maxBall)
            {
                //заполним форму данными(номер вопроса, вопрос, варианты ответа)
                GetQuestion2(currentTestNumber);
                //если студент ничего не выбрал. То говорим, что бы выбрать хотя-бы один вариант
                //ActiveResponseOption==-1 Это выбор несуществующего варианта ответа, если студент не выбрал вариант ответа, то тест пропускат вопрос.
                if (ActiveResponseOption == -1 || guna2RadioButton8.Checked || guna2RadioButton7.Checked || guna2RadioButton6.Checked || guna2RadioButton5.Checked)
                {
                    //посмотрим какой вариант выбран
                    ActiveResponseOption = guna2RadioButton8.Checked ? 1 : 0;
                    ActiveResponseOption = guna2RadioButton7.Checked ? 2 : ActiveResponseOption;
                    ActiveResponseOption = guna2RadioButton6.Checked ? 3 : ActiveResponseOption;
                    ActiveResponseOption = guna2RadioButton5.Checked ? 4 : ActiveResponseOption;
                    //оценим выбор студента(+1 или +0)
                    scrore += CheckAnswerForCorrectness2(currentTestNumber, ActiveResponseOption);
                    //сбросим выбраный вариант ответа
                    ResetSelection2();
                    //перейдем к следующему вопросу
                    currentTestNumber++;
                    //заполним форму следующим вопросом
                    GetQuestion2(currentTestNumber);
                    //обнулим выбраный вариант ответа. 
                    ActiveResponseOption = 0;
                }
            }

            //проверим что это последний вопрос
            if (currentTestNumber > maxBall)
            {
                SetVisibleQuestionTest2(false); //скроем все элементы
                guna2GroupBox1.Text = string.Empty; //сбросим номер теста.
                guna2Button4.Visible = false; //скроем кнопку "ответить"
                guna2Button1.Enabled = true;//вернем кнопку "Начать" с теста #1.

                //->Отобразим текст, соответствующий ситуации и переместим его левее, чем было.
                label2.Visible = true;
                label2.Text = "Тест уже пройден.";
                //<-

                //->зафиксируем прохождение теста
                db.Execute("insert into Тесты ([ID Студента],[Оценка],[Наименование теста])" +
                 $" values ({PersonalData.IdStudentOrTeacnher},{scrore},N'Практический тест №2')");
                //<-

                MessageBox.Show($"Верно {scrore} из {maxBall} впоросов.", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //->вернем все значения переменных обратно.
                scrore = 0; //баллов у студента
                maxBall = 5;//максимальный балл. Ониже макс кол-во вопросов
                currentTestNumber = 0; //текуший номер вопрос
                ActiveResponseOption = 0; //вариант ответа который выбрал студент
                //<-
            }
        }
    }
}
