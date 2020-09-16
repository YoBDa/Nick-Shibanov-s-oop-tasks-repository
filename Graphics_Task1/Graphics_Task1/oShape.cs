using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Graphics_Task1
{
    abstract public class oShape
    {
        internal Exception EmptyPointFoundException = new Exception("Point has no any coordinates.");
        internal Point[] Peaks = new Point[4]; // All rectangle points (top left is [0])
        abstract public Color Color { get; set}
        abstract public Point Centre { get; set; }
        abstract public Point Size { get; set; }
        abstract public void Draw(Graphics gr);
        abstract public string Move(Point To);
    }
}