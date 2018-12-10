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
    [DataContract]
    public class RegionDataAccess
    {

        public DataTable SelectAllRegions()
        {
            DataTable SchemaTable = new DataTable();
            SqlCommand objSelectCommand = Connection.CreateConnection();
            objSelectCommand.CommandText = "dbo.P_SELECT_AllRegions";
            objSelectCommand.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter objDataAdapter = new SqlDataAdapter(objSelectCommand);
            objDataAdapter.Fill(SchemaTable);
            return SchemaTable;
        }
    }
}
