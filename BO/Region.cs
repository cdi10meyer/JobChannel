using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Region
    {
        #region "Propriétés d'instance"
        public int IdRegion { get; set; }

        public string NomRegion { get; set; }

        #endregion "Propriétés d'instance"

        #region "Constructeurs"
        public Region()
        {
            IdRegion = 0;
            NomRegion = "Toutes";
        }

        #endregion "Constructeurs"

        #region "Méthodes propres à la classe"

        #endregion "Méthodes propres à la classe"

        public override string ToString()
        {
            return NomRegion;
        }
    }
}
