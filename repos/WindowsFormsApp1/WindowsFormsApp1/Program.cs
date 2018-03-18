using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyForm
{
    class MyForm :Form
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            var graphics = e.Graphics;
            graphics.DrawLine(new Pen(Color.Red, 10), new Point(0, 0), new Point(150, 200));
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            graphics.DrawLine(new Pen(Color.Green, 10), 0, 0, 200, 150);
        }

        public static void Main(string[] args)
        {
            Application.Run(new MyForm());
        }
    }
}
