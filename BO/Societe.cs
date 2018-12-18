using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Societe : IComparable<Societe>
    {
        #region "Propriétés d'instance"
        public int IdSociete { get; set; }

        public string NomSociete { get; set; }

        #endregion "Propriétés d'instance"

        #region "Constructeurs"
        public Societe()
        {
        }
        #endregion "Constructeurs"

        #region "Méthodes propres à la classe"

        #endregion "Méthodes propres à la classe"

        public override string ToString()
        {
            return NomSociete.ToUpper();
        }

        public int CompareTo(Societe other)
        {
            return this.NomSociete.CompareTo(other.NomSociete);
        }
    }
}
