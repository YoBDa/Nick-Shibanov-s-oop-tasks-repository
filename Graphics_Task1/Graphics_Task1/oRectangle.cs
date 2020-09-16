using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace Graphics_Task1
{
    public class oRectangle : oShape
    {
        public override Point Centre { get; set; }
        public override Point Size { get; set; }
        public override Color Color { get; set; }
        public oRectangle(Point Centre, Point Size, Color Color)
        {
            if (Centre == Point.Empty ||Size == Point.Empty) throw EmptyPointFoundException;
            this.Centre = Centre;
            this.Size = Size;
            this.Peaks[0] = new Point((int)(Centre.X - Size.X / 2), (int)(Centre.Y - Size.Y / 2));
            this.Peaks[1] = new Point((int)(Centre.X + Size.X / 2), (int)(Centre.Y - Size.Y / 2));
            this.Peaks[2] = new Point((int)(Centre.X + Size.X / 2), (int)(Centre.Y + Size.Y / 2));
            this.Peaks[3] = new Point((int)(Centre.X - Size.X / 2), (int)(Centre.Y + Size.Y / 2));
            this.Color = Color;
        }
        public override void Draw(Graphics gr)
        {
            gr.DrawRectangle(new Pen(Color), Peaks[0].X, Peaks[0].Y, Size.X, Size.Y);   
        }
        public override string Move(Point To)
        {
            throw new NotImplementedException();
        }
    }
}
