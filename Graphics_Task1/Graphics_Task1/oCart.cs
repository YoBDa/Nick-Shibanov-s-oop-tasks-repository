using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace Graphics_Task1
{
    public class oCart 
    {
        //  L/5 is the wheels size, L/2 is the cart height
        enum FreightType { Coal, Sand, Wood, Oil }
        oRectangle Body { get; set; }
        oCircle Wheel { get; set; }
        public oCart(int L, FreightType FreightType)
        {
             Body = new oRectangle(new Point())
        }
        
    }
}
