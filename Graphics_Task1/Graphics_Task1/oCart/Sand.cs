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
        public static Sand CreateSand(int Size, Point Centre)
        {
            oBaseCart.color = Color.SandyBrown;
            return new Sand(Size, Centre);
        }
        private Sand(int Size, Point Centre) : base(Size, Centre)
        {

        }
       
        public override void Draw(Graphics gr)
        {
            base.Draw(gr);
            Point p1 = Body.Peaks[0];
            Point p2 = Body.Peaks[1];
            Point p3 = new Point(Centre.X, Body.Peaks[0].Y - 30);
            Point[] pts = { p1, p2, p3 };
            Font f = new Font(new FontFamily(System.Drawing.Text.GenericFontFamilies.SansSerif), 20, FontStyle.Bold);
            gr.DrawString("Sand", f, Brushes.Black, Centre);
            gr.FillPolygon(Brushes.DarkGoldenrod,pts);
        }
        
        
    }
}
