using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    [DataContract]
    public class Offre : IComparable<Offre>
    {
        #region "Propriétés d'instance"
        [DataMember]
        public string Publication { get { return DatePublication.ToShortDateString(); } private set { } }
        [DataMember]
        public string NomSociete { get { return MySelection.MySociete.NomSociete; } private set { } }
        [DataMember]
        public string NomRegion { get { return MySelection.MyRegion.NomRegion; } private set { } }
        [DataMember]
        public string TypePoste { get { return MySelection.MyPoste.TypePoste; } private set { } }
        [DataMember]
        public string TypeContrat { get { return MySelection.MyContrat.TypeContrat; } private set { } }
        [DataMember]
        public int IdOffre { get; set; }
        [DataMember]
        public string Description { get; set; }
        [DataMember]
        public string LienAnnonce { get; set; }
        [DataMember]
        public DateTime DatePublication { get; set; }
        [DataMember]
        public Selection MySelection { get; set; }

        #endregion "Propriétés d'instance"

        #region "Constructeurs"
        public Offre()
        {
            MySelection = new Selection();
        }

        public int CompareTo(Offre other)
        {
            int date = this.Publication.CompareTo(other.Publication) *-1;
            int selection = this.MySelection.CompareTo(other.MySelection);
            int resultat = (date != 0) ? date : selection;
            
            return resultat;
        }

        #endregion "Constructeurs"



    }
}
