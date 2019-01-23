using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kas_alg_lab_1
{
    public partial class Form1 : Form
    {
        text
        DataGridView dataGridView;
        public Form1()
        {
            InitializeComponent();
        }

        private void Файл_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
      
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog1 = new OpenFileDialog())
            {
                openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    MessageBox.Show(openFileDialog1.FileName);
                    FileWork.ReadFile(ref dictoanary, openFileDialog1.FileName);
                    dataGridView.Columns.Add("firstcolumn", "Ключ");
                    dataGridView.Columns.Add("firstcolumn", "Значение");
                    for (int k = 0; k < dictoanary.Length; k++)
                    {
                        dataGridView1.Rows.Add(new object[] { dictoanary[k].Key, dictoanary[k].Value });




                    }
                }

            }
        }
    }
}
