using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace LogoProject
{
    public partial class Form1 : Form
    {
        Pen drawPen = new Pen(Color.White, 50);
        SolidBrush drawBrush = new SolidBrush(Color.FromArgb(97, 164, 225));
        Pen drawPen2 = new Pen(Color.FromArgb(97, 164, 225), 30);
        Font drawFont = new Font("Mistral", 62, FontStyle.Bold);
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

           
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            Graphics g;
            g = this.CreateGraphics();
            g.FillEllipse(drawBrush, 40, 40, 600, 600);
            g.DrawEllipse(drawPen, 120, 120, 440, 440);
            g.DrawArc(drawPen, 240, 240, 200, 200, 280, 310);
            g.DrawLine(drawPen, 269, 269, 480, 60);
            g.DrawLine(drawPen2, 299, 299, 420, 180);

            drawPen2.Color = Color.Gainsboro;
            g.DrawEllipse(drawPen2, 30, 30, 620, 620);
            drawBrush.Color = Color.FromArgb(61,103,141);
            g.TranslateTransform(400, 520);
            g.RotateTransform(-50);
            g.DrawString("Day", drawFont, drawBrush, 0, 0);
            g.ResetTransform();

        }
    }
}
