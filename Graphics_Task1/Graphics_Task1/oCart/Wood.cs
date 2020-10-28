using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Graphics_Task1.oCart
{
    public class Wood : oBaseCart
    {
        public Wood(Point Centre, int Size) : base(Size, Centre)
        {
            Color = Color.SandyBrown;
            Title = "Wood";
        }
        private Wood(int Size, Point Centre) : base(Size, Centre)
        {

        }
        public override void Draw(Graphics gr)
        {
            base.Draw(gr);
            Point p4 = new Point(Body.Peaks[0].X + 30, Body.Peaks[0].Y);
            Point p3 = new Point(Body.Peaks[1].X - 30, Body.Peaks[0].Y);
            Point p1 = new Point(p4.X, p4.Y - 30);
            Point p2 = new Point(p3.X, p3.Y - 30);
            Point[] pts = { p1, p2, p3, p4 };
            (new oRectangle(pts, Color.Brown)).Draw(gr);
        }
    }
}
