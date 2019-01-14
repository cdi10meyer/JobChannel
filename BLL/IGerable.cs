using BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public interface IGerable<T> where T : Consultation
    {
        bool Update(T gerable);
        int Create(T gerable);
        bool Delete(T gerable);
    }
}
