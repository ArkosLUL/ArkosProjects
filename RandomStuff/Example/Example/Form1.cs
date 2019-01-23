using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace Example
{
    public partial class FormGraphics : Form
    {
        public FormGraphics()
        {
            InitializeComponent();
        }

        private void buttonDrawRectangle_Click(object sender, EventArgs e)
        {
            Graphics formGraphics = this.CreateGraphics();
            Pen myPen = new Pen(Color.Red);
            formGraphics.Clear(Color.White);
            formGraphics.DrawRectangle(myPen, 50, 30, 150, 180);
        }

        private void buttonFillRectangle_Click(object sender, EventArgs e)
        {
            Graphics formGraphics = this.CreateGraphics();
            SolidBrush myBrush = new SolidBrush(Color.Red);
            formGraphics.Clear(Color.White);
            formGraphics.FillRectangle(myBrush, 50, 30, 150, 180);
        }

        private void buttonMoveRectangle_Click(object sender, EventArgs e)
        {
        
            Graphics formGraphics = this.CreateGraphics();
            SolidBrush myBrush = new SolidBrush(Color.Red);
            for (int i = 0; i < 1000; i += 1)
            {
                formGraphics.FillRectangle(myBrush, i + 50, i + 30, 150, 180);
                Thread.Sleep(10);
                formGraphics.Clear(Color.White);
            }
        }
    }
}
