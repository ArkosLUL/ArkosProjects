using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgStrLab2KosogovArtemPZ_17_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Stack<string> firstTableStack = new Stack<string>();
        Stack<string> secondTableStack = new Stack<string>();

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                firstTableStack.Push(PushTextBox1.Text);
                ShowFirstStack();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string temp = firstTableStack.Pop();
                MessageBox.Show(temp, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowFirstStack();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(firstTableStack.Peek(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Unite1Btn_Click(object sender, EventArgs e)
        {
            try
            {
                secondTableStack.Concatenate(firstTableStack);
                ShowFirstStack();
                ShowSecondStack();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void Divide1Btn_Click(object sender, EventArgs e)
        {
            try
            {
                secondTableStack = firstTableStack.Divide(Convert.ToInt32(DivideTextBox1.Text));
                ShowFirstStack();
                ShowSecondStack();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Copy1Btn_Click(object sender, EventArgs e)
        {
            try
            {
                secondTableStack = Stack<string>.Copy(firstTableStack);
                ShowSecondStack();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ShowFirstStack()
        {
            SizeLabel12.Text = firstTableStack.Counter.ToString();
            dataGridView1.Rows.Clear();
            foreach (var elem in firstTableStack)
            {
                dataGridView1.Rows.Add(elem.ToString());
            }
        }

        private void Push2Btn_Click(object sender, EventArgs e)
        {
            try
            {
                secondTableStack.Push(PushTextBox2.Text);
                ShowSecondStack();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Pop2Btn_Click(object sender, EventArgs e)
        {
            try
            {
                string temp = secondTableStack.Pop();
                MessageBox.Show(temp, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ShowSecondStack();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }

        private void Peek2Btn_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show(secondTableStack.Peek(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    

        private void Unite2Btn_Click(object sender, EventArgs e)
        {
            try
            {
                firstTableStack.Concatenate(secondTableStack);
                ShowSecondStack();
                ShowFirstStack();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Divide2Btn_Click(object sender, EventArgs e)
        {
            try
            {
                firstTableStack = secondTableStack.Divide(Convert.ToInt32(DivideTextBox2.Text));
                ShowSecondStack();
                ShowFirstStack();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Copy2Btn_Click(object sender, EventArgs e)
        {
            try
            {
                firstTableStack = Stack<string>.Copy(secondTableStack);
                ShowFirstStack();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ShowSecondStack()
        {
            SizeLabel22.Text = secondTableStack.Counter.ToString();
            dataGridView2.Rows.Clear();
            foreach (var elem in secondTableStack)
            {
                dataGridView2.Rows.Add(elem.ToString());
            }
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(@" Курс ""Алгоритмы и структуры данных""
  Лабораторная работа № 2


  ТЕМА:
       Спецификация и реализация линейных структур данных.
  ЦЕЛЬ: 
       Научиться специфицировать и реализовывать линейные структуры данных.
  ПОСТАНОВКА ЗАДАЧИ:
       Реализовать полную систему операций для работы с неограниченным стеком(на базе списка).
  ВЫПОЛНИЛ: 
студент группы ПЗ - 17 - 1
Косогов Артем Сергеевич
12.11.2018


  ОСОБЕННОСТИ РЕАЛИЗАЦИИ:
    -Программа написана на ЯВУ C#.
    - Стек реализован на базе списка.
    - Возможность добавления элементов в стек с помощью файла либо вручную.
    - Удаление элементов.
    - Объединение стеков.
    - Деление стека на два.
    - Возможность узнать количество узлов в стеке.
    - Копирование и вставка содержимого стека.
    - Поддерживается дружественная обработка ошибок.", "Hat", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.InitialDirectory = Environment.CurrentDirectory;
                ofd.Filter = "*.txt | *.TXT";
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    string[] context = File.ReadAllLines(ofd.FileName, System.Text.Encoding.GetEncoding(1251));
                    foreach (var item in context)
                    {
                        firstTableStack.Push(item);
                    }
                    ShowFirstStack();
                }
            }
        }

        private void deleteStack1Btn_Click(object sender, EventArgs e)
        {
            firstTableStack.DeleteStack();
            ShowFirstStack();
        }

        private void deleteStack2Btn_Click(object sender, EventArgs e)
        {
            secondTableStack.DeleteStack();
            ShowSecondStack();
        }
    }
}
