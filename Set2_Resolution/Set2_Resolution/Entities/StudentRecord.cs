using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set2_Resolution.Entities
{
    public class StudentRecord
    {
        public int Id { get; set; }

        //public StudentRecord(int id)
        //{
        //    Id = id;
        //}

        //aqui vai verificar o hashcode do elemento, se forem valores iguais gera o mesmo hashcode
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        //finalmente, pra ter certeza usa o equals
        public override bool Equals(object? obj)
        {
            if (!(obj is StudentRecord))
            {
                return false;
            }
            StudentRecord other = obj as StudentRecord;
            return Id.Equals(other.Id);
        }
    }
}
