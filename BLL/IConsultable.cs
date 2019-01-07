﻿using BO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface IConsultable<T>
    {
        List<T> RetrieveAll();
        List<T> RetrieveAllTous();
    }
}
