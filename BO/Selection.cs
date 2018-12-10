using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Selection
    {

        #region "Propriétés propre à la classe"

        private static Selection _Preference;

        #endregion "Propriétés propre à la classe"

        #region "Propriétés d'instance"
        public Poste MyPoste { get; set; }

        public Region MyRegion{ get; set; }

        public Contrat MyContrat { get; set; }

        public int NbrJour { get; set; }

        #endregion "Propriétés d'instance"

        #region "Constructeurs"
        private Selection()
        {

        }

        public Selection(Poste poste,Region region,Contrat contrat,int nbrJour)
        {
            MyPoste = poste;
            MyRegion = region;
            MyContrat = contrat;
            NbrJour = nbrJour;
        }
        
        #endregion "Constructeurs"


        #region "Méthodes propres à la classe"

        public static Selection GetPreference()
        {
            if (_Preference is null)
            {
                return new Selection();
            }
            return _Preference;
        }
        public static void CreatePreference(Poste poste, Region region, Contrat contrat, int nbrJour)
        {
            _Preference = new Selection(poste,region,contrat,nbrJour);
        }
        public static void CreatePreference(Selection selection )
        {
            _Preference = selection;
        }

        #endregion "Méthodes propres à la classe"

    }
}
