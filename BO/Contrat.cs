using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Contrat : IComparable<Contrat>
    {
        #region "Propriétés d'instance"
        public int IdContrat { get; set; }

        public string TypeContrat { get; set; }

        #endregion "Propriétés d'instance"

        #region "Constructeurs"
        public Contrat()
        {
            IdContrat = 0;
            TypeContrat = "Tous";
        }

        #endregion "Constructeurs"

        #region "Méthodes propres à la classe"

        #endregion "Méthodes propres à la classe"

        public override string ToString()
        {
            return TypeContrat;
        }

        public int CompareTo(Contrat other)
        {
            return this.TypeContrat.CompareTo(other.TypeContrat);
        }
    }
}
