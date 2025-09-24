using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect
{
    class Triunghi : Figura
    {
        public Point x1,x2,x3;
       
        public Triunghi(Bitmap p)
        {
            this.rand = new Random();
            this.g = Graphics.FromImage(p);
            this.x1 = new Point();
            this.x2 = new Point();
            this.x3 = new Point();
        }
        public void deseneaza(Bitmap p, int nrFiguri, Pen pen)
        {
            g.Clear(Color.White);
            int width = p.Width;
            int height = p.Height;

            for (int k = 0; k < nrFiguri; k++)
            {
                ////punctele
                x1 = new Point(rand.Next(0, width + 1), rand.Next(0, height + 1));
                // x2 = new Point(rand.Next(0, width + 1), rand.Next(0, height + 1));
                x2 = new Point(rand.Next(0, width - x1.X), rand.Next(0, height - x1.Y));
                //x3 = new Point(rand.Next(0, width + 1), rand.Next(0, height + 1));
                x3 = new Point(rand.Next(0, width - x2.X), rand.Next(0, height - x2.Y));

                //deseneaza
                g.DrawPolygon(pen, new Point[] { x1, x2, x3 });
                
            }
        }
    }
}
