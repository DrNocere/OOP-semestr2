using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4
{
    internal class ByType : IEnumerable<string>
    {
        private readonly IDictionary<string, List<FileData>> filesByType = new Dictionary<string, List<FileData>>();

        public ByType(List<FileData> fData)
        {

            foreach (var file in fData)
            {
                if (filesByType.ContainsKey(file.Type))
                {
                    filesByType[file.Type].Add(file);
                }
                else
                {
                    filesByType.Add(file.Type, new List<FileData> { file });
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

        public void Print()
        {
            Console.WriteLine("   By types:");
            Console.WriteLine("\t\t[count]\t\t[total size]\t[avg size]\t[min size]\t[max size]");
            foreach (var type in filesByType)
            {
                List<string> text = CategoryInfo(type.Value);
                Console.Write(type.Key + ":   \t");
                foreach (var item in text)
                {
                    Console.Write(item + "\t\t");
                }
                Console.Write("\n");
            }
        }

        public IEnumerator<string> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
