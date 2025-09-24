using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Proiect
{
    public partial class Form1 : Form
    {
        public Bitmap DrawZona;
        Pen penpixel2 = new Pen(Color.Black, 2);
        public int optiune = 1;           // 1 = line, 2 = triangle, 3 = ellipse, 4 = rectangle, 5 = bezier
        public bool fill_optiune = false; // for flood fill
        ColorDialog cd = new ColorDialog();

        public Form1()
        {
            InitializeComponent();

            // initialize the whiteboard
            DrawZona = new Bitmap(p.Width, p.Height);
            using (Graphics g = Graphics.FromImage(DrawZona))
            {
                g.Clear(Color.White);
            }
            p.Image = DrawZona;
        }

        // ======================= EXISTING EVENTS =======================
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void inkButton_Click(object sender, EventArgs e)
        {
            // Button inactive because Form2 no longer exists
            inkButton.Enabled = false;
            MessageBox.Show("Ink consumption functionality is no longer available.");
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void info_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Abstract paintings");
        }

        // ======================= FIGURE GENERATION =======================
        private void start_Click(object sender, EventArgs e)
        {
            Graphics g = Graphics.FromImage(DrawZona);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            Pen pen = new Pen(penpixel2.Color, 2);
            Random rnd = new Random();

            if (!int.TryParse(textBox1.Text, out int nrFiguri)) return;

            for (int i = 0; i < nrFiguri; i++)
            {
                switch (optiune)
                {
                    case 1: // Line
                        int x1 = rnd.Next(DrawZona.Width);
                        int y1 = rnd.Next(DrawZona.Height);
                        int x2 = rnd.Next(DrawZona.Width);
                        int y2 = rnd.Next(DrawZona.Height);
                        g.DrawLine(pen, x1, y1, x2, y2);
                        break;

                    case 2: // Triangle
                        Point p1 = new Point(rnd.Next(DrawZona.Width), rnd.Next(DrawZona.Height));
                        Point p2 = new Point(rnd.Next(DrawZona.Width), rnd.Next(DrawZona.Height));
                        Point p3 = new Point(rnd.Next(DrawZona.Width), rnd.Next(DrawZona.Height));
                        g.DrawPolygon(pen, new Point[] { p1, p2, p3 });
                        break;

                    case 3: // Ellipse
                        int ew = rnd.Next(20, 100);
                        int eh = rnd.Next(20, 100);
                        int ex = rnd.Next(0, Math.Max(1, DrawZona.Width - ew));
                        int ey = rnd.Next(0, Math.Max(1, DrawZona.Height - eh));
                        g.DrawEllipse(pen, ex, ey, ew, eh);
                        break;

                    case 4: // Rectangle
                        int w = rnd.Next(20, 100);
                        int h = rnd.Next(20, 100);
                        int x = rnd.Next(0, Math.Max(1, DrawZona.Width - w));
                        int y = rnd.Next(0, Math.Max(1, DrawZona.Height - h));
                        g.DrawRectangle(pen, x, y, w, h);
                        break;

                    case 5: // Bezier curves
                        Point b1 = new Point(rnd.Next(DrawZona.Width), rnd.Next(DrawZona.Height));
                        Point b2 = new Point(rnd.Next(DrawZona.Width), rnd.Next(DrawZona.Height));
                        Point b3 = new Point(rnd.Next(DrawZona.Width), rnd.Next(DrawZona.Height));
                        Point b4 = new Point(rnd.Next(DrawZona.Width), rnd.Next(DrawZona.Height));
                        g.DrawBezier(pen, b1, b2, b3, b4);
                        break;
                }
            }

            p.Invalidate();
        }

        // ======================= CLEAR =======================
        private void clearButton_Click(object sender, EventArgs e)
        {
            using (Graphics g = Graphics.FromImage(DrawZona))
            {
                g.Clear(Color.White);
            }
            p.Invalidate();
        }

        // ======================= COLOR =======================
        private void culoare_Click(object sender, EventArgs e)
        {
            if (cd.ShowDialog() == DialogResult.OK)
            {
                penpixel2.Color = cd.Color;
            }
        }

        // ======================= FLOOD FILL =======================
        private void umplerefigura_button_Click(object sender, EventArgs e)
        {
            fill_optiune = !fill_optiune;
        }

        private void p_MouseClick(object sender, MouseEventArgs e)
        {
            if (fill_optiune && e.X >= 0 && e.X < DrawZona.Width && e.Y >= 0 && e.Y < DrawZona.Height)
            {
                Bitmap fillbmp = new Bitmap(p.Image);
                FloodFill(fillbmp, new Point(e.X, e.Y), fillbmp.GetPixel(e.X, e.Y), penpixel2.Color);
                p.Image = fillbmp;
                DrawZona = fillbmp;
            }
        }

        private void FloodFill(Bitmap bmp, Point pt, Color targetColor, Color replacementColor)
        {
            if (targetColor.ToArgb() == replacementColor.ToArgb()) return;

            Stack<Point> pixels = new Stack<Point>();
            pixels.Push(pt);

            while (pixels.Count > 0)
            {
                Point a = pixels.Pop();
                if (a.X >= 0 && a.X < bmp.Width && a.Y >= 0 && a.Y < bmp.Height)
                {
                    if (bmp.GetPixel(a.X, a.Y).ToArgb() == targetColor.ToArgb())
                    {
                        bmp.SetPixel(a.X, a.Y, replacementColor);
                        pixels.Push(new Point(a.X - 1, a.Y));
                        pixels.Push(new Point(a.X + 1, a.Y));
                        pixels.Push(new Point(a.X, a.Y - 1));
                        pixels.Push(new Point(a.X, a.Y + 1));
                    }
                }
            }
            p.Refresh();
        }

        // ======================= SAVE =======================
        private void save_Button_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefileDialog = new SaveFileDialog();
            savefileDialog.Filter = "Jpeg Image|*.jpg";
            savefileDialog.Title = "Save an Image File";

            if (savefileDialog.ShowDialog() == DialogResult.OK && savefileDialog.FileName != "")
            {
                p.Image.Save(savefileDialog.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
        }

        // ======================= PRINT =======================
        private void printare_Button_Click(object sender, EventArgs e)
        {
            PrintDialog pd = new PrintDialog();
            System.Drawing.Printing.PrintDocument print = new System.Drawing.Printing.PrintDocument();
            pd.Document = print;
            print.PrintPage += print_PrintPage;

            if (pd.ShowDialog() == DialogResult.OK)
            {
                print.Print();
            }
        }

        private void print_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(p.Width, p.Height);
            p.DrawToBitmap(bm, new Rectangle(0, 0, p.Width, p.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }

        // ======================= FIGURE SELECTION MENU =======================
        private void linieToolStripMenuItem_Click(object sender, EventArgs e) => optiune = 1;
        private void triunghiToolStripMenuItem_Click(object sender, EventArgs e) => optiune = 2;
        private void elipsaToolStripMenuItem_Click(object sender, EventArgs e) => optiune = 3;
        private void dreptunghiToolStripMenuItem_Click(object sender, EventArgs e) => optiune = 4;
        private void curbeBezierToolStripMenuItem_Click(object sender, EventArgs e) => optiune = 5;

        private void figuri_Click(object sender, EventArgs e)
        {
           
        }
    }
}

