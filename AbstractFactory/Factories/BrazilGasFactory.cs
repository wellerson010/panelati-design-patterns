using AbstractFactory.Entitites;
using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factories
{
    public class BrazilGasFactory : IOilGasFactory
    {
        public IBlock BuildBlock()
        {
            BrazilBlock brazilBlock = new BrazilBlock();

            return brazilBlock;
        }

        public IWell BuildWell()
        {
            BrazilWell brazilWell = new BrazilWell()
            {
                Name = $"BR-{DateTime.Now.Year}-{DateTime.Now.Minute}"
            };

            return brazilWell;
        }
    }
}
