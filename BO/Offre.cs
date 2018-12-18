using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Offre : IComparable<Offre>
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

        public int CompareTo(Offre other)
        {
            int date = this.DatePublication.Date.CompareTo(other.DatePublication.Date);
            int societe = this.MySociete.CompareTo(other.MySociete);
            int selection = this.MySelection.CompareTo(other.MySelection);
            int resultat = (date != 0) ? date : (societe != 0) ? societe : selection;
            
            return resultat;
        }

        #endregion "Constructeurs"



    }
}
