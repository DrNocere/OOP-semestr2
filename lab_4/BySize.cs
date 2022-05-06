using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4
{
    internal class BySize : IEnumerable<string>
    {
        private readonly IDictionary<string, List<FileData>> filesBySize = new Dictionary<string, List<FileData>>();

        public BySize(List<FileData> fData)
        {
            string keyA = "      . <= 1KB";
            string keyB = "1KB < . <= 1MB";
            string keyC = "1MB < . <= 1GB";
            string keyD = "1GB < .       ";
            List<FileData> catA = new List<FileData>();
            List<FileData> catB = new List<FileData>();
            List<FileData> catC = new List<FileData>();
            List<FileData> catD = new List<FileData>();

            foreach (var file in fData)
            {
                if (file.SizeBytes <= 1024)
                {
                    catA.Add(file);
                }
                if (file.SizeBytes > 1024 && file.SizeBytes <= 1048576)
                {
                    catB.Add(file);
                }
                if (file.SizeBytes > 1048576 && file.SizeBytes <= 1073741824)
                {
                    catC.Add(file);
                }
                if (file.SizeBytes > 1073741824)
                {
                    catD.Add(file);
                }
            }

            if (catA.Count > 0) filesBySize.Add(keyA, catA);
            if (catB.Count > 0) filesBySize.Add(keyB, catB);
            if (catC.Count > 0) filesBySize.Add(keyC, catC);
            if (catD.Count > 0) filesBySize.Add(keyD, catD);
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
            Console.WriteLine("   By size:");
            Console.WriteLine("\t\t[count]\t\t[total size]\t[avg size]\t[min size]\t[max size]");
            foreach (var sizeCat in filesBySize)
            {
                List<string> text = CategoryInfo(sizeCat.Value);
                Console.Write(sizeCat.Key + ":\t");
                foreach (var item in text)
                {
                    Console.Write(item + "\t\t");
                }
                Console.Write("\n");
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}