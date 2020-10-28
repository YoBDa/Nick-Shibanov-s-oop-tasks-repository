using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Graphics_Task1.oCart
{
    public class Sand : oBaseCart
    {
       
        public Sand(Point Centre, int Size) : base(Size, Centre)
        {
            Color = Color.SandyBrown;
            Title = "Sand";
        }
       
        public override void Draw(Graphics gr)
        {
            base.Draw(gr);
            Point p1 = Body.Peaks[0];
            Point p2 = Body.Peaks[1];
            Point p3 = new Point(Centre.X, Body.Peaks[0].Y - 30);
            Point[] pts = { p1, p2, p3 };
            gr.FillPolygon(Brushes.DarkGoldenrod,pts);
        }
        
        
    }
}
