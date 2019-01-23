using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Drawing2D;

namespace cg_lab2_kas
{
    public partial class Form1 : Form
    {
        double interval; // 0.2 seconds or 200 ms
        double totalTime; // 10 seconds or 10000 ms
        double elapsedTime = 0; // Elapsed time in ms
        Bitmap bitmap;
        Graphics graphics;
        //FileData file;
        public Form1()
        {
            InitializeComponent();
        }


        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog1 = new OpenFileDialog())
            {
                openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog1.InitialDirectory = Environment.CurrentDirectory;
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (StreamReader sr = new StreamReader(openFileDialog1.FileName, Encoding.Default))
                        {
                            string line;
                            while ((line = sr.ReadLine()) != "")
                            {
                                var buf = line.Split(',');
                                double x = double.Parse(buf[0]);
                                double y = double.Parse(buf[1]);
                                double z = double.Parse(buf[2]);
                                FileData._3DPoints.Add(new Point3D(x, y, z));

                            }
                            Point3D.DeepCopy();
                            int i = 0;
                            while ((line = sr.ReadLine()) != null)
                            {
                                var buf = line.Split(',');
                                if (FileData.edgeMatrix == null) FileData.edgeMatrix = new int[buf.Length, buf.Length];
                                for (int j = 0; j < buf.Length; j++)
                                {
                                    var t = Convert.ToInt32(buf[j]);
                                    FileData.edgeMatrix[i, j] = t;
                                }
                                i++;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                    }
                    button1.Visible = true;
                    textBox1.Visible = true;
                    label1.Visible = true;
                }
               
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bitmap = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            graphics = Graphics.FromImage(bitmap);
            graphics.SmoothingMode = SmoothingMode.AntiAlias;
            graphics.Clear(Color.White);
            graphics.TranslateTransform(pictureBox1.Width/2, pictureBox1.Height/2);
           
            DrawAxis();
            if (textBox1.Text == "")
                return;
            Point3D.From3DTo2D(Convert.ToDouble(textBox1.Text));
            for (int i = 0; i < FileData.edgeMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < FileData.edgeMatrix.GetLength(1); j++)
                {
                    if (FileData.edgeMatrix[i, j] == 1)
                    {
                        Pen pen = new Pen(Color.Black);
                        graphics.DrawLine(pen, (float)Point3D.points[i].x, (float)Point3D.points[i].y, (float)Point3D.points[j].x, (float)Point3D.points[j].y);
                    }
                    else
                        continue;
                }
            }
            pictureBox1.Image = bitmap;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            button8.Visible = true;
            button9.Visible = true;
            button10.Visible = true;
            button11.Visible = true;
            button12.Visible = true;
            button13.Visible = true;
            button14.Visible = true;
            button15.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
        }

        private void DrawAxis()
        {
            Pen myPen = new Pen(Color.Black);
            graphics.DrawLine(myPen, 0, 500, 0, -500);
            graphics.DrawLine(myPen, -500, 0, 500, 0);
        }

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            timer1.Start();
            elapsedTime = 0;
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            interval = timer1.Interval;
            if (textBox2.Text == "")
                return;
            totalTime = (double)(Math.Abs(int.Parse(textBox2.Text) * 10));
            if (elapsedTime <= totalTime)
            {
                graphics.Clear(Color.White);
                DrawAxis();
                if (int.Parse(textBox2.Text) > 0)
                {
                    Point3D.AngleRotationX(1);
                }
                else
                {
                    Point3D.AngleRotationX(-1);
                }
                if (textBox1.Text == "")
                    return;
                Point3D.From3DTo2D(Convert.ToDouble(textBox1.Text));
                DrawWord();
                elapsedTime += interval;
            }

            else
            {
                timer1.Stop();
            }
            pictureBox1.Image = bitmap;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer2.Start();
            elapsedTime = 0;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            interval = timer2.Interval;
            if (textBox2.Text == "")
                return;
            totalTime = (double)(int.Parse(textBox2.Text) * 10);
            if (elapsedTime < totalTime)
            {
                graphics.Clear(Color.White);
                DrawAxis();
                Point3D.AngleRotationY(1);
                if (textBox1.Text == "")
                    return;
                Point3D.From3DTo2D(Convert.ToDouble(textBox1.Text));
                DrawWord();
                pictureBox1.Image = bitmap;
                elapsedTime += interval;
            }
            else
            {
                timer2.Stop();
            }

        }
        private void button4_Click(object sender, EventArgs e)
        {

            timer3.Start();
            elapsedTime = 0;
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            interval = timer3.Interval;
            if (textBox2.Text == "")
                return;
            totalTime = (double)(int.Parse(textBox2.Text) * 10);
            if (elapsedTime < totalTime)
            {
                graphics.Clear(Color.White);
                DrawAxis();
                Point3D.AngleRotationZ(1);
                if (textBox1.Text == "")
                    return;
                Point3D.From3DTo2D(Convert.ToDouble(textBox1.Text));
                DrawWord();
                pictureBox1.Image = bitmap;
                elapsedTime += interval;
            }
            else
            {
                timer3.Stop();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            StopTimers();           
            
            Point3D.points.Clear();         
            Point3D.DeepCopy();
            graphics.Clear(Color.White);
            DrawAxis();
            //Point3D.From3DTo2D(Convert.ToDouble(textBox1.Text));
            DrawWordFromFile();
            pictureBox1.Image = bitmap;
        }

        private void DrawWordFromFile()
        {
            for (int i = 0; i < FileData.edgeMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < FileData.edgeMatrix.GetLength(1); j++)
                {
                    if (FileData.edgeMatrix[i, j] == 1)
                    {
                        Pen pen = new Pen(Color.Black);
                        graphics.DrawLine(pen, (float)Point3D.pointsDefault[i].x, (float)Point3D.pointsDefault[i].y, (float)Point3D.pointsDefault[j].x, (float)Point3D.pointsDefault[j].y);
                    }
                    else
                        continue;
                }
            }
        }

        private void StopTimers()
        {
            timer1.Stop();
            timer2.Stop();
            timer3.Stop();
            timer4.Stop();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            graphics.Clear(Color.White);
            DrawAxis();
            if (textBox3.Text == "")
                return;
            Point3D.XScaling(Convert.ToDouble(textBox3.Text));
            if (textBox1.Text == "")
                return;
            Point3D.From3DTo2D(Convert.ToDouble(textBox1.Text));
            DrawWord();
            pictureBox1.Image = bitmap;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            graphics.Clear(Color.White);
            DrawAxis();
            if (textBox3.Text == "")
                return;
            Point3D.YScaling(Convert.ToDouble(textBox3.Text));
            if (textBox1.Text == "")
                return;
            Point3D.From3DTo2D(Convert.ToDouble(textBox1.Text));
            DrawWord();
            pictureBox1.Image = bitmap;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            graphics.Clear(Color.White);
            DrawAxis();
            if (textBox3.Text == "")
                return;
            Point3D.ZScaling(Convert.ToDouble(textBox3.Text));
            if (textBox1.Text == "")
                return;
            Point3D.From3DTo2D(Convert.ToDouble(textBox1.Text));
            DrawWord();
            pictureBox1.Image = bitmap;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            graphics.Clear(Color.White);
            DrawAxis();
            Point3D.OzReflection();
            if (textBox1.Text == "")
                return;
            Point3D.From3DTo2D(Convert.ToDouble(textBox1.Text));
            DrawWord();
            pictureBox1.Image = bitmap;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            graphics.Clear(Color.White);
            DrawAxis();
            Point3D.OyReflection();
            if (textBox1.Text == "")
                return;
            Point3D.From3DTo2D(Convert.ToDouble(textBox1.Text));
            DrawWord();
            pictureBox1.Image = bitmap;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            graphics.Clear(Color.White);
            DrawAxis();
            Point3D.OxReflection();
            if (textBox1.Text == "")
                return;
            Point3D.From3DTo2D(Convert.ToDouble(textBox1.Text));
            DrawWord();
            pictureBox1.Image = bitmap;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            graphics.Clear(Color.White);
            DrawAxis();
            if (textBox4.Text == "")
                return;
            Point3D.OXTransposition(Convert.ToDouble(textBox4.Text));
            if (textBox1.Text == "")
                return;
            Point3D.From3DTo2D(Convert.ToDouble(textBox1.Text));
            DrawWord();
            pictureBox1.Image = bitmap;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            graphics.Clear(Color.White);
            DrawAxis();
            if (textBox4.Text == "")
                return;
            Point3D.OYTransposition(Convert.ToDouble(textBox4.Text));
            if (textBox1.Text == "")
                return;
            Point3D.From3DTo2D(Convert.ToDouble(textBox1.Text));
            DrawWord();
            pictureBox1.Image = bitmap;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            graphics.Clear(Color.White);
            DrawAxis();
            if (textBox4.Text == "")
                return;
            Point3D.OZTransposition(Convert.ToDouble(textBox4.Text));
            if (textBox1.Text == "")
                return;
            Point3D.From3DTo2D(Convert.ToDouble(textBox1.Text));
            DrawWord();
            pictureBox1.Image = bitmap;
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            graphics.Clear(Color.White);
            DrawAxis();
            Point3D.CurveMovement();
            if (textBox1.Text == "")
                return;
            Point3D.From3DTo2D(Convert.ToDouble(textBox1.Text));
            DrawWord();
            pictureBox1.Image = bitmap;
        }

        private void DrawWord()
        {
            bool flag = false;
            for (int i = 0; i < Point3D.pointsToDraw.Count; i++)
            {
                if(Math.Abs(Point3D.pointsToDraw[i].x) >= 250 || Math.Abs(Point3D.pointsToDraw[i].y) >= 250)
                {
                    button5_Click(new object(), new EventArgs());
                    MessageBox.Show("Figure went out of ambit");
                    flag = true;
                    break; 
                }
            }
            if (flag != true)
            {
                for (int i = 0; i < FileData.edgeMatrix.GetLength(0); i++)
                {
                    for (int j = 0; j < FileData.edgeMatrix.GetLength(1); j++)
                    {
                        if (FileData.edgeMatrix[i, j] == 1)
                        {
                            Pen pen = new Pen(Color.Black);
                            graphics.DrawLine(pen, (float)Point3D.pointsToDraw[i].x, (float)Point3D.pointsToDraw[i].y, (float)Point3D.pointsToDraw[j].x, (float)Point3D.pointsToDraw[j].y);
                        }
                        else
                            continue;
                    }
                }
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            timer4.Start();
            button16.Visible = true;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            timer4.Stop();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}


