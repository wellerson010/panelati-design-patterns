﻿using PanelaTI.AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PanelaTI.AbstractFactory.Factories
{
    public interface IOilGasFactory
    {
        IBlock BuildBlock();

        IWell BuildWell();
    }
}
