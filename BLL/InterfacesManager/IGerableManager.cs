using BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public interface IGerableManager<T>
    {
        bool Update(T gerable);
        int Create(T gerable);
        bool Delete(T gerable);
    }
}
