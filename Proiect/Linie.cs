using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect
{
    
       class Linie : Figura
        {
            public Point x1;
            public Point x2;

            public Linie(Bitmap p)
            {
                this.rand = new Random();
                this.g = Graphics.FromImage(p);
                this.x1 = new Point();
                this.x2 = new Point();
            }
            public void deseneaza(Bitmap p, int nrFiguri, Pen pen)
            {
                g.Clear(Color.White);
                int width = p.Width;
                int height = p.Height;

                for (int k = 0; k < nrFiguri; k++)
                {
                    //punctele
                    x1 = new Point(rand.Next(0, width + 1), rand.Next(0, height + 1));
                    x2 = new Point(rand.Next(0, width - x1.X), rand.Next(0, height - x1.Y));

                    //deseneaza
                    g.DrawLine(pen, x1, x2);
                }
            }
        }
    
}
