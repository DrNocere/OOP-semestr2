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
        public long Size { get; }
        public string Extension { get; }
        public string Type { get; }

        public FileData(string Name, string FullName, string Extension, long Length)
        {
            this.Name = Name;
            Path = FullName;
            this.Extension = Extension;
            Size = Length;
        }
    }
}
