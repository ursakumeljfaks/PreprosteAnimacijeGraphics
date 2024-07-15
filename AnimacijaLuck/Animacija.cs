using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimacijaLuck
{
    public partial class Animacija : Form
    {
        public Animacija()
        {
            InitializeComponent();
        }

        private int oranzneIndeks = 0;
        private void Lucke_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Pen pisalo = new Pen(Color.Black);
            Brush copicCrn = new SolidBrush(Color.Black);

            int x = 10;
            int y = 10;
            int visina = 50;
            int sirina = 500;
            int premik = x;
            int sirinaKroga = sirina / 10;

            g.FillRectangle(copicCrn, x, y, sirina, visina);
            for (int i = 0; i < 10; i++)
            {
                if (i < oranzneIndeks)
                {
                    g.FillEllipse(Brushes.Orange, premik, y, sirinaKroga, sirinaKroga);
                }
                else
                {
                    return;
                }
                premik += sirinaKroga;
            }
        }

        private void startGumb_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void stopGumb_Click(object sender, EventArgs e)
        {
            timer.Stop();
            oranzneIndeks = 0;
            Invalidate();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (oranzneIndeks < 10)
            {
                oranzneIndeks++;
                Invalidate();
            }
            else
            {
                oranzneIndeks = 0;
                Invalidate();
            }
        }
    }
}
