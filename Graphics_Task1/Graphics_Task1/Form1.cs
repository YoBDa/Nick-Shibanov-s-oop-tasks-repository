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
        oTrain Train;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            int Size = 150;
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
                Train = new oTrain(carts, new Point(e.X, e.Y));
                Train.Draw(gr);
            }

            
            
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void btLeft_Click(object sender, EventArgs e)
        {
            double startAccel = 0.1;//m/s^2
            int V = 0;
            int i = 0;
            Graphics gr = this.CreateGraphics();
            while (V > -10)
            {
                int preV = V;
                int preX = Train.Centre.X;
                int nextX = (int)(preX + (preV * i / 1000.0) - (startAccel * Math.Pow(i / 1000.0, 2) / 2.0));
                V = (int)(preV - startAccel * i / 1000.0);
                Train.Centre = new Point(nextX, Train.Centre.Y);
                gr.Clear(Color.White);
                Train.Draw(gr);
                gr.DrawString(label1.Text, SystemFonts.DefaultFont, Brushes.Black, new Point(10, 30));
                i += 100;
                Thread.Sleep(100);
                
                label1.Text = $"V = {V};  X = {Train.Centre.X}";
            }
            while (V < 0) 
            {
                int preV = V;
                int preX = Train.Centre.X;
                int nextX = (int)(preX + (preV * i / 1000.0) + (startAccel * Math.Pow(i / 1000.0, 2) / 2.0));
                V = (int)(preV + startAccel * i / 1000.0);
                Train.Centre = new Point(nextX, Train.Centre.Y);
                gr.Clear(Color.White);
                Train.Draw(gr);
                gr.DrawString(label1.Text, SystemFonts.DefaultFont, Brushes.Black, new Point(10, 30));
                i += 100;
                Thread.Sleep(100);
                label1.Text = $"V = {V};  X = {Train.Centre.X}";

            }         
            
        }

        private void btRight_Click(object sender, EventArgs e)
        {

            Train.Centre = new Point(Train.Centre.X + 5, Train.Centre.Y);
            Graphics gr = this.CreateGraphics();
            gr.Clear(Color.White);
            Train.Draw(gr);

        }
    }
}
