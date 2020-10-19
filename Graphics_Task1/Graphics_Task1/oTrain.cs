using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Graphics_Task1
{
    public class oTrain : oShape
    {
        private readonly int MULTIPLIER = 8;
        private oRectangle[] Couplers; // Lenghth 1/8 of cart 
        private oBaseCart[] Carts;
        public oTrain(oBaseCart[] Carts, Point Centre)
        {
            Couplers = new oRectangle[Carts.Length - 1];
            this.Carts = Carts;
            this.Centre = Centre;
        }
        public override void Draw(Graphics gr)
        {
            int CouplerLength = Carts[0].Size.X / MULTIPLIER;
            int CouplerWidth = Carts[0].Size.Y / MULTIPLIER;
            int FullLenght = Carts[0].Size.X * Carts.Length + CouplerLength * Couplers.Length;

            Point TopLeftCorner = new Point(Centre.X - FullLenght / 2, Centre.Y - Carts[0].Size.Y / 2);
            Point CurrentCentre = new Point(TopLeftCorner.X + Carts[0].Size.X / 2, TopLeftCorner.Y + Carts[0].Size.Y / 2);
            Carts[0].Move(CurrentCentre);
            Point p3 = Carts[0].Body.Peaks[2];
            Point p0 = new Point(p3.X, p3.Y - CouplerWidth);
            Point p1 = new Point(p0.X + CouplerLength, p0.Y);
            Point p2 = new Point(p3.X + CouplerLength, p3.Y);
            Point[] pts = { p0, p1, p2, p3 };
            Couplers[0] = new oRectangle(pts, Color.Black);
            for (int i = 1; i < Carts.Length; i++)
            {
                CurrentCentre = new Point(CurrentCentre.X + Carts[0].Size.X + CouplerLength,CurrentCentre.Y);
                Carts[i].Move(CurrentCentre);
                if (i < Carts.Length - 1)
                {
                    p3 = Carts[i].Body.Peaks[2];
                    p0 = new Point(p3.X, p3.Y - CouplerWidth);
                    p1 = new Point(p0.X + CouplerLength, p0.Y);
                    p2 = new Point(p3.X + CouplerLength, p3.Y);
                    pts = new Point[] { p0, p1, p2, p3 };
                    Couplers[i] = new oRectangle(pts, Color.Black);
                }
            }
            for (int i = 0; i < Carts.Length; i++)
            {
                if (Carts[i] is oCart.Coal) ((oCart.Coal)Carts[i]).Draw(gr);
                if (Carts[i] is oCart.Sand) ((oCart.Sand)Carts[i]).Draw(gr);
                if (Carts[i] is oCart.Wood) ((oCart.Wood)Carts[i]).Draw(gr);
            }
            for (int i = 0; i < Couplers.Length; i++)
            {
                Couplers[i].Draw(gr);
            }
            

        }
    }
}
