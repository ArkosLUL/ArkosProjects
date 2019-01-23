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

/*
Курс: Алгоритмы и структуры данных
Лабораторная работа №1
ТЕМА: Базовые алгоритмы (алгоритмы поиска и сортировки структур данных(СД)).
ЦЕЛЬ: Изучить базовые алгоритмы.
Постановка задачи
Реализованы следующие алгоритмы Сортировки:
 1.Сортировка вставками
 2.Быстрая сортировка (Хоара)
 3.Сортировка Шелла
 4.Сортировка выбором
 5.Сортировка перемешеванием (шейкерная)
Реализованы следующие алгоритмы поиска:
 1.Бинарный поиск
 2.Интерполяционный поиск
 3.Линейный поиск
 4.Быстрый линейный поиск
 5.Сверхбыстрый линейный поиск
Выполнил:
Студент группы ПЗ - 17 - 1
Косогов Артем Сергеевич
хх.09.18
=== ОСОБЕННОСТИ РЕАЛИЗАЦИИ: ===
Выбор кнопки ""Открыть"" в меню ""Файл"" преобразует данные из текстового файла в список. Информирует, если файл заполнен некорректно.
Использованы стандартные библиотеки.
Очистка старых результатов производится после каждого нажатия кнопки сортировки или поиска.
*/

