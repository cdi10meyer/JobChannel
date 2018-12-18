﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Poste : IComparable<Poste>
    {

        #region "Propriétés d'instance"
        public int IdPoste { get; set; }

        public string TypePoste { get; set; }

        #endregion "Propriétés d'instance"

        #region "Constructeurs"
        public Poste()
        {
            IdPoste = 0;
            TypePoste = "Tous";
        }

        #endregion "Constructeurs"

        #region "Méthodes propres à la classe"

        #endregion "Méthodes propres à la classe"

        public override string ToString()
        {
            return TypePoste;
        }

        public int CompareTo(Poste other)
        {
            return this.TypePoste.CompareTo(other.TypePoste);
        }
    }
}
