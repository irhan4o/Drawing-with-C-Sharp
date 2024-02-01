using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _16._01.Drawing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

            /* for (int i = 0; i < 15; i++)
             {
                 Random k = new Random();
                 int x1;
                 int y1;
                 int x2;
                 int y2;
                 int r = k.Next(0, 256);
                 int gr = k.Next(0, 256);
                 int b = k.Next(0, 256);
                 x1 = k.Next(1, 505);
                 y1 = k.Next(1, 505);
                 x2 = k.Next(1, 505);
                 y2 = k.Next(1, 505);

                 Point p1 = new Point(x1, y1);
                 Point p2 = new Point(x2, y2);
                 Pen pen1 = new Pen(Color.FromArgb(r,gr,b), 10);
                 g.DrawLine(pen1,p1,p2);
                 System.Threading.Thread.Sleep(200);
             }*/
            Graphics g = e.Graphics;
            g.Clear(Color.Red);
            Random k = new Random();
            Pen pen = new Pen(Color.White,5);
            Point c = new Point(220, 100);
            int dx = k.Next(1, 250);
            int dy = k.Next(1, 250);
            Point b = new Point(220 - dx, 300 - dy);
             dx = k.Next(1, 250);
             dy = k.Next(1, 250);
            Point a = new Point(220 - dx, 300 - dy);
            g.DrawLine(pen,a,b);
            g.DrawLine(pen, b, c);
            g.DrawLine(pen, c, a);
        }
    }
}
