using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4
{
    internal class OByName : IEnumerable<string>
    {
        private readonly IDictionary<string, FileData> orderedByName = new SortedDictionary<string, FileData>();

        public OByName(List<FileData> fData)
        {
            foreach (var file in fData)
            {
                if (!orderedByName.ContainsKey(file.Name))
                {
                    orderedByName.Add(file.Name, file);
                }
            }
        }

        public IEnumerator<string> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public void Print()
        {
            Console.WriteLine("   Ordered by name:");
            Console.WriteLine("\t\t[size]\t\t[path]");
            foreach (var file in orderedByName)
            {
                Console.Write(file.Value.Name + ": \t" + file.Value.Size + "\t\t" + file.Value.Path + "\n");
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
