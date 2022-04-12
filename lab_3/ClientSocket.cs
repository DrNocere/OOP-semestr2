using System.Net;
using System.Net.Sockets;


namespace lab_3
{
    public class ClientSocket : IDisposable
    {
        private bool disposed;

        private Socket socket;

        public ClientSocket(string host, int port)
        {
            IPHostEntry entry = Dns.GetHostEntry(host);

            this.socket = new Socket(SocketType.Stream, ProtocolType.Tcp);

            try
            {
                this.socket.Connect(entry.AddressList, port);
            }
            catch (SocketException ex)
            {
                this.socket.Dispose();

                throw ex;
            }
        }
    }
}