using Builder.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Entities
{
    public class Burger
    {
        public string Name { get; set; } = "";
        public int TotalBread { get; set; }
        public int TotalBeef { get; set; }

        public IList<CheeseType> Cheeses { get; set; } = new List<CheeseType>();

        public bool Lettuce { get; set; }

        public bool Onion { get; set; }

        public bool Bacon { get; set; }

        public bool Pickles { get; set; }

        public string Sauce { get; set; } = "";

        public bool Tomato { get; set; }

        private string GetCheesesDescription() => String.Join(",", Cheeses.Select(x => x.ToString()));

        public override string ToString()
        {
            return $@"Name - {Name}
                      TotalBread - {TotalBread}
                      TotalBeef - {TotalBeef}
                      Cheeses - {GetCheesesDescription()}
                      Lettuce - {Lettuce}
                      Onion - {Onion}
                      Bacon - {Bacon}
                      Pickles - {Pickles}
                      Sauce - {Sauce}
                      Tomato - {Tomato}";
        }
    }
}
