using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlgStr2Pavliuk
{
    public partial class Form1 : Form
    {
        Deque<string> FirstDeque = new Deque<string>();
        Deque<string> SecondDeque = new Deque<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void PushTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Unite1Btn_Click(object sender, EventArgs e)
        {
            SecondDeque.Unite(FirstDeque);
            WriteFirstDeque();
        }

        private void PushToHead1Btn_Click(object sender, EventArgs e)
        {
            FirstDeque.AddFirst(PushTextBox1.Text);
            WriteFirstDeque();
        }
        private void WriteFirstDeque()
        {
            dequeGridView1.Rows.Clear();
            foreach (var elem in FirstDeque)
            {
                dequeGridView1.Rows.Add(elem.ToString());
            }
        }

        private void PushToTail1Btn_Click(object sender, EventArgs e)
        {
            FirstDeque.AddLast(PushTextBox1.Text);
            WriteFirstDeque();
        }

        private void Peek1Btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(FirstDeque.First);
        }

        private void PopFirst1Btn_Click(object sender, EventArgs e)
        {
            FirstDeque.RemoveFirst();
            WriteFirstDeque();
        }

        private void PopLast1Btn_Click(object sender, EventArgs e)
        {
            FirstDeque.RemoveLast();
            WriteFirstDeque();
        }

        private void PeekLast1Btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(FirstDeque.Last);
        }

        private void Divide1Btn_Click(object sender, EventArgs e)
        {
            FirstDeque.Divide(Convert.ToInt32(DivideTextBox1.Text));
            WriteFirstDeque();
        }

        private void PushToHead2Btn_Click(object sender, EventArgs e)
        {
            SecondDeque.AddFirst(PushTextBox1.Text);
            WriteFirstDeque();
        }

        private void Copy2Btn_Click(object sender, EventArgs e)
        {
            SecondDeque.Copy(FirstDeque);
            WriteSecondDeque();
        }

        private void PushToHead2Btn_Click_1(object sender, EventArgs e)
        {
            SecondDeque.AddFirst(SecondPushTextBox.Text);
            WriteSecondDeque();
        }

        private void PushToTail2Btn_Click(object sender, EventArgs e)
        {
            SecondDeque.AddLast(SecondPushTextBox.Text);
            WriteSecondDeque();
        }
        private void WriteSecondDeque()
        {
            dequeGridView2.Rows.Clear();
            foreach (var elem in SecondDeque)
            {
                dequeGridView2.Rows.Add(elem.ToString());
            }
        }

        private void PopFirst2Btn_Click(object sender, EventArgs e)
        {
            SecondDeque.RemoveFirst();
            WriteSecondDeque();
        }

        private void PopLast2Btn_Click(object sender, EventArgs e)
        {
            SecondDeque.RemoveLast();
            WriteSecondDeque();
        }

        private void PeekFirst2Btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(SecondDeque.First);
        }

        private void PeekLast2Btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(SecondDeque.Last);
        }

        private void Unite2Btn_Click(object sender, EventArgs e)
        {
            FirstDeque.Unite(SecondDeque);
            WriteSecondDeque();
        }

        private void Divide2Btn_Click(object sender, EventArgs e)
        {
            SecondDeque.Divide(Convert.ToInt32(SecondDivideTextBox.Text));
            WriteSecondDeque();
        }

        private void Clear1Btn_Click(object sender, EventArgs e)
        {
            FirstDeque.Clear();
            WriteFirstDeque();
        }

        private void Clear2Btn_Click(object sender, EventArgs e)
        {
            SecondDeque.Clear();
            WriteSecondDeque();
        }

        private void Copy1Btn_Click(object sender, EventArgs e)
        {
            FirstDeque.Copy(SecondDeque);
            WriteFirstDeque();
        }
    }
}
