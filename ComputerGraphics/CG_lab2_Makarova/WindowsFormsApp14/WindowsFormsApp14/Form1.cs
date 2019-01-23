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
namespace WindowsFormsApp14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label2.Visible = false;
        }

        static List<Points> _3DPoints = new List<Points>();
        static List<Points> arr = new List<Points>();

        bool BoardsCheck()
        {
            foreach (Points p in _3DPoints)
            {
                if (p.X2d > pictureBox2.Width / 2 || p.X2d < (pictureBox2.Width / 2) * -1)
                {
                    return false;
                }
                if (p.Y2d > pictureBox2.Height / 2 || p.Y2d < (pictureBox2.Height / 2) * -1)
                {
                    return false;
                }
            }
            return true;
        }

        private void To2d()
        {
            foreach (Points i in _3DPoints)
            {
                i.X2d = i.X / (1 - i.Z / 200);
                i.Y2d = i.Y / (1 - i.Z / 200);
            }
        }

        private void Correction()
        {
            int i = 0;
            //do
            //{
            //    i--;
            //    Transp(36, 36, i);
            //}
            //while (!BoardsCheck());

            _3DPoints.Clear();

            for (i = 0; i < arr.Count; i++) 
            {
                _3DPoints.Add(new Points(arr[i].X, arr[i].Y, arr[i].Z));
            }
            Drawing();
        }

        int[,] matrix;

        Graphics f;
        Graphics g;
        Bitmap b;

        public void Drawing()
        {
            if (!BoardsCheck())
            {
                Correction();
                MessageBox.Show("Выход за границы.", "Ошибка!");
                To2d();
            }
            b = new Bitmap(pictureBox2.Width, pictureBox2.Height);
            int W = pictureBox2.Width, H = pictureBox2.Height;
            g = f = Graphics.FromImage(b);
            Pen gr = new Pen(Color.RosyBrown);
            Pen pen = new Pen(Color.DarkRed);
            g.DrawLine(gr, W / 2, 0, W / 2, H);
            g.DrawLine(gr, 0, H / 2, W, H / 2);
            f.TranslateTransform(W / 2, W / 2);
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = i; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == 1)
                    {
                        f.DrawLine(pen, _3DPoints[i].X2d, _3DPoints[i].Y2d, _3DPoints[j].X2d, _3DPoints[j].Y2d);
                    }
                }
            }

            for (int i = 0, k = matrix.GetLength(0); i < matrix.GetLength(0); i++, k++)
            {
                for (int j = 0, n = matrix.GetLength(1); j < matrix.GetLength(1); j++, n++)
                {
                    if (matrix[i, j] == 1)
                    {
                        f.DrawLine(pen, _3DPoints[k].X2d, _3DPoints[k].Y2d, _3DPoints[n].X2d, _3DPoints[n].Y2d);
                    }
                }
            }

            for (int i = 0, j = _3DPoints.Count / 2; j < _3DPoints.Count; i++, j++)
            {
                f.DrawLine(pen, _3DPoints[i].X2d, _3DPoints[i].Y2d, _3DPoints[j].X2d, _3DPoints[j].Y2d);
            }
            pictureBox2.Image = b;
        }

        private void Transp(float x, float y, float z)
        {
            float dx = x - _3DPoints[2].X;
            float dy = y - _3DPoints[2].Y;
            float dz = z - _3DPoints[2].Z;
            for (int i = 0; i < _3DPoints.Count; i++)
            {
                float[] a = new float[] { _3DPoints[i].X, _3DPoints[i].Y, _3DPoints[i].Z, 1 };
                float[,] b = new float[,] { { 1, 0, 0, 0 },
                                            { 0, 1, 0, 0 },
                                            { 0, 0, 1, 0 },
                                            { dx, dy, dz, 1 } };
                float[] r = new float[b.GetLength(1)];
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    for (int k = 0; k < b.GetLength(0); k++)
                    {
                        r[j] += a[k] * b[k, j];
                    }
                }
                _3DPoints[i].X = r[0];
                _3DPoints[i].Y = r[1];
                _3DPoints[i].Z = r[2];
            }
            To2d();
            Drawing();
        }

        private void Scaling(float x, float y, float z)
        {
            for (int i = 0; i < _3DPoints.Count; i++)
            {
                float[] a = new float[] { _3DPoints[i].X, _3DPoints[i].Y, _3DPoints[i].Z, 1 };
                float[,] b = new float[,] { { x, 0, 0, 0 },
                                            { 0, y, 0, 0 },
                                            { 0, 0, z, 0 },
                                            { 0, 0, 0, 1 } };
                float[] r = new float[b.GetLength(1)];
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    for (int k = 0; k < b.GetLength(0); k++)
                    {
                        r[j] += a[k] * b[k, j];
                    }
                }

                _3DPoints[i].X = r[0];
                _3DPoints[i].Y = r[1];
                _3DPoints[i].Z = r[2];
            }
            To2d();
            Drawing();
        }

        private void RotationX(int an)
        {
            float angle = an * 0.0174533f;
            for (int i = 0; i < _3DPoints.Count; i++)
            {
                float[] a = new float[] { _3DPoints[i].X, _3DPoints[i].Y, _3DPoints[i].Z, 1 };
                float[,] b = new float[,] { { 1, 0, 0, 0 },
                                            { 0, (float)Math.Cos(angle), (float)Math.Sin(angle), 0 },
                                            { 0, -(float)Math.Sin(angle), (float)Math.Cos(angle), 0 },
                                            { 0, 0, 0, 1 } };
                float[] r = new float[b.GetLength(1)];
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    for (int k = 0; k < b.GetLength(0); k++)
                    {
                        r[j] += a[k] * b[k, j];
                    }
                }
                _3DPoints[i].X = r[0];
                _3DPoints[i].Y = r[1];
                _3DPoints[i].Z = r[2];
            }
            To2d();
            Drawing();
        }

        private void RotationY(int an)
        {
            float angle = an * 0.0174533f;
            for (int i = 0; i < _3DPoints.Count; i++)
            {
                float[] a = new float[] { _3DPoints[i].X, _3DPoints[i].Y, _3DPoints[i].Z, 1 };
                float[,] b = new float[,] { { (float)Math.Cos(angle), 0,  -(float)Math.Sin(angle), 0 },
                                            { 0, 1, 0, 0 },
                                            { (float)Math.Sin(angle), 0, (float)Math.Cos(angle), 0 },
                                            { 0, 0, 0, 1 } };
                float[] r = new float[b.GetLength(1)];
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    for (int k = 0; k < b.GetLength(0); k++)
                    {
                        r[j] += a[k] * b[k, j];
                    }
                }
                _3DPoints[i].X = r[0];
                _3DPoints[i].Y = r[1];
                _3DPoints[i].Z = r[2];
            }
            To2d();
            Drawing();
        }

        private void RotationZ(int an)
        {
            float angle = an * 0.0174533f;
            for (int i = 0; i < _3DPoints.Count; i++)
            {
                float[] a = new float[] { _3DPoints[i].X, _3DPoints[i].Y, _3DPoints[i].Z, 1 };
                float[,] b = new float[,] { { (float)Math.Cos(angle), (float)Math.Sin(angle), 0, 0 },
                                            { -(float)Math.Sin(angle), (float)Math.Cos(angle), 0, 0 },
                                            { 0, 0, 1, 0 },
                                            { 0, 0, 0, 1 } };
                float[] r = new float[b.GetLength(1)];
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    for (int k = 0; k < b.GetLength(0); k++)
                    {
                        r[j] += a[k] * b[k, j];
                    }
                }
                _3DPoints[i].X = r[0];
                _3DPoints[i].Y = r[1];
                _3DPoints[i].Z = r[2];
            }
            To2d();
            Drawing();
        }

        private float Func(float x)
        {
            return (float)(Math.Sqrt(Math.Abs(100 - x * x)));
        }

        int t = 1;
        double an = 1.0472;

        private void Curve(object sender, EventArgs e)
        {
            t++;
            an += 0.2;
            if (timer.Enabled)
            {
                foreach (Points p in _3DPoints)
                {
                    p.Y = p.Y + (float)(Math.Cos(an) * 20);
                    p.X = p.X + (float)(Math.Sin(an) * 10);
                    p.Z = p.Z + (float)(Math.Sin(an) * 10);
                }
                To2d();
                Drawing();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            string fileNum = null;

            using (OpenFileDialog file = new OpenFileDialog())
            {
                file.InitialDirectory = "WindowsFormsApp14/bin/Debug";
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
                StreamReader file1 = new StreamReader(fileNum);
                try
                {
                    _3DPoints.Clear();
                    arr.Clear();
                    string ln;
                    string text = File.ReadAllText(fileNum);
                    string[] buf;
                    char[] sep = { ',', ' ' };
                    while ((ln = file1.ReadLine()) != "-")
                    {
                        buf = ln.Split(sep, StringSplitOptions.RemoveEmptyEntries);
                        arr.Add(new Points(Convert.ToInt32(buf[0]),
                                                 Convert.ToInt32(buf[1]),
                                                 Convert.ToInt32(buf[2])));
                        _3DPoints.Add(new Points(Convert.ToInt32(buf[0]),
                                                 Convert.ToInt32(buf[1]),
                                                 Convert.ToInt32(buf[2])));
                    }

                    matrix = new int[_3DPoints.Count / 2, _3DPoints.Count / 2];
                    int i = 0;
                    //file1.Close();
                    //string fname = "C:/Users/user/source/repos/WindowsFormsApp12/WindowsFormsApp12/bin/Debug/matrix.txt";
                    //StreamReader Mfile = new StreamReader(fname);
                    string line;
                    string[] buff;
                    i = 0;
                    while ((line = file1.ReadLine()) != null)
                    {
                        buff = line.Split(sep, StringSplitOptions.RemoveEmptyEntries);
                        for (int j = 0; j < buff.Length; j++)
                        {
                            matrix[i, j] = Convert.ToInt32(buff[j]);
                        }
                        i++;
                    }

                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label8.Visible = true;
                    label9.Visible = true;
                    label10.Visible = true;
                    Drawing();
                }
                catch (System.FormatException)
                {
                    MessageBox.Show("Неверный формат записей в файле.", "Ошибка!");
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int angle;
            string a = textBox1.Text;
            try
            {
                angle = Convert.ToInt32(a);
                if (radioButton1.Checked == true)
                {
                    groupBox1.Visible = false;
                    RotationX(angle);
                }
                if (radioButton2.Checked == true)
                {
                    groupBox1.Visible = false;
                    RotationY(angle);
                }
                if (radioButton5.Checked == true)
                {
                    groupBox1.Visible = false;
                    RotationZ(angle);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Неверный формат.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            float xch = trackBar1.Value;
            float ych = trackBar2.Value;
            float zch = trackBar3.Value;
            if (radioButton7.Checked == true)
            {
                groupBox2.Visible = false;
                Scaling(1 / xch, 1 / ych, 1 / zch);
            }
            if (radioButton6.Checked == true)
            {
                Scaling(xch, ych, zch);
                groupBox2.Visible = false;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            groupBox3.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                float x = Convert.ToSingle(textBox5.Text);
                float y = Convert.ToSingle(textBox6.Text);
                float z = Convert.ToSingle(textBox7.Text);
                groupBox3.Visible = false;
                Transp(x, y, z);
            }
            catch (FormatException)
            {
                MessageBox.Show("Неправильный формат. Введите координаты.", "Ошибка!");
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            timer.Tick += new EventHandler(Curve);
            timer.Interval = 10;
            if (timer.Enabled == true)
            {
                timer.Stop();
            }
            else
                timer.Start();
        }

        Timer timer = new Timer();

        private void label10_Click(object sender, EventArgs e)
        {
            Correction();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            groupBox4.Visible = true;
        }

        private void label11_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < _3DPoints.Count; i++)
            {
                float[] a = new float[] { _3DPoints[i].X, _3DPoints[i].Y, _3DPoints[i].Z, 1 };
                float[,] b = new float[,] { { -1, 0, 0, 0 },
                                            { 0, 1, 0, 0 },
                                            { 0, 0, 1, 0 },
                                            { 0, 0, 0, 1 } };
                float[] r = new float[b.GetLength(1)];
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    for (int k = 0; k < b.GetLength(0); k++)
                    {
                        r[j] += a[k] * b[k, j];
                    }
                }
                _3DPoints[i].X = r[0];
                _3DPoints[i].Y = r[1];
                _3DPoints[i].Z = r[2];
            }
            groupBox4.Visible = false;
            To2d();
            Drawing();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < _3DPoints.Count; i++)
            {
                float[] a = new float[] { _3DPoints[i].X, _3DPoints[i].Y, _3DPoints[i].Z, 1 };
                float[,] b = new float[,] { { 1, 0, 0, 0 },
                                            { 0, -1, 0, 0 },
                                            { 0, 0, 1, 0 },
                                            { 0, 0, 0, 1 } };
                float[] r = new float[b.GetLength(1)];
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    for (int k = 0; k < b.GetLength(0); k++)
                    {
                        r[j] += a[k] * b[k, j];
                    }
                }
                _3DPoints[i].X = r[0];
                _3DPoints[i].Y = r[1];
                _3DPoints[i].Z = r[2];
            }
            groupBox4.Visible = false;
            To2d();
            Drawing();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < _3DPoints.Count; i++)
            {
                float[] a = new float[] { _3DPoints[i].X, _3DPoints[i].Y, _3DPoints[i].Z, 1 };
                float[,] b = new float[,] { { 1, 0, 0, 0 },
                                            { 0, 1, 0, 0 },
                                            { 0, 0, -1, 0 },
                                            { 0, 0, 0, 1 } };
                float[] r = new float[b.GetLength(1)];
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    for (int k = 0; k < b.GetLength(0); k++)
                    {
                        r[j] += a[k] * b[k, j];
                    }
                }
                _3DPoints[i].X = r[0];
                _3DPoints[i].Y = r[1];
                _3DPoints[i].Z = r[2];
            }
            groupBox4.Visible = false;
            To2d();
            Drawing();
        }

    }
}
