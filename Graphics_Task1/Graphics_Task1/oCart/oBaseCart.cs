using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace Graphics_Task1
{
    public class oBaseCart : oShape
    {
        //  L/5 is the wheels size, L/2 is the cart height

        internal string Title = "NOTEXT";
        internal double WheelM = 5.0;
        internal oRectangle Body { get; set; }
        internal oCircle RWheel { get; set; }
        internal oCircle LWheel { get; set; }
        internal Color color = Color.Gray;

        public oBaseCart(int Size, Point Centre)
        {
            Color = color;
            Body = new oRectangle(Centre, new Point(Size, Size / 2), Color.FromArgb(128, Color));
            int WheelDiameter = (int)(Size / WheelM);
            Point LeftWheelCentre = new Point(Body.Peaks[3].X + WheelDiameter/2, Body.Peaks[3].Y + WheelDiameter/2);
            Point RightWheelCentre = new Point(Body.Peaks[2].X - WheelDiameter/2, Body.Peaks[2].Y + WheelDiameter/2);
            LWheel = new oCircle(LeftWheelCentre, WheelDiameter / 2, Color.SteelBlue);
            RWheel = new oCircle(RightWheelCentre, WheelDiameter / 2, Color.SteelBlue);
            this.Size = new Point(Size, Size / 2+WheelDiameter);
            this.Centre = new Point(Centre.X, Body.Peaks[0].Y+this.Size.Y/2);
        }

        
        
        public override void Draw(Graphics gr)
        {
            Body.Draw(gr);
            RWheel.Draw(gr);
            LWheel.Draw(gr);
            Font f = new Font(new FontFamily(System.Drawing.Text.GenericFontFamilies.SansSerif),
                (float)Math.Pow(Math.Log(Size.X),1.7), FontStyle.Bold);
            gr.DrawString(Title, f, Brushes.Black, this.Body.Centre);
        }
        public override void Move(Point To)
        {
            
            int DiffX = To.X - this.Centre.X;
            int DiffY = To.Y - this.Centre.Y;
            this.Centre = To;
            Body = new oRectangle(new Point(Body.Centre.X + DiffX,Body.Centre.Y + DiffY), new Point(Size.X, Size.X / 2), Color.FromArgb(128, Color));
            int WheelDiameter = (int)(Size.X / WheelM);
            Point LeftWheelCentre = new Point(Body.Peaks[3].X + WheelDiameter / 2, Body.Peaks[3].Y + WheelDiameter / 2);
            Point RightWheelCentre = new Point(Body.Peaks[2].X - WheelDiameter / 2, Body.Peaks[2].Y + WheelDiameter / 2);
            LWheel = new oCircle(LeftWheelCentre, WheelDiameter / 2, Color.SteelBlue);
            RWheel = new oCircle(RightWheelCentre, WheelDiameter / 2, Color.SteelBlue);
        }
    }
}
