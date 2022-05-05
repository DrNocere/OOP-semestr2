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
        public IDictionary<string, List<string>> sizesByType = new Dictionary<string, List<string>>();
        private readonly IDictionary<string, List<FileData>> filesByType = new Dictionary<string, List<FileData>>();

        public ByType(List<FileData> fData)
        {

            foreach (var label in fData)
            {
                if (filesByType.ContainsKey(label.Label))
                {
                    filesByType[label.Label].Add(label);
                }
                else
                {
                    filesByType.Add(label.Label, new List<FileData> { label });
                }
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
