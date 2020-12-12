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
using System.Net.Sockets;
using System.Threading;

namespace Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            timer1.Interval = 100;
            timer1.Start();
            timer1.Tick += Timer1_Tick;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lock (_lock) tbChat.Text = DATA;
        }

        Client client;
        string DATA = "";
        
        object _lock = new object();
        private void btConnect_Click(object sender, EventArgs e)
        {
            IPAddress IP;
            int Port;
            string Username = tbUsername.Text;
            if (Username.Length == 0) return;
            if (!IPAddress.TryParse(tbServerIP.Text, out IP)) return;
            if (!int.TryParse(tbServerPort.Text, out Port)) return;
            client = new Client(Username,IP, Port);
            client.onEventHappened += Client_onEventHappened;
            
            lbServerIP.Text = IP.ToString();
            lbServerPort.Text = Port.ToString();
            lbStatus.Text = "Online";
        }

        private void Client_onEventHappened(string data)
        {
           lock (_lock) DATA += data + "\n";
        }

        private void btDisconnect_Click(object sender, EventArgs e)
        {
           
            client.Disconnect();
            lbServerIP.Text = "XXX.XXX.XXX.XXX";
            lbServerPort.Text = "XXXX";
            lbStatus.Text = "Offline";
        }

        private void btChatSend_Click(object sender, EventArgs e)
        {
            if (tbWritingArea.Text.Length == 0) return;
            client.SendMessage(tbWritingArea.Text);
            DATA += "You: " + tbWritingArea.Text + "\n";
            tbWritingArea.Clear();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            client.Disconnect();
            Application.Exit();
        }
    }
}
