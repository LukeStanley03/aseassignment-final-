using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ASEASSIGNMENT
{
    public class Circle : Shape
    {
        int radius;

        public Circle(int x, int y, int radius) : base(x, y)
        {
            this.radius = radius;
        }

        public override void draw(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 5);
            SolidBrush brush = new SolidBrush(Color.White);
            g.FillEllipse(brush, x, y, radius, radius);
            g.DrawEllipse(pen, x, y, radius, radius);

        }
    }
}