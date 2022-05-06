using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4
{
    internal class CByLetters : IEnumerable<string>
    {
        private readonly IDictionary<string, List<FileData>> countByLetters = new SortedDictionary<string, List<FileData>>();
        

        public CByLetters(List<FileData> fData)
        {
            foreach (var file in fData)
            {
                if (countByLetters.ContainsKey(file.Name.Substring(0,1).ToUpper()))
                {
                    countByLetters[file.Name.Substring(0, 1).ToUpper()].Add(file);
                }
                else
                {
                    countByLetters.Add(file.Name.Substring(0, 1).ToUpper(), new List<FileData> { file });
                }
            }
        }

        public void Print()
        {
            Console.WriteLine("   Counts by first letter:");
            Console.Write("\t");
            foreach (var letter in countByLetters)
            {
                Console.Write(letter.Key + "\t");
            }
            Console.Write("\n");
            Console.Write("\t");
            foreach (var count in countByLetters)
            {
                Console.Write(count.Value.Count + "\t");
            }
            Console.Write("\n");
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
