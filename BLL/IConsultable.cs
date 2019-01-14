using BO;
using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public interface IConsultable<T> where T : Consultation
    {
        List<T> RetrieveAll(string textItem, Consultation consultation);
    }
}
