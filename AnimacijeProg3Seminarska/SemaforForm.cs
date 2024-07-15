using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimacijeProg3Seminarska
{
    public partial class SemaforForm : Form
    {
        public SemaforForm()
        {
            InitializeComponent();
        }

        private enum BarveSemaforja
        {
            Rdeca,
            Rumena,
            Zelena,
            Siva
        }

        BarveSemaforja trenutnaBarva = BarveSemaforja.Siva;

        private void Semafor_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Brush copic = new SolidBrush(Color.Black);

            int x = 1;
            int y = 1;
            int visina = 300;
            int sirina = 100;
            int premik = 1;
            int visinaKroga = 100;

            // narisemo pravokotnik s sivo in ga pobarvamo na črno
            g.FillRectangle(copic, x, y, sirina, visina);

            // pobarvamo kroge semaforja, ce je trenutna barva enaka rdeci/zeleni/sivi, jo pobarvamo na to, drugace na sivo
            g.FillEllipse(trenutnaBarva == BarveSemaforja.Rdeca ? Brushes.Red : Brushes.Gray, 
                x + premik, y + premik, visinaKroga, visinaKroga);
            g.FillEllipse(trenutnaBarva == BarveSemaforja.Rumena ? Brushes.Yellow : Brushes.Gray, 
                x + premik, y + premik + visinaKroga, visinaKroga, visinaKroga);
            g.FillEllipse(trenutnaBarva == BarveSemaforja.Zelena ? Brushes.Green : Brushes.Gray, 
                x + premik, y + premik + 2 * visinaKroga, visinaKroga, visinaKroga);

        }

        private void rdecaGumb_Click(object sender, EventArgs e)
        {
            trenutnaBarva = BarveSemaforja.Rdeca;
            Invalidate();
        }

        private void rumenaGumb_Click(object sender, EventArgs e)
        {
            trenutnaBarva = BarveSemaforja.Rumena;
            Invalidate();
        }

        private void zelenaGumb_Click(object sender, EventArgs e)
        {
            trenutnaBarva = BarveSemaforja.Zelena;
            Invalidate();
        }
    }
}
