using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect
{
    class Elipsa : Figura
    {
        public Point elip;
        int wSize, hSize;
          
        public Elipsa(Bitmap p)
        {
            this.rand = new Random();
            this.g = Graphics.FromImage(p);
            this.elip = new Point();
        }
        public void deseneaza(Bitmap p, int nrFiguri, Pen pen)
        {
            g.Clear(Color.White);
            int width = p.Width;
            int height = p.Height;

            for (int k = 0; k < nrFiguri; k++)
            {
                this.elip = new Point(rand.Next(0, width - 10), rand.Next(0, height - 10));
                this.wSize = rand.Next(10, width - elip.X);
                this.hSize = rand.Next(10, height - elip.Y);

                Size size = new Size(Math.Abs(wSize), Math.Abs(hSize));
                Rectangle elipsa = new Rectangle(elip, size);

                //Desenarea
                g.DrawEllipse(pen, elipsa);
               
            }
        }
    }
}
