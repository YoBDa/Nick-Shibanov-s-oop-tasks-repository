using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace Graphics_Task1
{
    public class oCircle : oShape
    {
        public int Radius { get;  set; }

        public oCircle(Point Centre, int Radius, Color Color)
        {
            if (Centre == Point.Empty || Radius == -1) throw EmptyPointFoundException;
            this.Centre = Centre;
            this.Radius = Radius;
            this.Size = new Point(Radius * 2, Radius * 2);
            this.Color = Color;
        }
        
        public override void Draw(Graphics gr)
        {
            Brush br = new SolidBrush(Color);
            Rectangle r = new Rectangle(Peaks[0].X, Peaks[0].Y,Size.X,Size.Y);
            gr.FillEllipse(br, r);
        }
   
    }
}
