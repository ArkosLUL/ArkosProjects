using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Algoritms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ToolTip toolTip1 = new ToolTip();
            
            toolTip1.SetToolTip(label1, "Открыть текстовый документ.");
        }

        AlbumsCollection AlbList = new AlbumsCollection();

        bool open = false;

        private void label1_Click_1(object sender, EventArgs e)
        {
            open = true;

            string fileNum = null;

            using (OpenFileDialog file = new OpenFileDialog())
            {
                file.InitialDirectory = "C:/Users/user/source/repos/WindowsFormsApp11/WindowsFormsApp11/bin/Debug";
                file.Filter = "txt files (*.txt)|*.txt";
                file.FilterIndex = 2;
                file.RestoreDirectory = true;

                if (file.ShowDialog() == DialogResult.OK)
                {
                    fileNum = file.FileName;
                }
            }

            if (fileNum != null)
            {
                string text = File.ReadAllText(fileNum);
                label4.Text = text;
                int i = 0;
                while (i < text.Length) 
                {
                    label4.Text = text;
                    string a = "";
                    string b = "";
                    int year;
                    while (i < text.Length && text[i] != ',') 
                    {
                        a += text[i];
                        i++;
                    }
                    i++;
                    while (i < text.Length && text[i] != '\r') 
                    {
                        b += text[i];
                        i++;
                    }
                    year = Convert.ToInt32(b);
                    AlbList.AddAlbum(new Album(year, a));
                }
                
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (!open)
            {
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                DialogResult result;
                string caption = "Ошибка!";
                string message = "Сначала выберите файл!";
                result = MessageBox.Show(message, caption, buttons);
            }

            else
            {
                AlbList.ShakerSort();

                label2.Text = AlbList.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!open)
            {
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                DialogResult result;
                string caption = "Ошибка!";
                string message = "Сначала выберите файл!";
                result = MessageBox.Show(message, caption, buttons);
            }

            else
            {
                AlbList.InsertionSort();

                label2.Text = AlbList.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!open)
            {
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                DialogResult result;
                string caption = "Ошибка!";
                string message = "Сначала выберите файл!";
                result = MessageBox.Show(message, caption, buttons);
            }

            else
            {
                AlbList.CombSort();

                label2.Text = AlbList.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!open)
            {
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                DialogResult result;
                string caption = "Ошибка!";
                string message = "Сначала выберите файл!";
                result = MessageBox.Show(message, caption, buttons);
            }

            else
            {
                AlbList.ShellSort();

                label2.Text = AlbList.ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AlbList.Quicksort();

            label2.Text = AlbList.ToString();
        }

        //string Key = textBox1.Text;
        private void button10_Click(object sender, EventArgs e)
        {

        }
    }
}
