using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.IO;

namespace BO
{
    [DataContract]
    public class Selection : IComparable<Selection>
    {
        #region "Propriétés d'instance"
        [DataMember]
        public Societe MySociete { get; set; }
        [DataMember]
        public Region MyRegion { get; set; }
        [DataMember]
        public Contrat MyContrat { get; set; }
        [DataMember]
        public Poste MyPoste { get; set; }
        
        [DataMember]
        public Jour NbrJour { get; set; }

        #endregion "Propriétés d'instance"

        #region "Constructeurs"

        public Selection()
        {
            MySociete = new Societe();
            MyRegion = new Region();
            MyContrat = new Contrat();
            MyPoste = new Poste();
            NbrJour = new Jour();
        }

        public Selection(Societe societe,Poste poste, Region region, Contrat contrat, Jour nbrJour)
        {
            MySociete = societe;
            MyPoste = poste;
            MyRegion = region;
            MyContrat = contrat;
            NbrJour = nbrJour;
        }

        #endregion "Constructeurs"
        

        public override string ToString()
        {
            return $"{MyRegion.Nom}";
        }

        public int CompareTo(Selection other)
        {
            int societe = this.MySociete.CompareTo(other.MySociete);
            int region = this.MyRegion.CompareTo(other.MyRegion);
            int contrat = this.MyContrat.CompareTo(other.MyContrat);
            int poste = this.MyPoste.CompareTo(other.MyPoste);
            int resultat = (societe != 0) ? societe : (region != 0) ? region : (contrat != 0) ? contrat : poste;
            return resultat;
        }
    }
}
