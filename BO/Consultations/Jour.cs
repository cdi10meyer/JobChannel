using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    [DataContract]
    public class Jour : Consultation
    {
        #region "Constructeurs"

        public Jour(int id, string nom)
        {
            Id = id;
            Nom = $"{id} {nom}";
        }
        public Jour(string nom)
        {
            Id = 0;
            Nom = nom;
        }
        public Jour() : this(String.Empty)
        {

        }
        public Jour(Consultation consultation)
        {
            Id = consultation.Id;
            Nom = consultation.Nom;
        }

        #endregion "Constructeurs"
    }
}
