using Builder.Entities;
using Builder.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Builders
{
    public abstract class BurgerBuilder
    {
        private Burger Burger { get; set; }

        public BurgerBuilder() => Reset();

        public void SetName(string name) => Burger.Name = name;

        public void Reset() => Burger = new();

        public void AddBreads(int total) => Burger.TotalBread = total;

        public virtual void AddTotalBeef(int total) => Burger.TotalBeef = total;

        public void AddLettuce() => Burger.Lettuce = true;

        public void AddOnion() => Burger.Onion = true;

        public void AddBacon() => Burger.Bacon = true;

        public void AddPickles() => Burger.Pickles = true;
        public void AddTomato() => Burger.Tomato = true;

        public void AddCheeses(List<CheeseType> cheeses) => Burger.Cheeses = cheeses;

        public void PrepareSauce(string sauce) => Burger.Sauce = sauce;

        public Burger Get()
        {
            Burger burger = Burger;
            Reset();
            return burger;
        }
    }
}
