using PanelaTI.AbstractFactory.Entitites;
using PanelaTI.AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PanelaTI.AbstractFactory.Factories
{
    public class USAGasFactory:IOilGasFactory
    {
        public IBlock BuildBlock()
        {
            USABlock usaBlock = new USABlock();
            return usaBlock;
        }

        public IWell BuildWell()
        {
            USAWell usaWell = new USAWell()
            {
                Name = $"USA-{DateTime.Now.Second}-WELL"
            };
            return usaWell;
        }
    }
}
