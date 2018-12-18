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
        public Poste MyPoste { get; set; }
        [DataMember]
        public Region MyRegion { get; set; }
        [DataMember]
        public Contrat MyContrat { get; set; }
        [DataMember]
        public int NbrJour { get; set; }

        #endregion "Propriétés d'instance"

        #region "Constructeurs"
        
        public Selection()
        {
            MyContrat = new Contrat();
            MyRegion = new Region();
            MyPoste = new Poste();
        }

        public Selection(Poste poste, Region region, Contrat contrat, int nbrJour)
        {
            MyPoste = poste;
            MyRegion = region;
            MyContrat = contrat;
            NbrJour = nbrJour;
        }

        #endregion "Constructeurs"


        #region "Méthodes propres à la classe"

        #endregion "Méthodes propres à la classe"

        public override string ToString()
        {
            return $"{MyRegion.NomRegion}";
        }

        public int CompareTo(Selection other)
        {
            int region = this.MyRegion.CompareTo(other.MyRegion);
            int contrat = this.MyContrat.CompareTo(other.MyContrat);
            int poste = this.MyPoste.CompareTo(other.MyPoste);
            int resultat = (region != 0) ? region : (contrat != 0) ? contrat : poste;
            return resultat;
        }
    }
}
