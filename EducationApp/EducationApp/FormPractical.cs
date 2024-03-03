﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EducationApp
{
    public partial class FormPractical : Form
    {
        private int BallStudent = 0;
        public FormPractical()
        {
            InitializeComponent();
        }

        private void FormPractical_Load(object sender, EventArgs e)
        {
            AddDirectory(treeView2);
        }
        public void View(string pdfFilePath, Patagames.Pdf.Net.Controls.WinForms.PdfViewer pdfium)
        {
            //проверка на случай возможных ошибок при открытии или битых файлов
            try
            {
                pdfium.LoadDocument(pdfFilePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка при просмотре PDF файла в методе 'ViewPDF.View'. Возможно, файл битый.\r\nОшибка: " + ex.Message, "Уведомдение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void AddDirectory(System.Windows.Forms.TreeView treeView)
        {
            try
            {
                string baseFolderName = "Практическое занятие 1";
                string fullPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $@"..\..\..\{baseFolderName}");

                DirectoryInfo dirInfo = new DirectoryInfo(fullPath);
                treeView.PathSeparator = "/";
                treeView.Nodes.Clear();

                TreeNode rootNode;
                rootNode = treeView.Nodes.Add(baseFolderName);
                treeView.Nodes[0].Expand();
                rootNode.Name = fullPath;

                AddTreeNode(rootNode, dirInfo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка при добавлении директории в древо файлов в методе AddDirectory: " + ex.Message, "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //для добавления содержимого папки в tree view.
        private void AddTreeNode(TreeNode treeNode, DirectoryInfo dirInfo)
        {
            try
            {
                //получаем директории
                foreach (var directory in dirInfo.GetDirectories())
                {
                    TreeNode myNode = treeNode.Nodes.Add(directory.Name);
                    myNode.Name = directory.FullName;
                    AddTreeNode(myNode, directory);
                }

                //получаем файлы
                foreach (var file in dirInfo.GetFiles())
                {
                    TreeNode myNode = treeNode.Nodes.Add(file.Name);
                    myNode.Name = file.FullName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка в методе AddTreeNode: " + ex.Message, "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            // Если это папка, не делаем ничего
            if (e.Node.Nodes.Count > 0)
            {
                return;
            }
            string filePath = e.Node.Name;
            View(filePath, pdfViewer1);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            switch (guna2ComboBox1.SelectedItem)
            {
                case "Вопрос №1":
                    if (guna2TextBox1.Text == "-100 23")
                    {
                        BallStudent++;
                    }
                    guna2ComboBox1.SelectedIndex = 1;
                    MessageBox.Show("Ответ зачтен!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Вопрос №2":
                    if (guna2TextBox1.Text == "3")
                    {
                        BallStudent++;
                    }
                    guna2ComboBox1.SelectedIndex = 2;
                    MessageBox.Show("Ответ зачтен!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Вопрос №3":
                    if (guna2TextBox1.Text == "4")
                    {
                        BallStudent++;
                    }
                    guna2ComboBox1.SelectedIndex = 3;
                    MessageBox.Show("Ответ зачтен!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case "Вопрос №4":
                    if (guna2TextBox1.Text == "3")
                    {
                        BallStudent++;
                    }
                    guna2Button1.Enabled = false;
                    MessageBox.Show($"Верно ответили на {BallStudent} из 4 заданий!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
        }
    }
}
