using Builder.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Builders
{
    public class BigMacBuilder : BurgerBuilder
    {
        public void SetName() => SetName("Big Mac");
        public void AddBreads() => AddBreads(3);
        public void AddTotalBeef() => AddTotalBeef(2);
        public void AddCheeses() => AddCheeses(new List<CheeseType>() { CheeseType.Cheddar });
        public void PrepareSauce() => PrepareSauce("Molho especial Big Mag");
    }
}
