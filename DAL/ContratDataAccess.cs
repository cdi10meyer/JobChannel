using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ContratDataAccess : ConsultationDataAccess
    {
        public ContratDataAccess()
        {
            Procedure = "dbo.P_SELECT_AllContrats";
        }

        //public DataTable SelectAllContrats()
        //{
        //    DataTable SchemaTable = new DataTable();
        //    SqlCommand objSelectCommand = Connection.CreateConnection();
        //    objSelectCommand.CommandText = "dbo.P_SELECT_AllContrats";
        //    objSelectCommand.CommandType = CommandType.StoredProcedure;
        //    SqlDataAdapter objDataAdapter = new SqlDataAdapter(objSelectCommand);
        //    objDataAdapter.Fill(SchemaTable);
        //    return SchemaTable;
        //}
    }
}
