using PanelaTI.AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PanelaTI.AbstractFactory.Entitites
{
    public class USABlock: IBlock
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Name { get; set; }

        public USABlock()
        {
            StartDate = DateTime.Now;
            EndDate = StartDate.AddYears(10);
        }
    }
}
