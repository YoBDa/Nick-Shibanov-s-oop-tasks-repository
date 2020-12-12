using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net;
using System.Net.Sockets;

namespace Client
{
    class Client
    {
        private bool online = false;
        private string userName;
        private TcpClient client;
        object _lock = new object();
        public string host { get; private set; }
        public int port { get; private set; }
        private NetworkStream stream;
        public delegate void eventHappened(string data);
        public event eventHappened onEventHappened;
        public Client(string username, IPAddress IP, int Port)
        {
            userName = username;
            client = new TcpClient();
            try
            {
                client.Connect(IP.ToString(), Port); 
                stream = client.GetStream(); 
                string message = userName;
                online = true;
                //byte[] data = Encoding.Unicode.GetBytes(message);
                //stream.Write(data, 0, data.Length);
                Thread receiveThread = new Thread(new ThreadStart(ReceiveMessage));
                receiveThread.Start();
                SendMessage(message);
            }
            catch (Exception ex)
            {
                onEventHappened?.Invoke(ex.Message);
            }
            finally
            {
                //onEventHappened?.Invoke("Disconnected There");
                //Disconnect();
            }
        }
        public void SendMessage(string text)
        {
          
            byte[] data = Encoding.Unicode.GetBytes(text);
            stream.Write(data, 0, data.Length);
     
        }

        private void ReceiveMessage()
        {

            while (online)
            {

                try
                {
                    byte[] data = new byte[64];
                    StringBuilder builder = new StringBuilder();
                    int bytes = 0;
                    do
                    {
                        bytes = stream.Read(data, 0, data.Length);
                        builder.Append(Encoding.Unicode.GetString(data, 0, bytes));
                    }
                    while (stream.DataAvailable);

                    string message = builder.ToString();
                    onEventHappened?.Invoke(message);
                }
                catch (ObjectDisposedException)
                {
                }
                catch (System.IO.IOException) { }
                catch (Exception exx)
                {

                    onEventHappened?.Invoke("Error occured: " + exx.Message);
                    Disconnect();

                }

            }
        }

        public void Disconnect()
        {
            online = false;
           
            if (stream != null)
                stream.Close();
            if (client != null)
                client.Close();
      
            onEventHappened?.Invoke("Disconnected.");
        }
    }
}
