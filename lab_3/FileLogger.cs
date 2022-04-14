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
            using (FileStream stream = new FileStream(path, FileMode.Append))
            {
                using (TextWriter writer = new StreamWriter(stream, Encoding.UTF8))
                {
                    
                }
            }
        }

        ~FileLogger()
        {
            this.Dispose(false);
        }

        public override void Dispose() 
        {
            this.disposed = true;
        }
    }
}
