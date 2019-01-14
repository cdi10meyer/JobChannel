using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    [DataContract]
    public class Poste : Consultation
    {

        #region "Constructeurs"
        public Poste()
        {
            Id = 0;
            Nom = "Tous";
        }
        public Poste(Consultation consultation)
        {
            Id = consultation.Id;
            Nom = consultation.Nom;
        }

        #endregion "Constructeurs"

    }
}
