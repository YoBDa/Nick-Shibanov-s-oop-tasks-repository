using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace Graphics_Task1
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private List<oShape> oShapes = new List<oShape>();
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            int Size = 150;
            oShape s;
            Graphics gr = this.CreateGraphics();
            if (WoodRadio.Checked)
            {
                s = oCart.Wood.CreateWood(Size, new Point(e.X, e.Y));
                s.Draw(gr);
                oShapes.Add(s);
            }

            else if (CoalRadio.Checked)
            {
                s = oCart.Coal.CreateCoal(Size, new Point(e.X, e.Y));
                s.Draw(gr);
                oShapes.Add(s);
            }
            else if (SandRadio.Checked)
            {
                s = oCart.Sand.CreateSand(Size, new Point(e.X, e.Y));
                s.Draw(gr);
                oShapes.Add(s);
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
                s = new oTrain(carts, new Point(e.X, e.Y));
                oShapes.Add(s);
                s.Draw(gr);
            }
            listBox1.Items.Add(listBox1.Items.Count + " " + s.GetType().ToString());
            
            
        }

      

        private void Move_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1) return;
            int Id = listBox1.SelectedIndex;
            string Direction = "none";
            if (((Button)sender).Name == "btUp") Direction = "up";
            if (((Button)sender).Name == "btDown") Direction = "down";
            if (((Button)sender).Name == "btRight") Direction = "right";
            if (((Button)sender).Name == "btLeft") Direction = "left";
            switch (Direction)
            {
                case "up": 
                    oShapes[Id].Move(new Point(oShapes[Id].Centre.X, oShapes[Id].Centre.Y - 5));
                    break;
                case "down": 
                    oShapes[Id].Move(new Point(oShapes[Id].Centre.X, oShapes[Id].Centre.Y + 5));
                    break;
                case "right":
                    oShapes[Id].Move(new Point(oShapes[Id].Centre.X + 5, oShapes[Id].Centre.Y));
                    break;
                case "left":
                    oShapes[Id].Move(new Point(oShapes[Id].Centre.X - 5, oShapes[Id].Centre.Y));
                    break;
            }
            this.OnPaint(new PaintEventArgs(this.CreateGraphics(), this.ClientRectangle));
        }

        

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            var gr = this.CreateGraphics();
            gr.Clear(Color.FromKnownColor(KnownColor.Control));
            foreach (oShape s in oShapes)
            {   
                s.Draw(gr);
            }
        }
    }
}
