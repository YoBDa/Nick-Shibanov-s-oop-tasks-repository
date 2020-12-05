using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Text.Json;



namespace Graphics_Task1
{
    abstract public class oShape
    {
        internal Exception EmptyPointFoundException = new Exception("Point has no any coordinates.");
        
        internal Point[] Peaks = new Point[4]; // All rectangle points (top left is [0])
        public Color Color { get; set; }
        private Point centre = new Point(0, 0);
        private Point size = new Point(0, 0);
        public Point Centre
        {
            get { return centre; }
            set
            {
                centre = value;
                this.Peaks[0] = new Point((int)(centre.X - Size.X / 2), (int)(centre.Y - Size.Y / 2));
                this.Peaks[1] = new Point((int)(centre.X + Size.X / 2), (int)(centre.Y - Size.Y / 2));
                this.Peaks[2] = new Point((int)(centre.X + Size.X / 2), (int)(centre.Y + Size.Y / 2));
                this.Peaks[3] = new Point((int)(centre.X - Size.X / 2), (int)(centre.Y + Size.Y / 2));
            }
        }
        public Point Size
        {
            get { return size; }
            set
            {
                size = value;
                this.Peaks[0] = new Point((int)(centre.X - size.X / 2), (int)(centre.Y - size.Y / 2));
                this.Peaks[1] = new Point((int)(centre.X + size.X / 2), (int)(centre.Y - size.Y / 2));
                this.Peaks[2] = new Point((int)(centre.X + size.X / 2), (int)(centre.Y + size.Y / 2));
                this.Peaks[3] = new Point((int)(centre.X - size.X / 2), (int)(centre.Y + size .Y / 2));
            }
        }

        abstract public void Draw(Graphics gr);
        virtual public void Move(Point To)
        {
            this.Centre = To;
        }
      
    }
}