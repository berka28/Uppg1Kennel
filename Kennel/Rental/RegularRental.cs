using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kennel.Rental
{
    internal class RegularRental : IRegularRental
    {
        public string Description { get; private set; }
        public RegularRental()
        {
            Description = "Regular Service";
        }
        public decimal GetCost()
        {
            return 100M;
        }

        public string GetDescription()
        {
            return Description;
        }
    }
}
