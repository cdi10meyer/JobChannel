using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    [DataContract]
    public class Contrat : Consultation
    {
        #region "Constructeurs"
        public Contrat(string nom)
        {
            Id = 0;
            Nom = nom;
        }
        public Contrat() : this(String.Empty)
        {

        }
        public Contrat(Consultation consultation)
        {
            Id = consultation.Id;
            Nom = consultation.Nom;
        }
        #endregion "Constructeurs"
    }
}
