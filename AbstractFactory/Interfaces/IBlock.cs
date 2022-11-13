using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PanelaTI.AbstractFactory.Interfaces
{
    public interface IBlock
    {
        DateTime StartDate { get; set; }

        DateTime EndDate { get; set; }

        string Name { get; set; }
    }
}
