using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_3
{
    public class FileLogger : WriterLogger
    {
        private bool disposed;
        protected FileStream stream;

        public FileLogger(string path)
        {
            FileStream stream = new FileStream(path, FileMode.Append);
            writer = new StreamWriter(stream, Encoding.UTF8);
        }

        ~FileLogger()
        {
            this.Dispose(false);
        }

        protected virtual void Dispose(bool status)
        {

            if (!this.disposed)
            {
                if (status)
                    this.stream.Dispose();

                this.disposed = true;
            }
        }

        public override void Dispose() 
        {
            this.Dispose(status: true);
        }
    }
}