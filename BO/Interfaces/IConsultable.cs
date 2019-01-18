using BO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public interface IConsultable<T>
    {
        int CompareTo(T other);
        string ToString();
    }
}
