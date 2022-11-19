using Decorator.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Utils
{
    public class GenerateFakeData
    {
        public static IList<Layer> CreateData()
        {
            IList<Layer> layers = new List<Layer>()
            {
                new Layer()
                {
                    Company = "Petrobras",
                    CreationDate = DateTime.Now,
                    Name = "Poços",
                    Workspace = "GEO"
                },
                 new Layer()
                {
                    Company = "Shell",
                    CreationDate = DateTime.Now.AddMonths(-2),
                    Name = "Blocos",
                    Workspace = "GEO"
                },
                  new Layer()
                {
                    Company = "Geopost",
                    CreationDate = DateTime.Now.AddYears(-2),
                    Name = "Campo",
                    Workspace = "GEO"
                },
            };

            return layers;
        }
    }
}
