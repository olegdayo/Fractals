using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Fractals
{
    public partial class Form1 : Form
    {
        //Different things for form and characteristics of drawing.
        static Pen pen1;
        static Graphics gr;
        static Pen pen2;
        static int iter = 3;
        static int max = 3;
        static int it = 0;
        static int itw = 1;
        static Color color = Color.Black;
        private bool isSaved = false;
        private Bitmap bitmap;


        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            gr = pictureBox1.CreateGraphics();
            pen1 = new Pen(color, itw);
            pen2 = new Pen(color, itw);
            gr.Clear(Color.White);
        }


        //Snow drawing.
        static int Snow(PointF p1, PointF p2, PointF p3, int n)
        {
            pen1 = new Pen(color, itw);
            pen2 = new Pen(Color.White, itw);
            if (n == max)
            {
                //Creating first triangular.
                gr.DrawLine(pen1, p1, p2);
                gr.DrawLine(pen1, p2, p3);
                gr.DrawLine(pen1, p3, p1);

                Snow(p1, p2, p3, n - 1);
                Snow(p2, p3, p1, n - 1);
                Snow(p3, p1, p2, n - 1);
            } else if (n > 0) 
            {
                //New little triangulars.
                var p4 = new PointF((p2.X + 2 * p1.X) / 3, (p2.Y + 2 * p1.Y) / 3);
                var p5 = new PointF((2 * p2.X + p1.X) / 3, (p1.Y + 2 * p2.Y) / 3);
                var ps = new PointF((p2.X + p1.X) / 2, (p2.Y + p1.Y) / 2);
                var pn = new PointF((4 * ps.X - p3.X) / 3, (4 * ps.Y - p3.Y) / 3);


                gr.DrawLine(pen1, p4, pn);
                gr.DrawLine(pen1, p5, pn);
                gr.DrawLine(pen2, p4, p5);


                Snow(p4, pn, p5, n - 1);
                Snow(pn, p5, p4, n - 1);
                Snow(p1, p4, new PointF((2 * p1.X + p3.X) / 3,
                    (2 * p1.Y + p3.Y) / 3), n - 1);
                Snow(p5, p2, new PointF((2 * p2.X + p3.X) / 3, 
                    (2 * p2.Y + p3.Y) / 3), n - 1);
            }
            return n;
        }


        //Drawing Koh.
        static int Line(PointF p1, PointF p2, PointF p3, int n)
        {
            pen1 = new Pen(color, itw);
            pen2 = new Pen(Color.White, itw);
            if (n == max)
            {
                //Creating line.
                gr.DrawLine(pen1, p1, p2);
                gr.DrawLine(pen1, p2, p3);
                gr.DrawLine(pen1, p3, p1);


                Line(p1, p2, p3, n - 1);
                Line(p2, p3, p1, n - 1);
                Line(p3, p1, p2, n - 1);
            }
            else if (n > 0)
            {
                //Drawing little triangulars.
                var p4 = new PointF((p2.X + 2 * p1.X) / 3, (p2.Y + 2 * p1.Y) / 3);
                var p5 = new PointF((2 * p2.X + p1.X) / 3, (p1.Y + 2 * p2.Y) / 3);
                var ps = new PointF((p2.X + p1.X) / 2, (p2.Y + p1.Y) / 2);
                var pn = new PointF((4 * ps.X - p3.X) / 3, (4 * ps.Y - p3.Y) / 3);


                gr.DrawLine(pen1, p4, pn);
                gr.DrawLine(pen1, p5, pn);
                gr.DrawLine(pen2, p4, p5);


                Line(p4, pn, p5, n - 1);
                Line(pn, p5, p4, n - 1);
                Line(p1, p4, new PointF((2 * p1.X + p3.X) / 3,
                    (2 * p1.Y + p3.Y) / 3), n - 1);
                Line(p5, p2, new PointF((2 * p2.X + p3.X) / 3,
                    (2 * p2.Y + p3.Y) / 3), n - 1);
            }
            return n;
        }


        static int Carpet(PointF p, float size, int n)
        {
            if(n == 0)
            {
                //Creating rectangle.
                gr.FillRectangle(new SolidBrush(color), new RectangleF(p, new SizeF(size, size)));
            }
            else if(n > 0)
            {
                //Creating little rectangles.
                float sz = size / 3;


                float x1 = (float)p.X;
                float x2 = x1 + sz;
                float x3 = x2 + sz;


                float y1 = (float)p.Y;
                float y2 = y1 + sz;
                float y3 = y2 + sz;


                Carpet(new PointF(x1, y1), sz, n - 1);
                Carpet(new PointF(x2, y1), sz, n - 1);
                Carpet(new PointF(x3, y1), sz, n - 1);
                Carpet(new PointF(x1, y2), sz, n - 1);
                Carpet(new PointF(x3, y2), sz, n - 1);
                Carpet(new PointF(x1, y3), sz, n - 1);
                Carpet(new PointF(x2, y3), sz, n - 1);
                Carpet(new PointF(x3, y3), sz, n - 1);
            }
            return n;
        }


        //Serpynskiy's triangle.
        static int Triangle(PointF p1, PointF p2, PointF p3, int n)
        {
            pen1 = new Pen(color, itw);
            pen2 = new Pen(color, itw);
            if (n == 0)
            {
                //Creating triangle.
                gr.DrawLine(pen1, p1, p2);
                gr.DrawLine(pen1, p1, p3);
                gr.DrawLine(pen1, p2, p3);
            }
            else if (n > 0)
            {
                //Setting points for less triangles.
                PointF pp1 = new PointF((p1.X + p2.X) / 2, (p1.Y + p2.Y) / 2);
                PointF pp2 = new PointF((p1.X + p3.X) / 2, (p1.Y + p3.Y) / 2);
                PointF pp3 = new PointF((p2.X + p3.X) / 2, (p2.Y + p3.Y) / 2);
                Triangle(p1, pp1, pp2, n - 1);
                Triangle(p2, pp1, pp3, n - 1);
                Triangle(p3, pp2, pp3, n - 1);
            }
            return n;
        }


        //Kantor's set.
        static int Set(PointF p, float w, float h, int n)
        {
            //Creating first rectangle.
            gr.FillRectangle(new SolidBrush(color), new RectangleF(new PointF(0, 0), new SizeF(w, h)));
            if (n > 0)
            {
                //Creating little rectangles.
                float wn = w / 3;


                float x1 = (float)p.X;
                float y1 = (float)p.Y + 2 * h;


                float x2 = (float)p.X + 2 * wn;
                float y2 = (float)p.Y + 2 * h;


                gr.FillRectangle(new SolidBrush(color), new RectangleF(new PointF(x1, y1), new SizeF(wn, h)));
                gr.FillRectangle(new SolidBrush(color), new RectangleF(new PointF(x2, y2), new SizeF(wn, h)));


                Set(new PointF(x1, y1), wn, h, n - 1);
                Set(new PointF(x2, y2), wn, h, n - 1);
            }
            return n;
        }


        //Almost Pifagor's tree.
        static int Tree(PointF p1, PointF p2, int n)
        {
            pen1 = new Pen(color, itw);
            pen2 = new Pen(Color.White, itw);
            if(n > -1)
            {
                //Drawing big branche.
                gr.DrawLine(pen1, p1, p2);
                float l = (float)(Math.Sqrt(Convert.ToDouble((p1.X - p2.X) * (p1.X - p2.X) + (p1.Y - p2.Y) * (p1.Y - p2.Y))));
                //Creating little branches.
                Tree(p2, new PointF(p2.X - l / 2, p2.Y - l / 2), n - 1);
                Tree(p2, new PointF(p2.X + l / 2, p2.Y - l / 2), n - 1);
            }
            return n;
        }


        private void snowButtonClick(object sender, EventArgs e)
        {
            //Snow button.
            max = iter = it;
            //Clears picture box.
            gr.Clear(Color.White);
            float w = pictureBox1.Width;
            float h = pictureBox1.Height;
            //Draws snow.
            Snow(new PointF(w / 2, h / 5),
                new PointF((float)(w/2 - 3 * w / (5 * Math.Sqrt(3))), 4 * h / 5), 
                new PointF((float)(w/2 + 3 * w / (5 * Math.Sqrt(3))), 4 * h / 5),
                iter);
        }

        private void carpetButtonClick(object sender, EventArgs e)
        {
            //Carpet button.
            max = iter = it;
            //Clears picture box.
            gr.Clear(Color.White);
            float w = pictureBox1.Width;
            float h = pictureBox1.Height;
            //Draws carpet.
            Carpet(new PointF(0, 0), w, iter);
        }


        private void colorButtonClick(object sender, EventArgs e)
        {
            //Chooses color.
            if (colorDialog.ShowDialog() == DialogResult.Cancel)
            {
                //User exit choosing color.
                return;
            }
            //Color choice.
            color = (sender as Button).BackColor = colorDialog.Color;
        }


        private void treeButtonClick(object sender, EventArgs e)
        {
            //Tree button.
            max = iter = it;
            //Clears picture box.
            gr.Clear(Color.White);
            float w = pictureBox1.Width;
            float h = pictureBox1.Height;
            //Draws tree.
            Tree(new PointF(w / 2, h), new PointF(w / 2, h * 4 / 5), iter);
        }


        private void lineButtonClick(object sender, EventArgs e)
        {
            //Line button.
            max = iter = it;
            //Clears picture box.
            gr.Clear(Color.White);
            float w = pictureBox1.Width;
            float h = pictureBox1.Height;
            //Draws line.
            Line(new PointF(0, h), new PointF(w, h), new PointF(w / 2, 2 * h), iter);
        }


        private void triangleButtonClick(object sender, EventArgs e)
        {
            //Triangle button.
            max = iter = it;
            float w = pictureBox1.Width;
            float h = pictureBox1.Height;
            //Clears picture box.
            gr.Clear(Color.White);
            //Draws triangle.
            Triangle(new PointF(w / 2, h / 5),
                new PointF((float)(w / 2 - 3 * w / (5 * Math.Sqrt(3))), 4 * h / 5),
                new PointF((float)(w / 2 + 3 * w / (5 * Math.Sqrt(3))), 4 * h / 5),
                iter);
        }


        private void setButtonClick(object sender, EventArgs e)
        {
            //Set button.
            max = iter = it;
            float w = pictureBox1.Width;
            float h = (float)itw * 10 + 1;
            //Clears picture box.
            gr.Clear(Color.White);
            Set(new PointF(0, 0), w, h, iter);
        }


        private void oofButtonClick(object sender, EventArgs e)
        {
            //OOF.
            //OOF.
            //OOF.
            //OOF.
            //OOF.
            try
            {
                //OOF.
                //OOF.
                //OOF.
                //OOF.
                //OOF.
                Image image = Image.FromFile("oof.jpg");
                gr.Clear(Color.White);
                gr.DrawImage(image, new PointF(0, 0));
                //OOF.
                //OOF.
                //OOF.
                //OOF.
                //OOF.
            }
            catch
            {
                //OOF.
                //OOF.
                //OOF.
                //OOF.
                //OOF.
            }
            //OOF.
            //OOF.
            //OOF.
            //OOF.
            //OOF.
        }


        private void saveButtonClick(object sender, EventArgs e)
        {
            //Save button.
            //I do not want exceptions you know!
            try
            {
                //Check.
                using (SaveFileDialog dialog = new SaveFileDialog())
                {
                    dialog.Filter = "jpg files (*.jpg)|*.jpg|All files (*.*)|*.*";
                    dialog.FileName = "fractal";
                    dialog.DefaultExt = "jpg";
                    dialog.FilterIndex = 2;
                    dialog.RestoreDirectory = true;
                    try
                    {
                        //Another check.
                        if (!(pictureBox1.Image == null))
                        {
                            //And another check.
                            bitmap = new Bitmap(pictureBox1.Image);
                        }
                        if (dialog.ShowDialog() == DialogResult.OK)
                        {
                            //Yeah boie, another check.
                            if (!(bitmap == null))
                            {
                                //The last check.
                                bitmap.Save(dialog.FileName);
                            }
                            else
                            {
                                MessageBox.Show("Looks like this button still has problems, sorry!");
                            }
                        }
                        isSaved = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Looks like this button still has problems, sorry!");
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Looks like this button still has problems, sorry!");
            }
        }


        private void trackBarScrollIter(object sender, System.EventArgs e)
        {
            //Gets number of the iterations value from iter scroll bar.
            it = trackBarIter.Value;
        }


        private void trackBarScrollWidth(object sender, System.EventArgs e)
        {
            //Gets line width value from width scroll bar.
            itw = trackBarWidth.Value;
        }
    }
}