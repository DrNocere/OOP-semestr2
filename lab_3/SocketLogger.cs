using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3
{
    internal class SocketLogger : ILogger
    {
        private ClientSocket clientSocket;
        public SocketLogger(string host, int port) 
        {
            clientSocket = new ClientSocket(host, port);    
        }

        ~SocketLogger() 
        {
            this.Dispose(false);
        }

        public void Log(params string[] messages)
        {

        }

        public void Dispose(bool status)
        { 
            if (status) this.clientSocket.Dispose();
        }

        public void Dispose()
        {
            this.Dispose(status: true);
        }
    }
}