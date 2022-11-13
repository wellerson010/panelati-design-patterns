using Builder.Builders;
using Builder.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Directors
{
    public class Director
    {
        public Burger BuildBigMac()
        {
            BigMacBuilder bigMacBuilder = new();

            bigMacBuilder.SetName();
            bigMacBuilder.AddBreads();
            bigMacBuilder.AddTotalBeef();
            bigMacBuilder.AddLettuce();
            bigMacBuilder.AddCheeses();
            bigMacBuilder.AddOnion();
            bigMacBuilder.AddPickles();
            bigMacBuilder.PrepareSauce();

            return bigMacBuilder.Get();
        }

        public Burger BuildWhooper()
        {
            WhooperBuilder whooperBuilder = new();

            whooperBuilder.SetName();
            whooperBuilder.AddBreads();
            whooperBuilder.AddTotalBeef();
            whooperBuilder.AddLettuce();
            whooperBuilder.AddCheeses();
            whooperBuilder.AddOnion();
            whooperBuilder.AddPickles();
            whooperBuilder.AddTomato();

            return whooperBuilder.Get();
        }

        public Burger BuildMegaStacker(int version)
        {
            MegaStackerBuilder megaStackerBuilder = new();

            megaStackerBuilder.AddBreads();
            megaStackerBuilder.AddTotalBeef(version);
            megaStackerBuilder.AddCheeses(version);
            megaStackerBuilder.AddBacon();
            megaStackerBuilder.PrepareSauce();

            return megaStackerBuilder.Get();
        }
    }
}
