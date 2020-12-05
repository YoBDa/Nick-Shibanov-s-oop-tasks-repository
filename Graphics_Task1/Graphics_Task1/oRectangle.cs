using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Text.Json;


namespace Graphics_Task1
{
    public class oRectangle : oShape
    {
        public oRectangle(Point Centre, Point Size, Color Color)
        {
            //if (Centre == Point.Empty || Size == Point.Empty) throw EmptyPointFoundException;
            this.Size = Size;
            this.Centre = Centre;
            this.Color = Color;
        }
        public oRectangle(Point[] peaks, Color Color)
        {
            this.Color = Color;
            int TLX = peaks[0].X;
            int TLY = peaks[0].Y;
            int BRX = peaks[2].X;
            int BRY = peaks[2].Y;
            int Length = (int)Math.Sqrt(Math.Pow(TLX - BRX, 2));
            int Width = (int)Math.Sqrt(Math.Pow(TLY - BRY, 2));
            this.Size = new Point(Length, Width);
            this.Centre = new Point(peaks[0].X + Length / 2, peaks[0].Y + Width / 2);

        }
        public override void Draw(Graphics gr)
        {
            Brush br = new SolidBrush(Color);
            gr.FillRectangle(br, Peaks[0].X, Peaks[0].Y, Size.X, Size.Y);   
        }
       

    }
}
