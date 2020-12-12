using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Net;
using System.Net.Sockets;


namespace Server
{
    public class Server
    {
        static TcpListener tcpListener; 
        List<Client> clients = new List<Client>();
        public IPAddress IP { get; private set; }
        public int Port { get; private set; }
        public delegate void Disconnected();
        public event Disconnected onDisconnect;
        public delegate void eventHappened(string data);
        public event eventHappened onEventHappened;
       
        
        public Server(IPAddress IP, int Port)
        {
            this.IP = IP;
            this.Port = Port;
        }
        public void AddConnection(Client client)
        {
            clients.Add(client);
        }
        public void RemoveConnection(string id)
        {
            
            Client client = clients.FirstOrDefault(c => c.Id == id);
            if (client != null)
                clients.Remove(client);
        }
  
        public void Listen()
        {
            try
            {
                tcpListener = new TcpListener(IP, Port);
                tcpListener.Start();
                onEventHappened?.Invoke("Server is now running. Waiting for connections...");

                while (true)
                {
                    TcpClient tcpClient = tcpListener.AcceptTcpClient();

                    Client client = new Client(tcpClient, this);
                    client.onEventHappened += Client_onEventHappened;
                    Thread clientThread = new Thread(new ThreadStart(client.Process));
                    clientThread.Start();
                }
            }
            catch (Exception ex)
            {
                onEventHappened?.Invoke(ex.Message);
                Disconnect();
            }
        }

        private void Client_onEventHappened(string data)
        {
            onEventHappened?.Invoke(data);
        }

        public void BroadcastMessage(string message, string id)
        {
            byte[] data = Encoding.Unicode.GetBytes(message);
            for (int i = 0; i < clients.Count; i++)
            {
                if (clients[i].Id != id) 
                {
                    clients[i].Stream.Write(data, 0, data.Length); 
                }
            }
        }
       
        public void Disconnect()
        {
            tcpListener.Stop();
            onEventHappened?.Invoke("Disconnecting clients...");
            for (int i = 0; i < clients.Count; i++)
            {
                clients[i].Close(); 
            }
            onEventHappened?.Invoke("Server stopped.");
            onDisconnect?.Invoke();
        }
    }
}
