﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K4nvas.Market.Common.Helpers.ViewActivator
{
    public interface IViewActivator
    {
        void Activate();
        void Deactivate();
    }
}