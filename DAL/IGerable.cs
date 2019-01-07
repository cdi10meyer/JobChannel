using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IGerable<T> : IConsultable
    {
        int Update(T gerable);
        int Insert(T gerable);

        int Delete(int id)
    }
}
