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
    public interface IConsultableManager<Consultation>
    {
        List<Consultation> RetrieveAll(Consultation consultation);
    }
}
