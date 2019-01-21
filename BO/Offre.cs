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
        public string NomSociete { get { return MySelection.MySociete.Nom.ToUpper(); } private set { } }
        [DataMember]
        public string NomRegion { get { return MySelection.MyRegion.Nom; } private set { } }
        [DataMember]
        public string TypePoste { get { return MySelection.MyPoste.Nom; } private set { } }
        [DataMember]
        public string TypeContrat { get { return MySelection.MyContrat.Nom; } private set { } }
        [DataMember]
        public int Id { get; set; }
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

        public Offre(Offre offre)
        {
            Id = offre.Id;
            Description = offre.Description;
            LienAnnonce = offre.LienAnnonce;
            DatePublication = offre.DatePublication;
            MySelection = offre.MySelection;
        }

        #endregion "Constructeurs"

        public int CompareTo(Offre other)
        {
            int date = this.DatePublication.CompareTo(other.DatePublication) * -1;
            int selection = this.MySelection.CompareTo(other.MySelection);
            int resultat = (date != 0) ? date : selection;

            return resultat;
        }
    }
}
