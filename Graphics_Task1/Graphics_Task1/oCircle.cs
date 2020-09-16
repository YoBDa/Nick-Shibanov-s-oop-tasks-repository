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
        public override Point Centre { get; set; }
        public override Point Size { get; set; }
        public override Color Color { get; set; }
        public int Radius { get;  set; }

        public oCircle(Point Centre, int Radius, Color Color)
        {
            if (Centre == Point.Empty || Radius == -1) throw EmptyPointFoundException;
            this.Centre = Centre;
            this.Radius = Radius;
            this.Peaks[0] = new Point((int)(Centre.X - Size.X / 2), (int)(Centre.Y - Size.Y / 2));
            this.Peaks[1] = new Point((int)(Centre.X + Size.X / 2), (int)(Centre.Y - Size.Y / 2));
            this.Peaks[2] = new Point((int)(Centre.X + Size.X / 2), (int)(Centre.Y + Size.Y / 2));
            this.Peaks[3] = new Point((int)(Centre.X - Size.X / 2), (int)(Centre.Y + Size.Y / 2));
            this.Size = new Point(Radius * 2, Radius * 2);
            this.Color = Color;
        }
        public void ChangeParameters(Point Centre, int Radius)
        {
            if (Centre.X == -1 || Centre.Y == -1)
            {
                Centre.X = this.Centre.X;
                Centre.Y = this.Centre.Y;   
            }
            if (Radius == -1)
            {
                Radius = this.Radius;
            }

            this.Centre = Centre;
            this.Radius = Radius;
        }
        public override void Draw(Graphics gr)
        {
            Rectangle r = new Rectangle(Peaks[0].X, Peaks[0].Y,Size.X,Size.Y);
            gr.DrawEllipse(new Pen(Brushes.Black), r);
        }
        public override string Move(Point To)
        {
            throw new NotImplementedException();
        }
    }
}
