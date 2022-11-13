using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Entitites
{
    public class BrazilBlock : IBlock
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Name { get; set; }

        public BrazilBlock()
        {
            StartDate = DateTime.Now;
            EndDate = StartDate.AddYears(5);
        }
    }
}
