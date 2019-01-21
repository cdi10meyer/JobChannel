using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface ISelectionableDataAccess
    {
        DataTable SelectBySelection(int idSociete, int idRegion, int idPoste, int idContrat, int nbrJour);
    }
}
