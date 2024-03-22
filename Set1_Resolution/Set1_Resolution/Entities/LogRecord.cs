using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set1_Resolution.Entities
{
    public class LogRecord
    {
        public string userName {  get; set; }
        public DateTime instant { get; set; }

        public override int GetHashCode()
        {
            return userName.GetHashCode();
        }

        //Verify if Log Record can be the same as other object incoming
        public override bool Equals(object? obj)
        {
            if(!(obj is LogRecord))
            {
                return false;
            }
            LogRecord other = obj as LogRecord;
            return userName.Equals(other.userName);
        }
    }
}
