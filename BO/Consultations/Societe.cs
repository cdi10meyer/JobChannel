using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    [DataContract]
    public class Societe : Consultation
    {
        #region "Constructeurs"
        public Societe(string nom)
        {
            Id = 0;
            Nom = nom;
        }
        public Societe() : this(String.Empty)
        {

        }
        public Societe(Consultation consultation)
        {
            Id = consultation.Id;
            Nom = consultation.Nom;
        }
        #endregion "Constructeurs"
        public override string ToString()
        {
            return Nom.ToUpper();
        }
    }
}
