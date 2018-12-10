using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Offre
    {
        #region "Propriétés d'instance"

        public int IdOffre { get; set; }

        public string Description { get; set; }

        public string LienAnnonce { get; set; }

        public DateTime DatePublication { get; set; }

        public Societe MySociete { get; set; }

        public Selection MySelection { get; set; }

        #endregion "Propriétés d'instance"

        #region "Constructeurs"
        public Offre()
        {

        }

        #endregion "Constructeurs"


        #region "Méthodes propres à la classe"

        #endregion "Méthodes propres à la classe"
    }
}
