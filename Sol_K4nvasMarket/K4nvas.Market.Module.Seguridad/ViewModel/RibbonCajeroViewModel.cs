﻿using K4nvas.Market.Module.Seguridad.ViewModel.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K4nvas.Market.Module.Seguridad.ViewModel
{
    [Export(typeof(IRibbonCajeroViewModel))]
    public class RibbonCajeroViewModel : IRibbonCajeroViewModel
    {
        [ImportingConstructor]
        public RibbonCajeroViewModel()
        {

        }
    }
}
