using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4
{
    public class DirectoryData
    {
        public string Name { get; }
        public string Path { get; }
        public double Size { get; }

        public DirectoryData(string subdirectory, long subDirSize)
        {
            Path = subdirectory;
            Size = subDirSize;
        }
    }
}
