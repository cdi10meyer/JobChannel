using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    [DataContract]
    public class Consultation : IComparable<Consultation>
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Nom { get; set; }

        //public Consultation(string nom)
        //{
        //    Id = 0;
        //    Nom = nom;
        //}
        //public Consultation() : this(String.Empty)
        //{

        //}
        //public Consultation(Consultation consultation)
        //{
        //    Id = consultation.Id;
        //    Nom = consultation.Nom;
        //}

        public int CompareTo(Consultation other)
        {
            return this.Nom.CompareTo(other.Nom);
        }
        public override string ToString()
        {
            return Nom;
        }

    }
}
