using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clipping_and_Filling
{
    public partial class Form1 : Form
    {
        Bitmap bmp;
        Graphics grp;
        Point p1, p2, tmp1, tmp2, rec1, rec2, rec3, rec4;
        Button whichButton;
        List<Point> polygon;

        public Form1()
        {
            InitializeComponent();
            drawPol.Enabled = false;

            polygon = new List<Point>();
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            grp = Graphics.FromImage(bmp);
        }

        void floodFill(int x, int y, Color newC, Color clicked, int t)
        {
            Color old = bmp.GetPixel(x, y);
            
            Stack<Point> pixels = new Stack<Point>();
            pixels.Push(new Point(x,y));

            while (pixels.Count > 0)
            {
                Point a = pixels.Pop();
                if (a.X < bmp.Width && a.X > 0 && a.Y < bmp.Height && a.Y > 0)//make sure we stay within bounds
                {
                    double euc = Math.Sqrt((bmp.GetPixel(a.X, a.Y).R - clicked.R) * (bmp.GetPixel(a.X, a.Y).R - clicked.R) + (bmp.GetPixel(a.X, a.Y).G - bmp.GetPixel(a.X, a.Y).G) * (bmp.GetPixel(a.X, a.Y).G - clicked.G) + (bmp.GetPixel(a.X, a.Y).B - clicked.B) * (bmp.GetPixel(a.X, a.Y).B - clicked.B));
                    if (euc <= t)
                    {
                        bmp.SetPixel(a.X, a.Y, newC);
                        //pictureBox1.Refresh();
                        pixels.Push(new Point(a.X - 1, a.Y));
                        pixels.Push(new Point(a.X + 1, a.Y));
                        pixels.Push(new Point(a.X, a.Y - 1));
                        pixels.Push(new Point(a.X, a.Y + 1));
                    }
                }
            }
        }

        private void LiangBarsky(PointF p1, PointF p2, int xmin, int xmax, int ymin, int ymax)
        {
            float dx, dy, t1, t2, P1, P2, P3, P4, q1, q2, q3, q4;

            dx = p2.X - p1.X;
            dy = p2.Y - p1.Y;

            P1 = -dx;
            P2 = dx;
            P3 = -dy;
            P4 = dy;

            q1 = p1.X - xmin;
            q2 = xmax - p1.X;
            q3 = p1.Y - ymin;
            q4 = ymax - p1.Y;

            t1 = 0;
            t2 = 1;

            List<float> positive = new List<float>();
            List<float> negative = new List<float>();

            negative.Add(t1);
            positive.Add(t2);

            if(Clip(P1, q1) && Clip(P3, q3))
            {
                if (P1 != 0)
                {
                    t1 = q1 / P1;
                    t2 = q2 / P2;
                    if (P1 < 0)
                    {
                        negative.Add(t1);
                        positive.Add(t2);
                    }
                    else
                    {
                        negative.Add(t2);
                        positive.Add(t1);
                    }
                }
                if (P3 != 0)
                {
                    t1 = q3 / P3;
                    t2 = q4 / P4;
                    if (P3 < 0)
                    {
                        negative.Add(t1);
                        positive.Add(t2);
                    }
                    else
                    {
                        negative.Add(t2);
                        positive.Add(t1);
                    }
                }

                float newt1, newt2;
                newt1 = negative.Max();
                newt2 = positive.Min();

                if (newt1 <= newt2)
                {
                    Point n1 = new Point((int)Math.Round(p1.X + P2 * newt1), (int)Math.Round(p1.Y + P4 * newt1));
                    Point n2 = new Point((int)(p1.X + P2 * newt2), (int)(p1.Y + P4 * newt2));

                    drawLine(n1, n2);
                }
            }
        }

        private bool Clip(float p, float q)
        {
            if (p == 0)
            { //Paralel line
                if (q < 0)
                    return false; // outside - discard
            }
            return true;
        }

        public class Edge
        {
            public int ymin { get; set; }
            public int ymax { get; set; }
            public float x { get; set; }
            public float? m { get; set; }

            public Edge(int y1, int y2, int x1, int x2)
            {
                if (y1 < y2)
                {
                    ymin = y1;
                    ymax = y2;
                    x = x1;
                }
                else
                {
                    ymin = y2;
                    ymax = y1;
                    x = x2;
                }

               // if (x1 < x2) x = x1;
               // else x = x2;
            
                if (y2 - y1 == 0) m = null;
                else m = (float)(x2 - x1) / (y2 - y1);
            }
        }

        public void fillPolygon(List<Point> pol)
        {
            List<Edge> ET = new List<Edge>();
            for(int i = 0; i < pol.Count; i++)
            {
                if (i + 1 < pol.Count)
                {
                    Edge e = new Edge(pol.ElementAt(i).Y, pol.ElementAt(i + 1).Y, pol.ElementAt(i).X, pol.ElementAt(i + 1).X);
                    if(e.m != null) ET.Add(e);
                }
                else
                {
                    Edge e = new Edge(pol.ElementAt(i).Y, pol.ElementAt(0).Y, pol.ElementAt(i).X, pol.ElementAt(0).X);
                    if(e.m != null) ET.Add(e);
                }
            }

            ET.OrderBy(e => e.ymin).ToList();

            int scanLine = ET.Min(e => e.ymin);
            List<Edge> AET = new List<Edge>();

            while (AET.Count != 0 || ET.Count != 0)
            {
                //move bucket ET[y] to AET
                foreach (Edge e in ET)
                {
                    if (e.ymin == scanLine)
                    {
                        AET.Add(e);
                    }
                }
                ET.RemoveAll(e => e.ymin == scanLine);

                AET.OrderBy(e => e.x).ToList();//sort AET by x value

                for (int i = 0; i < AET.Count - 1; i += 2)//fill pixels between pairs of intersections
                {
                    for (int j = (int)Math.Round(AET.ElementAt(i).x); j <= (int)Math.Round(AET.ElementAt(i + 1).x); j++)
                    {
                        bmp.SetPixel(j, scanLine, Color.Red);
                    }
                }

                scanLine++;

                //remove from AET edges for which ymax = y
                AET.RemoveAll(e => e.ymax == scanLine);

                foreach (Edge e in AET)
                {
                    e.x = ((e.x) + (e.m)).Value;
                }
            }
        }


        private void drawLine(Point pnt1, Point pnt2)
        {
            int x1 = pnt1.X, x2 = pnt2.X, y1 = pnt1.Y, y2 = pnt2.Y;

            int d, dx, dy, dE, dNE, xi, yi;
            int x = x1, y = y1;

            if (x1 < x2)
            {
                xi = 1;
                dx = x2 - x1;
            }
            else
            {
                xi = -1;
                dx = x1 - x2;
            }

            if (y1 < y2)
            {
                yi = 1;
                dy = y2 - y1;
            }
            else
            {
                yi = -1;
                dy = y1 - y2;
            }

            bmp.SetPixel(x, y, Color.Black);

            if (dx > dy)
            {
                d = dy * 2 - dx;
                dE = dy * 2;
                dNE = (dy - dx) * 2;

                while (x != x2)
                {
                    if (d < 0)
                    {
                        d += dE;
                        x += xi;
                    }
                    else
                    {
                        d += dNE;
                        x += xi;
                        y += yi;
                    }
                    bmp.SetPixel(x, y, Color.Black);
                }
            }

            else
            {
                d = dx * 2 - dy;
                dE = dx * 2;
                dNE = (dx - dy) * 2;

                while (y != y2)
                {
                    if (d < 0)
                    {
                        d += dE;
                        y += yi;
                    }
                    else
                    {
                        d += dNE;
                        x += xi;
                        y += yi;
                    }
                    bmp.SetPixel(x, y, Color.Black);
                }
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            pictureBox1.Image = bmp;
        }

        private void recButton_Click(object sender, EventArgs e)
        {
            recButton.BackColor = Color.CornflowerBlue;
            lineButton.BackColor = Color.Transparent;
            whichButton = recButton;
        }

        private void lineButton_Click(object sender, EventArgs e)
        {
            lineButton.BackColor = Color.CornflowerBlue;
            recButton.BackColor = Color.Transparent;
            whichButton = lineButton;
        }

        private void drawPol_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < polygon.Count; i++)
            {
                if (i + 1 < polygon.Count)
                {
                    drawLine(polygon.ElementAt(i), polygon.ElementAt(i+1));
                }
                else
                {
                    drawLine(polygon.ElementAt(i), polygon.ElementAt(0));
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                bmp = new Bitmap("C:/Users/UlaBorys/Pictures/colour_wheel.png");
            }
            else
            {
                bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            }
        }

        private void drawRec_Click(object sender, EventArgs e)
        {
            if(!rec4.IsEmpty)
            {
                for(int i = rec1.X; i <= rec2.X; i++)
                {
                    bmp.SetPixel(i, rec1.Y, Color.Black);
                }
                for (int i = rec3.X; i <= rec4.X; i++)
                {
                    bmp.SetPixel(i, rec3.Y, Color.Black);
                }
                for (int i = rec1.Y; i <= rec3.Y; i++)
                {
                    bmp.SetPixel(rec1.X, i, Color.Black);
                }
                for (int i = rec2.Y; i <= rec4.Y; i++)
                {
                    bmp.SetPixel(rec2.X, i, Color.Black);
                }
            }
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (clipRB.Checked)
                {
                    if (whichButton == recButton)
                    {
                        if (tmp1.IsEmpty)
                        {
                            tmp1 = new Point(e.X, e.Y);
                            p1label.Text = tmp1.ToString();
                        }
                        else
                        {
                            tmp2 = new Point(e.X, e.Y);
                            p2label.Text = tmp2.ToString();

                            if(tmp1.X < tmp2.X)
                            {
                                if(tmp1.Y < tmp2.Y)
                                {
                                    rec1 = new Point(tmp1.X, tmp1.Y);
                                    rec2 = new Point(tmp2.X, tmp1.Y);
                                    rec3 = new Point(tmp1.X, tmp2.Y);
                                    rec4 = new Point(tmp2.X, tmp2.Y);
                                }
                                else
                                {
                                    rec1 = new Point(tmp1.X, tmp2.Y);
                                    rec2 = new Point(tmp2.X, tmp2.Y);
                                    rec3 = new Point(tmp1.X, tmp1.Y);
                                    rec4 = new Point(tmp2.X, tmp1.Y);
                                }
                            }
                            else
                            {
                                if (tmp1.Y < tmp2.Y)
                                {
                                    rec1 = new Point(tmp2.X, tmp1.Y);
                                    rec2 = new Point(tmp1.X, tmp1.Y);
                                    rec3 = new Point(tmp2.X, tmp2.Y);
                                    rec4 = new Point(tmp1.X, tmp2.Y);
                                }
                                else
                                {
                                    rec1 = new Point(tmp2.X, tmp2.Y);
                                    rec2 = new Point(tmp1.X, tmp2.Y);
                                    rec3 = new Point(tmp2.X, tmp1.Y);
                                    rec4 = new Point(tmp1.X, tmp1.Y);
                                }
                            }
                            
                        }
                    }
                    else
                    {
                        if (p1.IsEmpty)
                        {
                            p1 = new Point(e.X, e.Y);
                            p1line.Text = p1.ToString();
                        }
                        else
                        {
                            p2 = new Point(e.X, e.Y);
                            p2line.Text = p2.ToString();
                        }
                    }
                }
                else
                {
                    if(fillRB.Checked) polygon.Add(new Point(e.X, e.Y));
                    else
                    {
                        floodFill(e.X, e.Y, Color.Black, bmp.GetPixel(e.X, e.Y), 1);
                    }
                }
            }
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            if(clipRB.Checked)
            {
                LiangBarsky(new PointF((float)p1.X, (float)p1.Y), new PointF((float)p2.X, (float)p2.Y), rec1.X, rec4.X, rec1.Y, rec4.Y);

                p1 = new Point();
                p2 = new Point();
                p1line.Text = "";
                p2line.Text = "";
            }
            else
            {
                fillPolygon(polygon);
                //polygon = new List<Point>();
            }
        }

        private void Reset()
        {
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            grp = Graphics.FromImage(bmp);

            p1 = new Point();
            p2 = new Point();
            tmp1 = new Point();
            tmp2 = new Point();
            rec1 = new Point();
            rec2 = new Point();
            rec3 = new Point();
            rec4 = new Point();

            p1label.Text = "";
            p1line.Text = "";
            p2label.Text = "";
            p2line.Text = "";

            polygon = new List<Point>();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void clipRB_CheckedChanged(object sender, EventArgs e)
        {
            if(clipRB.Checked)
            {
                recButton.Enabled = true;
                drawRec.Enabled = true;
                lineButton.Enabled = true;
            }
            else
            {
                recButton.Enabled = false;
                drawRec.Enabled = false;
                lineButton.Enabled = false;
            }
        }

        private void fillRB_CheckedChanged(object sender, EventArgs e)
        {
            if(fillRB.Checked)
            {
                drawPol.Enabled = true;
            }
            else
            {
                drawPol.Enabled = false;
            }
        }
    }
}
