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
using System.IO;


namespace Graphics_Task1
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            string[] objects = { "Rectangle", "Circle", "Carriage" };
            string[] carriages = { "Coal", "Sand", "Wood", "Train" };
            cbShapes.Items.AddRange(objects);
            cbCarriages.Items.AddRange(carriages);
            cbShapes.SelectedIndex = 0;
            cbCarriages.SelectedIndex = 0;
            nudCartsCount.Visible = false;
            cbCarriages.Visible = false;
        }

        private oContainer oShapes = new oContainer();
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Random rnd = new Random((int)DateTime.Now.Ticks);
            int Size = rnd.Next(70, 200);
            Color clr = Color.FromArgb(rnd.Next(0, 256), rnd.Next(0, 256), rnd.Next(0, 256));
            oShape s;
            Graphics gr = this.CreateGraphics();
            string choice = "";
            if (cbShapes.SelectedIndex == 2)
            {
                choice = cbCarriages.Text;
            }
            else choice = cbShapes.Text;
            switch (choice)
            {
                default: s = new oRectangle(new Point(e.X, e.Y), new Point(Size, Size / 2),clr);
                    s.Draw(gr);
                    oShapes.Add(s,typeof(oRectangle));
                    break;
                case "Circle":
                    s = new oCircle(new Point(e.X, e.Y), Size, clr);
                    s.Draw(gr);
                    oShapes.Add(s, typeof(oCircle));
                    break;
                case "Coal":
                    s = new oCart.Coal(new Point(e.X, e.Y), Size);
                    s.Draw(gr);
                    oShapes.Add(s, typeof(oCart.Coal));
                    break;
                case "Sand":
                    s = new oCart.Sand(new Point(e.X, e.Y), Size);
                    s.Draw(gr);
                    oShapes.Add(s, typeof(oCart.Sand));
                    break;
                case "Wood":
                    s = new oCart.Wood(new Point(e.X, e.Y), Size);
                    oShapes.Add(s, typeof(oCart.Wood));
                    break;
                case "Train":
                    oBaseCart[] carts = new oBaseCart[(int)nudCartsCount.Value];
                    for (int i = 0; i < nudCartsCount.Value; i++)
                    {
                        switch (rnd.Next(0, 3))
                        {
                            case 0:
                                carts[i] = new oCart.Coal(Point.Empty, Size);
                                break;
                            case 1:
                                carts[i] = new oCart.Sand(Point.Empty, Size);
                                break;
                            case 2:
                                carts[i] = new oCart.Wood(Point.Empty, Size);
                                break;

                        }
                    }
                    s = new oTrain(carts, new Point(e.X, e.Y));
                    oShapes.Add(s, typeof(oTrain));
                    s.Draw(gr);
                    break;
            }            
            listBox1.Items.Add(listBox1.Items.Count + " " + s.GetType().ToString());

            this.OnPaint(new PaintEventArgs(this.CreateGraphics(), this.ClientRectangle));

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
                    oShapes[Id].Key.Move(new Point(oShapes[Id].Key.Centre.X, oShapes[Id].Key.Centre.Y - 5));
                    break;
                case "down": 
                    oShapes[Id].Key.Move(new Point(oShapes[Id].Key.Centre.X, oShapes[Id].Key.Centre.Y + 5));
                    break;
                case "right":
                    oShapes[Id].Key.Move(new Point(oShapes[Id].Key.Centre.X + 5, oShapes[Id].Key.Centre.Y));
                    break;
                case "left":
                    oShapes[Id].Key.Move(new Point(oShapes[Id].Key.Centre.X - 5, oShapes[Id].Key.Centre.Y));
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

        private void cbShapes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbShapes.SelectedIndex == 2) cbCarriages.Visible = true;
            else cbCarriages.Visible = false;
        }

        private void cbCarriages_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCarriages.SelectedIndex == 3) nudCartsCount.Visible = true;
            else nudCartsCount.Visible = false;
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "*.json|json";
                sfd.FileName = listBox1.SelectedItem.ToString();
                sfd.ShowDialog();
                using (Stream stream = sfd.OpenFile())
                {
                    //string json = oShapes[listBox1.SelectedIndex].Key.JsonSerialize(oShapes[listBox1.SelectedIndex].Value);
                    //byte[] data = Encoding.UTF8.GetBytes(json);
                  //  stream.Write(data, 0, data.Length);
                }

            }
        }
    }
}
