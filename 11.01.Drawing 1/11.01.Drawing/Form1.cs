using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _11._01.Drawing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //examp 1
            //Graphics g = e.Graphics;
            //g.Clear(Color.Red);
            //examp 2
            Random z = new Random();
            int r = z.Next(0, 256);
            int gr = z.Next(0,256);
            int b = z.Next(0, 256);
            Graphics g = e.Graphics;
            g.Clear(Color.FromArgb(r,gr,b));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //BackColor = Color.Green;
        }
    }
}
