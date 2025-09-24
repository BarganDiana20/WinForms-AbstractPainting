
namespace Proiect
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.close = new System.Windows.Forms.ToolStripButton();
            this.save_Button = new System.Windows.Forms.ToolStripButton();
            this.printare_Button = new System.Windows.Forms.ToolStripButton();
            this.inkButton = new System.Windows.Forms.ToolStripButton();
            this.figuri = new System.Windows.Forms.ToolStripDropDownButton();
            this.linieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.triunghiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.elipsaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dreptunghiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.curbeBezierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.start = new System.Windows.Forms.ToolStripButton();
            this.culoare = new System.Windows.Forms.ToolStripButton();
            this.umplerefigura_button = new System.Windows.Forms.ToolStripButton();
            this.info = new System.Windows.Forms.ToolStripButton();
            this.clearButton = new System.Windows.Forms.ToolStripButton();
            this.p = new System.Windows.Forms.PictureBox();
            this.sf = new System.Windows.Forms.SaveFileDialog();
            this.pd = new System.Windows.Forms.PrintDialog();
            this.print = new System.Drawing.Printing.PrintDocument();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.p)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.close,
            this.save_Button,
            this.printare_Button,
            this.inkButton,
            this.figuri,
            this.textBox1,
            this.start,
            this.culoare,
            this.umplerefigura_button,
            this.info,
            this.clearButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1166, 73);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // close
            // 
            this.close.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.close.Image = ((System.Drawing.Image)(resources.GetObject("close.Image")));
            this.close.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.close.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(64, 68);
            this.close.Text = "close_Button";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // save_Button
            // 
            this.save_Button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.save_Button.Image = ((System.Drawing.Image)(resources.GetObject("save_Button.Image")));
            this.save_Button.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.save_Button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.save_Button.Name = "save_Button";
            this.save_Button.Size = new System.Drawing.Size(54, 68);
            this.save_Button.Text = "save";
            this.save_Button.Click += new System.EventHandler(this.save_Button_Click);
            // 
            // printare_Button
            // 
            this.printare_Button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.printare_Button.Image = ((System.Drawing.Image)(resources.GetObject("printare_Button.Image")));
            this.printare_Button.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.printare_Button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printare_Button.Name = "printare_Button";
            this.printare_Button.Size = new System.Drawing.Size(52, 68);
            this.printare_Button.Text = "print";
            this.printare_Button.Click += new System.EventHandler(this.printare_Button_Click);
            // 
            // inkButton
            // 
            this.inkButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.inkButton.Image = ((System.Drawing.Image)(resources.GetObject("inkButton.Image")));
            this.inkButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.inkButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.inkButton.Name = "inkButton";
            this.inkButton.Size = new System.Drawing.Size(68, 68);
            this.inkButton.Text = "inkButton";
            this.inkButton.Click += new System.EventHandler(this.inkButton_Click);
            // 
            // figuri
            // 
            this.figuri.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.figuri.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.linieToolStripMenuItem,
            this.triunghiToolStripMenuItem,
            this.elipsaToolStripMenuItem,
            this.dreptunghiToolStripMenuItem,
            this.curbeBezierToolStripMenuItem});
            this.figuri.Image = ((System.Drawing.Image)(resources.GetObject("figuri.Image")));
            this.figuri.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.figuri.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.figuri.Name = "figuri";
            this.figuri.Size = new System.Drawing.Size(82, 68);
            this.figuri.Text = "SelectFigure";
            this.figuri.Click += new System.EventHandler(this.figuri_Click);
            // 
            // linieToolStripMenuItem
            // 
            this.linieToolStripMenuItem.CheckOnClick = true;
            this.linieToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("linieToolStripMenuItem.Image")));
            this.linieToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.linieToolStripMenuItem.Name = "linieToolStripMenuItem";
            this.linieToolStripMenuItem.Size = new System.Drawing.Size(238, 60);
            this.linieToolStripMenuItem.Text = "Linie";
            this.linieToolStripMenuItem.Click += new System.EventHandler(this.linieToolStripMenuItem_Click);
            // 
            // triunghiToolStripMenuItem
            // 
            this.triunghiToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("triunghiToolStripMenuItem.Image")));
            this.triunghiToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.triunghiToolStripMenuItem.Name = "triunghiToolStripMenuItem";
            this.triunghiToolStripMenuItem.Size = new System.Drawing.Size(238, 60);
            this.triunghiToolStripMenuItem.Text = "Triunghi";
            this.triunghiToolStripMenuItem.Click += new System.EventHandler(this.triunghiToolStripMenuItem_Click);
            // 
            // elipsaToolStripMenuItem
            // 
            this.elipsaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("elipsaToolStripMenuItem.Image")));
            this.elipsaToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.elipsaToolStripMenuItem.Name = "elipsaToolStripMenuItem";
            this.elipsaToolStripMenuItem.Size = new System.Drawing.Size(238, 60);
            this.elipsaToolStripMenuItem.Text = "Elipsa";
            this.elipsaToolStripMenuItem.Click += new System.EventHandler(this.elipsaToolStripMenuItem_Click);
            // 
            // dreptunghiToolStripMenuItem
            // 
            this.dreptunghiToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("dreptunghiToolStripMenuItem.Image")));
            this.dreptunghiToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.dreptunghiToolStripMenuItem.Name = "dreptunghiToolStripMenuItem";
            this.dreptunghiToolStripMenuItem.Size = new System.Drawing.Size(238, 60);
            this.dreptunghiToolStripMenuItem.Text = "Dreptunghi";
            this.dreptunghiToolStripMenuItem.Click += new System.EventHandler(this.dreptunghiToolStripMenuItem_Click);
            // 
            // curbeBezierToolStripMenuItem
            // 
            this.curbeBezierToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("curbeBezierToolStripMenuItem.Image")));
            this.curbeBezierToolStripMenuItem.Name = "curbeBezierToolStripMenuItem";
            this.curbeBezierToolStripMenuItem.Size = new System.Drawing.Size(238, 60);
            this.curbeBezierToolStripMenuItem.Text = "Curbe Bezier";
            this.curbeBezierToolStripMenuItem.Click += new System.EventHandler(this.curbeBezierToolStripMenuItem_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(119, 73);
            // 
            // start
            // 
            this.start.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.start.Image = ((System.Drawing.Image)(resources.GetObject("start.Image")));
            this.start.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.start.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(54, 68);
            this.start.Text = "Generare";
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // culoare
            // 
            this.culoare.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.culoare.Image = ((System.Drawing.Image)(resources.GetObject("culoare.Image")));
            this.culoare.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.culoare.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.culoare.Name = "culoare";
            this.culoare.Size = new System.Drawing.Size(52, 68);
            this.culoare.Text = "culori";
            this.culoare.Click += new System.EventHandler(this.culoare_Click);
            // 
            // umplerefigura_button
            // 
            this.umplerefigura_button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.umplerefigura_button.Image = ((System.Drawing.Image)(resources.GetObject("umplerefigura_button.Image")));
            this.umplerefigura_button.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.umplerefigura_button.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.umplerefigura_button.Name = "umplerefigura_button";
            this.umplerefigura_button.Size = new System.Drawing.Size(52, 68);
            this.umplerefigura_button.Text = "umplere";
            this.umplerefigura_button.Click += new System.EventHandler(this.umplerefigura_button_Click);
            // 
            // info
            // 
            this.info.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.info.Image = ((System.Drawing.Image)(resources.GetObject("info.Image")));
            this.info.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.info.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(54, 68);
            this.info.Text = "info_Button";
            this.info.Click += new System.EventHandler(this.info_Click);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.clearButton.Image = ((System.Drawing.Image)(resources.GetObject("clearButton.Image")));
            this.clearButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.clearButton.Name = "clearButton";
            this.clearButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.clearButton.Size = new System.Drawing.Size(125, 68);
            this.clearButton.Text = "ClearPage";
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // p
            // 
            this.p.BackColor = System.Drawing.Color.White;
            this.p.Location = new System.Drawing.Point(25, 99);
            this.p.Margin = new System.Windows.Forms.Padding(4);
            this.p.Name = "p";
            this.p.Size = new System.Drawing.Size(1112, 534);
            this.p.TabIndex = 1;
            this.p.TabStop = false;
            this.p.MouseClick += new System.Windows.Forms.MouseEventHandler(this.p_MouseClick);
            // 
            // pd
            // 
            this.pd.Document = this.print;
            this.pd.UseEXDialog = true;
            // 
            // print
            // 
            this.print.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.print_PrintPage);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1166, 658);
            this.Controls.Add(this.p);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.p)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton close;
        private System.Windows.Forms.ToolStripButton save_Button;
        private System.Windows.Forms.ToolStripButton printare_Button;
        private System.Windows.Forms.ToolStripButton inkButton;
        private System.Windows.Forms.ToolStripDropDownButton figuri;
        private System.Windows.Forms.ToolStripTextBox textBox1;
        private System.Windows.Forms.ToolStripButton start;
        private System.Windows.Forms.ToolStripButton culoare;
        private System.Windows.Forms.ToolStripButton umplerefigura_button;
        private System.Windows.Forms.ToolStripButton info;
        private System.Windows.Forms.PictureBox p;
        private System.Windows.Forms.SaveFileDialog sf;
        private System.Windows.Forms.ToolStripMenuItem linieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem triunghiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem elipsaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dreptunghiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem curbeBezierToolStripMenuItem;
        private System.Windows.Forms.PrintDialog pd;
        private System.Drawing.Printing.PrintDocument print;
        public System.Windows.Forms.ToolStripButton clearButton;
    }
}

