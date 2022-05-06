using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_4
{
    internal class CompositeKey : IComparable<CompositeKey>
    {
        public long KeyX { get; set; }
        public string KeyY { get; set; }
        public CompositeKey(long keyX, string keyY)
        {
            KeyX = keyX;
            KeyY = keyY;
        }

        public int CompareTo(CompositeKey? other)
        {
            int compared = 0;
            compared = KeyX.CompareTo(other.KeyX);
            if(compared == 0) compared = KeyY.CompareTo(other.KeyY);
            return compared;
        }
    }
}
