using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercício2_Entities.Entities
{
    public class Comment
    {
        public string text { get; set; }

        public Comment()
        {
        }
        public Comment(string text)
        {
            this.text = text;
        }   
    }
}
