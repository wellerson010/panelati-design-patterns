using Builder.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Builders
{
    public class WhooperBuilder : BurgerBuilder
    {
        public void SetName() => SetName("Whooper");

        public void AddBreads() => AddBreads(2);
        public void AddTotalBeef() => AddTotalBeef(1);
        public void AddCheeses() => AddCheeses(new List<CheeseType>() { CheeseType.Cheddar });
    }
}
