using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Graphics_Task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            int Size = 200;
            oBaseCart crt;
            Graphics gr = this.CreateGraphics();
            if (WoodRadio.Checked)
            {
                crt = oCart.Wood.CreateWood(Size, new Point(e.X, e.Y));
                ((oCart.Wood)crt).Draw(gr);
            }

            else if (CoalRadio.Checked)
            {
                crt = oCart.Coal.CreateCoal(Size, new Point(e.X, e.Y));
                ((oCart.Coal)crt).Draw(gr);
            }
            else if (SandRadio.Checked)
            {
                crt = oCart.Sand.CreateSand(Size, new Point(e.X, e.Y));
                ((oCart.Sand)crt).Draw(gr);
            }
            else
            {
                Random rnd = new Random();
                oBaseCart[] carts= new oBaseCart[(int)nudCartsCount.Value];
                for (int i = 0; i < nudCartsCount.Value; i++)
                {
                    switch (rnd.Next(0, 3))
                    {
                        case 0: carts[i] = oCart.Coal.CreateCoal(Size, Point.Empty);
                            break;
                        case 1:
                            carts[i] = oCart.Sand.CreateSand(Size, Point.Empty);
                            break;
                        case 2:
                            carts[i] = oCart.Wood.CreateWood(Size, Point.Empty);
                            break;

                    }
                }
                oTrain train = new oTrain(carts, new Point(e.X, e.Y));
                train.Draw(gr);
            }

            
            
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {

        }
    }
}
