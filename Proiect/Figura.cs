using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect
{
    abstract class Figura
    {
        public Random rand;
        public Graphics g;
        public PictureBox p;
        public Bitmap DrawZona; //zona de desenare
    }

}
