using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    [DataContract]
    public class Societe : IComparable<Societe>
    {
        #region "Propriétés d'instance"
        [DataMember]
        public int IdSociete { get; set; }
        [DataMember]
        public string NomSociete { get; set; }

        #endregion "Propriétés d'instance"

        #region "Constructeurs"
        public Societe()
        {
            IdSociete = 0;
            NomSociete = "Toutes";
        }
        #endregion "Constructeurs"

        #region "Méthodes propres à la classe"

        #endregion "Méthodes propres à la classe"

        public override string ToString()
        {
            return NomSociete;
        }

        public int CompareTo(Societe other)
        {
            return this.NomSociete.CompareTo(other.NomSociete);
        }
    }
}