namespace AlgAndStructKosogovArtemPZ171
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Click_clue(object sender, EventArgs e)
        {
            MessageBox.Show(@"Курс: Алгоритмы и структуры данных
Лабораторная работа №1
ТЕМА: Базовые алгоритмы (алгоритмы поиска и сортировки структур данных(СД)).
ЦЕЛЬ: Изучить базовые алгоритмы.
Постановка задачи
Реализованы следующие алгоритмы Сортировки:
 1.Сортировка вставками
 2.Быстрая сортировка (Хоара)
 3.Сортировка Шелла
 4.Сортировка выбором
 5.Сортировка перемешеванием (шейкерная)
Реализованы следующие алгоритмы поиска:
 1.Бинарный поиск
 2.Интерполяционный поиск
 3.Линейный поиск
 4.Быстрый линейный поиск
 5.Сверхбыстрый линейный поиск
Выполнил:
Студент группы ПЗ - 17 - 1
Косогов Артем Сергеевич
хх.09.18
=== ОСОБЕННОСТИ РЕАЛИЗАЦИИ: ===
Выбор кнопки ""Открыть"" в меню ""Файл"" преобразует данные из текстового файла в список. Информирует, если файл заполнен некорректно.
Использованы стандартные библиотеки.
Очистка старых результатов производится после каждого нажатия кнопки сортировки или поиска.");
        }



        private void button1_Click(object sender, EventArgs e)
        {
            string fileName = null;

            using (OpenFileDialog openFileDialog1 = new OpenFileDialog())
            {
                openFileDialog1.InitialDirectory = Environment.CurrentDirectory;
                openFileDialog1.Filter = "txt files (*.txt)|*.txt";
                openFileDialog1.FilterIndex = 2;
                openFileDialog1.RestoreDirectory = true;

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    fileName = openFileDialog1.FileName;
                }
            }

            if (fileName != null)
            {
                listView1.Clear();
                listView2.Clear();
                string[] lines = File.ReadAllLines(fileName, Encoding.GetEncoding(1251));
                StaticCollection.AddElements(lines);
                if (StaticCollection.Items.Count != 0)
                {
                    listView1.View = View.Details;
                    listView1.Columns.Add("Ключ", listView1.Width / 2, HorizontalAlignment.Left);
                    listView1.Columns.Add("Значение", listView1.Width / 2, HorizontalAlignment.Left);
                    foreach (Item i in StaticCollection.Items)
                    {
                        listView1.Items.Add(Convert.ToString(i.key)).SubItems.Add(i.value);
                    }
                    button2.Enabled = true;
                    button3.Enabled = true;
                    button4.Enabled = true;
                    button5.Enabled = true;
                    button6.Enabled = true;
                    button7.Enabled = true;
                    button8.Enabled = true;
                    button9.Enabled = true;
                    button10.Enabled = true;
                    button11.Enabled = true;
                    textBox1.Enabled = true;
                    FileMenu.Enabled = true;
                    MessageBox.Show("Файл загружен. Количество элементов: " + StaticCollection.Items.Count, "Информация", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Некорректный файл.", "Ошибка", MessageBoxButtons.OK);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NonStaticCollection s = new NonStaticCollection();
            int counter;
            int comparison;
            s.InsertionSort(out counter, out comparison);
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show("Количество обменов: " + Convert.ToString(counter) + ", количество сравнений: " + Convert.ToString(comparison), "Отсортировано", buttons);
            s.Display(ref listView2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NonStaticCollection s = new NonStaticCollection();
            int counter;
            int comparison;
            s.ShellSort(out counter, out comparison);
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show("Количество обменов: " + Convert.ToString(counter) + ", количество сравнений: " + Convert.ToString(comparison), "Отсортировано", buttons);
            s.Display(ref listView2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            NonStaticCollection s = new NonStaticCollection();
            int counter;
            int comparison;
            s.SelectionSort(out counter, out comparison);
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show("Количество обменов: " + Convert.ToString(counter) + ", количество сравнений: " + Convert.ToString(comparison), "Отсортировано", buttons);
            s.Display(ref listView2);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            NonStaticCollection s = new NonStaticCollection();
            int counter;
            int comparison;
            s.QuickSort(out counter, out comparison);
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show("Количество обменов: " + Convert.ToString(counter) + ", количество сравнений: " + Convert.ToString(comparison), "Отсортировано", buttons);
            s.Display(ref listView2);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            NonStaticCollection s = new NonStaticCollection();
            int counter;
            int comparison;
            s.ShakerSort(out counter, out comparison);
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show("Количество обменов: " + Convert.ToString(counter) + ", количество сравнений: " + Convert.ToString(comparison), "Отсортировано", buttons);
            s.Display(ref listView2);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            NonStaticCollection s = new NonStaticCollection();
            int key = -1;
            try
            {
                key = Convert.ToInt32(textBox1.Text);
            }
            catch (Exception) { };
            if (key >= 0)
            {
                s.BubbleSort();
                int result;
                int counter;
                int comparisons;
                result = s.BinarySearch(key, out counter, out comparisons);
                string message;
                if (result >= 0)
                {
                    message = "Найденный элемент: " + s[result].value + ". Количество итераций: " + counter + ", количество сравнений: " + comparisons;
                }
                else
                {
                    message = "Элемент не найден. Количество итераций: " + counter + ", количество сравнений: " + comparisons;
                }
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, "Результат", buttons);
            }
            else
            {
                MessageBox.Show("Некорректный ключ.", "Ошибка", MessageBoxButtons.OK);
            }
            textBox1.Clear();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            NonStaticCollection s = new NonStaticCollection();
            int key = -1;
            try
            {
                key = Convert.ToInt32(textBox1.Text);
            }
            catch (Exception) { };
            if (key >= 0)
            {
                s.BubbleSort();
                int result;
                int counter;
                int comparisons;
                result = s.InterpolationSearch(key, out counter, out comparisons);
                string message;
                if (result >= 0)
                {
                    message = "Найденный элемент: " + s[result].value + ". Количество итераций: " + counter + ", количество сравнений: " + comparisons;
                }
                else
                {
                    message = "Элемент не найден. Количество итераций: " + counter + ", количество сравнений: " + comparisons;
                }
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, "Результат", buttons);
            }
            else
            {
                MessageBox.Show("Некорректный ключ.", "Ошибка", MessageBoxButtons.OK);
            }
            textBox1.Clear();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            NonStaticCollection s = new NonStaticCollection();
            int key = -1;
            try
            {
                key = Convert.ToInt32(textBox1.Text);
            }
            catch (Exception) { };
            if (key >= 0)
            {
                int result;
                int counter;
                int comparisons;
                result = s.LinearSearch(key, out counter, out comparisons);
                string message;
                if (result >= 0)
                {
                    message = "Найденный элемент: " + s[result].value + ". Количество итераций: " + counter + ", количество сравнений: " + comparisons;
                }
                else
                {
                    message = "Элемент не найден. Количество итераций: " + counter + ", количество сравнений: " + comparisons;
                }
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, "Результат", buttons);
            }
            else
            {
                MessageBox.Show("Некорректный ключ.", "Ошибка", MessageBoxButtons.OK);
            }
            textBox1.Clear();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            NonStaticCollection s = new NonStaticCollection();
            int key = -1;
            try
            {
                key = Convert.ToInt32(textBox1.Text);
            }
            catch (Exception) { };
            if (key >= 0)
            {
                int result;
                int counter;
                int comparisons;
                result = s.FastLinearSearch(key, out counter, out comparisons);
                string message;
                if (result >= 0)
                {
                    message = "Найденный элемент: " + s[result].value + ". Количество итераций: " + counter + ", количество сравнений: " + comparisons;
                }
                else
                {
                    message = "Элемент не найден. Количество итераций: " + counter + ", количество сравнений: " + comparisons;
                }
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, "Результат", buttons);
            }
            else
            {
                MessageBox.Show("Некорректный ключ.", "Ошибка", MessageBoxButtons.OK);
            }
            textBox1.Clear();
        }
        private void button11_Click_1(object sender, EventArgs e)
        {
            NonStaticCollection s = new NonStaticCollection();
            int key = -1;
            try
            {
                key = Convert.ToInt32(textBox1.Text);
            }
            catch (Exception) { };
            if (key >= 0)
            {
                int result;
                int counter;
                int comparisons;
                result = s.SuperFastLinearSearch(key, out counter, out comparisons);
                string message;
                if (result >= 0)
                {
                    message = "Найденный элемент: " + s[result].value + ". Количество итераций: " + counter + ", количество сравнений: " + comparisons;
                }
                else
                {
                    message = "Элемент не найден. Количество итераций: " + counter + ", количество сравнений: " + comparisons;
                }
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, "Результат", buttons);
            }
            else
            {
                MessageBox.Show("Некорректный ключ.", "Ошибка", MessageBoxButtons.OK);
            }
            textBox1.Clear();
        }

        private void ExitClick(object sender, EventArgs e)
        {
            Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "" && textBox3.Text != "")
            {
                if (StaticCollection.Items.Count != 0)
                {
                    try
                    {
                        StaticCollection.Items.Add(new Item(Convert.ToInt32(textBox2.Text), textBox3.Text));
                        listView1.Items.Add(Convert.ToString(StaticCollection.Items[StaticCollection.Items.Count - 1].key)).SubItems.Add(StaticCollection.Items[StaticCollection.Items.Count - 1].value);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Некорректный ключ.", "Ошибка", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    bool flag = true;
                    try
                    {
                        StaticCollection.Items.Add(new Item(Convert.ToInt32(textBox2.Text), textBox3.Text));
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Некорректный ключ.", "Ошибка", MessageBoxButtons.OK);
                        flag = false;
                    }
                    if (flag)
                    {
                        listView1.View = View.Details;
                        listView1.Columns.Add("Ключ", listView1.Width / 2, HorizontalAlignment.Left);
                        listView1.Columns.Add("Значение", listView1.Width / 2, HorizontalAlignment.Left);
                        listView1.Items.Add(Convert.ToString(StaticCollection.Items[StaticCollection.Items.Count - 1].key)).SubItems.Add(StaticCollection.Items[StaticCollection.Items.Count - 1].value);
                        button2.Enabled = true;
                        button3.Enabled = true;
                        button4.Enabled = true;
                        button5.Enabled = true;
                        button6.Enabled = true;
                        button7.Enabled = true;
                        button8.Enabled = true;
                        button9.Enabled = true;
                        button10.Enabled = true;
                        button11.Enabled = true;
                        textBox1.Enabled = true;
                        FileMenu.Enabled = true;
                    }
                }
                textBox2.Clear();
                textBox3.Clear();
            }
            else
            {
                MessageBox.Show("Не все поля заполнены.", "Ошибка", MessageBoxButtons.OK);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }
    }
}
