using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect
{
    class CurbeBezier : Figura
    {
        public Point x1;
        public Point x2;
        public Point x3;
        public Point x4;

        public CurbeBezier(Bitmap p)
        {
            this.rand = new Random();
            this.g = Graphics.FromImage(p);
            this.x1 = new Point();
            this.x2 = new Point();
            this.x3 = new Point();
            this.x4 = new Point();
        }
        public void deseneaza(Bitmap p , int nrFiguri, Pen pen)
        {
            g.Clear(Color.White);
            int width = p.Width;
            int height = p.Height;
            Point[] tablou = new Point[4];

            for (int k = 0; k < nrFiguri; k++)
            { 
                tablou[0] = new Point(rand.Next(0, width), 0);
                tablou[1] = new Point(rand.Next(0, width + 1), rand.Next(0, height + 1));
                tablou[2] = new Point(rand.Next(0, width + 1), rand.Next(0, height + 1));
                tablou[3] = new Point(rand.Next(0, width + 1), height);

                g.DrawBeziers(pen, tablou);
                
            }
        }
    }
}
