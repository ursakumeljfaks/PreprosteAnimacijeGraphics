using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetodeGraphics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Pen pisalo = new Pen(Color.Black);
            Brush copic = new SolidBrush(Color.Black);

            int x1 = 0;
            int y1 = 0;
            PointF tocka = new PointF(100, 100);

            g.DrawString("Progiranje 3", new Font("Arial", 12), Brushes.Black, x1, y1);
            g.DrawString("Progiranje 3", new Font("Arial", 12), Brushes.Black, tocka);




        }
    }
}
