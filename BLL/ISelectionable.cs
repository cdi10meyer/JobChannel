﻿using BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public interface ISelectionable<T>
    {
        List<T> RetrieveBySelection(Selection selection);
    }
}
