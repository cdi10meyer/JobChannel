using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    [DataContract]
    public class Region : Consultation
    {
        #region "Constructeurs"
        public Region()
        {
            Id = 0;
            Nom = "Toutes";
        }
        public Region(Consultation consultation)
        {
            Id = consultation.Id;
            Nom = consultation.Nom;
        }

        #endregion "Constructeurs"
    }
}
