using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        Stack<string> firstTableStack;
        Stack<string> secondTableStack;

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (firstTableStack == null)
            {
                firstTableStack = new Stack<string>();
            }

            firstTableStack.Push(PushTextBox1.Text);
            ShowFirstStack();
        }

        private void ShowFirstStack()
        {
            if(firstTableStack == null)
            {
                Pop1Btn.Enabled = false;
            }
            dataGridView1.Rows.Clear();
            foreach (var elem in firstTableStack)
            {
                dataGridView1.Rows.Add(elem.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (firstTableStack == null)
            {
                firstTableStack = new Stack<string>();
            }

            string temp = firstTableStack.Pop();
            MessageBox.Show(temp, "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ShowFirstStack();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(firstTableStack.Peek(), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Unite1Btn_Click(object sender, EventArgs e)
        {
            secondTableStack.Concatenate(firstTableStack);
            ShowFirstStack();
        }

        private void ShowSecondStack()
        {
            if (secondTableStack == null)
            {
                Pop1Btn.Enabled = false;
            }
            dataGridView2.Rows.Clear();
            foreach (var elem in secondTableStack)
            {
                dataGridView2.Rows.Add(elem.ToString());
            }
        }

        private void Divide1Btn_Click(object sender, EventArgs e)
        {

        }

        private void Copy1Btn_Click(object sender, EventArgs e)
        {
            secondTableStack = Stack<string>.Copy(firstTableStack);
            ShowSecondStack();
        }

        private void Push2Btn_Click(object sender, EventArgs e)
        {
            if (secondTableStack == null)
            {
                secondTableStack = new Stack<string>();
            }

            secondTableStack.Push(PushTextBox2.Text);
            ShowSecondStack();
        }
    }
}
