using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4
{
    internal class ByExtensions : IEnumerable<string>
    {
        private readonly IDictionary<string, List<FileData>> filesByExtension = new Dictionary<string, List<FileData>>();

        public ByExtensions(List<FileData> fData)
        {

            foreach (var file in fData)
            {
                if (filesByExtension.ContainsKey(file.Extension))
                {
                    filesByExtension[file.Extension].Add(file);
                }
                else
                {
                    filesByExtension.Add(file.Extension, new List<FileData> { file });
                }
            }
        }

        public List<string> CategoryInfo(List<FileData> fData)
        {
            List<string> outputList = new List<string>();
            int auxCount = 0;
            long auxTotSize = 0;
            long auxAvgSize = 0;
            long auxMaxSize = 0;
            long auxMinSize = 0;

            foreach (var file in fData)
            {
                auxCount++;
                auxTotSize += file.SizeBytes;
                auxAvgSize = auxTotSize / auxCount;
            }
            auxMaxSize = fData.Max(x => x.SizeBytes);
            auxMinSize = fData.Min(x => x.SizeBytes);

            outputList.Add($"{auxCount}");
            outputList.Add($"{Tools.ConvertSize(auxTotSize)}");
            outputList.Add($"{Tools.ConvertSize(auxAvgSize)}");
            outputList.Add($"{Tools.ConvertSize(auxMinSize)}");
            outputList.Add($"{Tools.ConvertSize(auxMaxSize)}");

            return outputList;
        }

        public IEnumerator<string> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public void Print()
        {
            Console.WriteLine("   By extensions:");
            Console.WriteLine("\t\t[count]\t\t[total size]\t[avg size]\t[min size]\t[max size]");
            foreach (var extension in filesByExtension)
            {
                List<string> text = CategoryInfo(extension.Value);
                Console.Write(extension.Key + ":   \t");
                foreach (var item in text)
                {
                    Console.Write(item + "\t\t");
                }
                Console.Write("\n");
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
