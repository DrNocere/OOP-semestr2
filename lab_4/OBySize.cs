using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4
{
    internal class OBySize : IEnumerable<string>
    {
        private readonly IDictionary<CompositeKey, FileData> orderedBySize = new SortedDictionary<CompositeKey, FileData>();

        public OBySize(List<FileData> fData)
        {
            foreach (var file in fData)
            {
                CompositeKey key = new CompositeKey(file.SizeBytes, file.Name);
                if (!orderedBySize.ContainsKey(key))
                {
                    orderedBySize.Add(key, file);
                }
            }
        }

        public IEnumerator<string> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public void Print()
        {
            Console.WriteLine("   Ordered by size:");
            Console.WriteLine("\t\t[size]\t\t[path]");
            foreach (var file in orderedBySize)
            {
                Console.Write(file.Value.Name + ": \t" + file.Value.Size + "\t\t" + file.Value.Path + "\n");
            }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
