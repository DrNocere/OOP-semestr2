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

        public virtual void Log(params string[] messages)
        {
            DateTime dateTime = DateTime.Now;
            string time = dateTime.ToString("yyyy-MM-ddTHH:mm:sszzz");

            foreach (string message in messages)
            {
                string requestText = time + message + " ";
                byte[] requestBytes = Encoding.UTF8.GetBytes(requestText);

                clientSocket.Send(requestBytes);
            }
        }

        public void Dispose(bool dispose)
        { 
            if (dispose) this.clientSocket.Dispose();
        }

        public void Dispose()
        {
            this.Dispose(dispose: true);

            GC.SuppressFinalize(this);
        }
    }
}