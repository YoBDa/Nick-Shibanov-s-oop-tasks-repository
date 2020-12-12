using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.NetworkInformation;
using System.Threading;

namespace Server
{
    public partial class Form1 : Form
    {
        object _lock = new object();
        string DATA = "";
        public Form1()
        {
            InitializeComponent();
            cbServerIP.Items.AddRange(ListNetworkAdapters().ToArray());
            timer1.Interval = 100;
            timer1.Start();
            timer1.Tick += Timer1_Tick;
            btStop.Enabled = false;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lock (_lock) _Console.Text = DATA;
        }

       
        private void tbServerPort_TextChanged(object sender, EventArgs e)
        {

        }
        List<IPAddress> ListNetworkAdapters() // Return list of IPs of system network adapters
        {
            List<IPAddress> IPs = new List<IPAddress>();
            foreach (NetworkInterface ni in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (ni.OperationalStatus == OperationalStatus.Up && ni.NetworkInterfaceType != NetworkInterfaceType.Loopback)
                {
                    foreach(var ip in ni.GetIPProperties().UnicastAddresses)
                    {
                        IPs.Add(ip.Address);
                    }
                }
            }
            return IPs;
        }

        private void btRefreshIPs_Click(object sender, EventArgs e)
        {
            cbServerIP.Items.Clear();
            cbServerIP.Items.AddRange(ListNetworkAdapters().ToArray());
        }
        private Server server;
        static Thread listenThread; 
        private void btStart_Click(object sender, EventArgs e)
        {
            tbServerPort.Enabled = false;
            btStart.Enabled = false;
            btStop.Enabled = true;
            
            IPAddress IP;
            if (!IPAddress.TryParse(cbServerIP.SelectedItem.ToString(), out IP)) return;
            int Port = 59321;
            try
            {
                Port = int.Parse(tbServerPort.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot recognize port. Try again. " + ex.Message);
                return;
            }
            try
            {
                server = new Server(IP, Port);
                server.onEventHappened += Server_onEventHappened1;
                server.onDisconnect += Server_onDisconnect;
                listenThread = new Thread(new ThreadStart(server.Listen));
                listenThread.Start(); 
            }
            catch (Exception ex)
            {
                server.Disconnect();
                Console.WriteLine(ex.Message);
            }
            lbServerStatus.Text = "On";
            lbServerIP.Text = IP.ToString();
            lbServerPort.Text = Port.ToString();
        }

        private void Server_onDisconnect()
        {
            lbServerStatus.Text = "Off";
            lbServerIP.Text = "XXX.XXX.XXX.XXX";
            lbServerPort.Text = "XXXX";
        }

        private void Server_onEventHappened1(string data)
        {
            lock (_lock) DATA += DateTime.Now.ToShortTimeString()+" "+ data + "\n";
        }

   
        private void btStop_Click(object sender, EventArgs e)
        {
            tbServerPort.Enabled = true;
            btStart.Enabled = true;
            btStop.Enabled = false;

            server.Disconnect();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            server.Disconnect();
        }
    }
}