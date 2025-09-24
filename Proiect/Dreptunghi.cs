using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect
{
    class Dreptunghi : Figura
    {
        public Point d;
        int wSize, hSize;
       
        public Dreptunghi(Bitmap p)
        {
            this.rand = new Random();
            this.g = Graphics.FromImage(p);
            this.d = new Point();
        }
        public void deseneaza(Bitmap p, int nrFiguri, Pen pen)
        {
            g.Clear(Color.White);
            int width = p.Width;
            int height = p.Height;
            Point centru = new Point(0, 0);

            for (int k = 0; k < nrFiguri; k++)
            {
                // centru.X = rand.Next(0, x1 - 10);
                this.d = new Point(rand.Next(0, width + 1), rand.Next(0, height + 1));
                this.wSize = rand.Next(0, width + 1) - d.X;
                this.hSize = rand.Next(0, height + 1) - d.Y;


                Size size = new Size(Math.Abs(wSize), Math.Abs(hSize));
                Rectangle elipsa = new Rectangle(d, size);

                //Desenarea
                g.DrawRectangle(pen, elipsa);
              
            }
        }
    }
}
