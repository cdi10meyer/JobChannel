using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IGerableDataAccess<T>
    {
        int Update(T gerable);
        int Insert(T gerable);
        int Delete(T gerable);
    }
}
