using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect
{
    public class Manager
    {
        public Manager()
        {
           
        }
        public int optiune;

        public void alege_figura(Bitmap p, int optiune , string textBox1)
        {
            Pen pen1 = new Pen(Color.Black);
            int nrFiguri = int.Parse(textBox1);
            switch (optiune)
            {
                case 1:
                    Linie l = new Linie(p);
                    l.deseneaza(p, nrFiguri, pen1);
                    break;
                case 2:
                    Triunghi t = new Triunghi(p);
                    t.deseneaza(p,nrFiguri, pen1);
                    break;
                case 3:
                    Elipsa eli= new Elipsa(p);
                    eli.deseneaza(p,nrFiguri, pen1);
                    break;
                case 4:
                    Dreptunghi d = new Dreptunghi(p);
                    d.deseneaza(p,nrFiguri, pen1);
                    break;
                case 5:
                     CurbeBezier bezier = new CurbeBezier(p);
                    bezier.deseneaza(p,nrFiguri, pen1);

                    break;
            }
        }
    }
}

