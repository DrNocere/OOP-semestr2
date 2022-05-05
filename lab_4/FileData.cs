using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4
{
    public class FileData
    {
        public string Name { get; }
        public string Path { get; }
        public string Size { get; }
        public long SizeBytes { get; }
        public string Extension { get; }
        public string Type { get; }

        public FileData(string Name, string FullName, string Extension, long Length)
        {
            this.Name = Name;
            Path = FullName;
            this.Extension = Extension;
            SizeBytes = Length;
            Size = Tools.ConvertSize(Length);
            Type = Tools.AssignType(Extension);
        }
    }
}