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
        public string NomRegion { get { return MySelection.MyRegion.NomRegion; } }
        public string TypePoste { get { return MySelection.MyPoste.TypePoste; } }
        public string TypeContrat { get { return MySelection.MyContrat.TypeContrat; } }
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
            MySociete = new Societe();
            MySelection = new Selection();
        }

        #endregion "Constructeurs"


        #region "Méthodes propres à la classe"

        #endregion "Méthodes propres à la classe"


    }
}
