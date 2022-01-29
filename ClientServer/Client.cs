using System;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;

namespace ClientServer
{
    public class Client
    {
        public static IPAddress CurrentHostIp => Dns.GetHostByName(Dns.GetHostName()).AddressList[0];

        public bool IsConnected 
        {
            get
            {
                if (client == null)
                    return false;

                return client.Connected;
            }
        }

        public String Nickname { get; set; }
        
        private IPAddress IpAddress;
        private int RemotePort;
        private TcpClient client = new TcpClient();

        public Client(IPAddress ipAddress, int remotePort)
        {
            IpAddress = ipAddress;
            RemotePort = remotePort;
        }

        public Client(String ipAddress, int remotePort)
        {
            IpAddress = IPAddress.Parse(ipAddress);
            RemotePort = remotePort;
        }

        public void Connect()
        {
            if (client == null)
                client = new TcpClient();

            if (client.Connected)
                return;

            client.Connect(new IPEndPoint(IpAddress, RemotePort));
        }

        public void Disconnect()
        {
            if (client == null)
                return;

            try { Send(new Request(RequestType.Disconnecting, Nickname, "I want to disconnect from server")); }
            catch { }

            System.Threading.Thread.Sleep(250);
            client.Close();
            client = null;
        }

        public void Send(Request request)
        {
            if (client == null)
                return;

            new BinaryFormatter().Serialize(client.GetStream(), request);
        }

        public Response Receive()
        {
            try { return new BinaryFormatter().Deserialize(client.GetStream()) as Response; }
            catch { return null; }
        }
    }
}
