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
    public abstract class ConsultationDataAccess
    {
        [DataMember]
        public SqlCommand ObjSqlCommand = new SqlCommand().CreateConnection();
        [DataMember]
        public DataTable SchemaTable { get; set; }
        [DataMember]
        public string Procedure { get; set; }

        public DataTable SelectAll()
        {
            SchemaTable = new DataTable();
            SqlCommand objSelectCommand = ObjSqlCommand;
            objSelectCommand.CommandText = Procedure;
            objSelectCommand.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter objDataAdapter = new SqlDataAdapter(objSelectCommand);
            objDataAdapter.Fill(SchemaTable);
            return SchemaTable;
        }
    }
}
