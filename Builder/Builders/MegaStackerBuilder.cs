using Builder.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Builders
{
    public class MegaStackerBuilder : BurgerBuilder
    {
        public void AddBreads() => AddBreads(2);
        public override void AddTotalBeef(int total)
        {
            base.AddTotalBeef(total);
            SetName($"Mega Stacker {total}.0");
        }
        public void AddCheeses(int total)
        {
            List<CheeseType> cheese = new();

            for (int i = 0; i < total; i++)
            {
                cheese.Add(CheeseType.Cheddar);
            }
        }

        public void PrepareSauce() => PrepareSauce("Molho Stacker");
    }
}
