using System;

namespace lab_3
{
    public abstract class WriterLogger : ILogger
    {
        protected TextWriter writer;

        public virtual void Log(params string[] messages)
        {
            DateTime dateTime = DateTime.Now;
            string time = dateTime.ToString("yyyy-MM-ddTHH:mm:sszzz");

            writer.Write(time + " ");
            foreach (string message in messages)
            {
                writer.Write(message + " ");
            }
            writer.Write("\n");
            writer.Flush(); //Clears buffers for this stream and causes any buffered data to be written to the file.
        }

        public abstract void Dispose();
    }
}