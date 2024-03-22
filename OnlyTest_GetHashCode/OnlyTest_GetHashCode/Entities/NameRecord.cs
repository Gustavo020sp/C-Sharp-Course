using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlyTest_GetHashCode.Entities
{
    public class NameRecord
    {
        public string name { get; set; }

        public override int GetHashCode()
        {
            return name.GetHashCode();
        }

        public override bool Equals(object? obj)
        {
            if (!(obj is NameRecord))
            {
                return false;
            }
            NameRecord other = obj as NameRecord;
            return name.Equals(other.name);
        }
    }
}
