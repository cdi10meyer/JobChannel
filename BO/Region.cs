using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    [DataContract]
    public class Region : IComparable<Region>
    {
        #region "Propriétés d'instance"
        [DataMember]
        public int IdRegion { get; set; }
        [DataMember]
        public string NomRegion { get; set; }

        #endregion "Propriétés d'instance"

        #region "Constructeurs"
        public Region()
        {
            IdRegion = 0;
            NomRegion = "Toutes";
        }

        #endregion "Constructeurs"

        #region "Méthodes propres à la classe"

        #endregion "Méthodes propres à la classe"

        public override string ToString()
        {
            return NomRegion;
        }

        public int CompareTo(Region other)
        {
            return this.NomRegion.CompareTo(other.NomRegion);
        }
    }
}
