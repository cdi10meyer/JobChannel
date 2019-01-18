using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    [Serializable]
    public class ExceptionDataAccess : Exception
    {
        public ExceptionDataAccess()
        {

        }
        public ExceptionDataAccess(string message):base(message)
        {

        }
        public ExceptionDataAccess(string message, Exception inner) : base(message,inner)
        {

        }
        protected ExceptionDataAccess(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context): base(info,context)
        {

        }
    }
}
