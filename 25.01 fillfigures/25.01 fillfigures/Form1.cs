using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _25._01_fillfigures
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //Задача 1
            /*Graphics g = e.Graphics;
            g.Clear(Color.CadetBlue);
            Brush b = new SolidBrush(Color.White);
            g.FillRectangle(b, 10, 10, 110, 110);
            g.FillEllipse(b, 120, 120, 100, 100);*/
            Graphics g = e.Graphics;
            g.Clear(Color.AliceBlue);
            Brush b = new SolidBrush(Color.Pink);
            Brush b1 = new SolidBrush(Color.Red);
            Brush b2 = new SolidBrush(Color.CornflowerBlue);
            Brush b3 = new SolidBrush(Color.Brown);
            Brush b4 = new SolidBrush(Color.Gray);
            Pen p = new Pen(Color.Red, 6);
            Pen p1 = new Pen(Color.Black, 6);
            g.FillRectangle(b, 190, 120, 160, 180);
            Point[] point = { new Point(160,120), new Point(275, 25), new Point(375, 120) };
            g.FillPolygon(b1, point);
            g.FillEllipse(b2, 400, 225, 300, 150);
            g.FillRectangle(b3,235,200,70,100);
            g.FillRectangle(b2, 235, 125, 70, 50);
            g.FillRectangle(b4, 190, 40, 30, 70);
            int x = 200;
            int y = 50;
            int x1 = 210;
            int y1 = 50;
            for (int i = 0; i < 4; i++)
            {
                g.DrawLine(p1, x, y, x1, y1);
               
                y =y-20;
               
                y1 = y1-20;
                System.Threading.Thread.Sleep(1400);
            }
           
        }
    }
}
