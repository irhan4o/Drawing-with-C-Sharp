using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11._01.RandomColor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics d = e.Graphics;
            Random z = new Random();
            int x = 0;
            while (x < 10)
            {
                int r = z.Next(0, 256);
                int g = z.Next(0, 256);
                int b = z.Next(0, 256);
                d.Clear(Color.FromArgb(r, g, b));
                //for(int i =1;i<100000000;i++)
                System.Threading.Thread.Sleep(2000);
                x++;
            }
        }
    }
}
