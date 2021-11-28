using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kennel.Rental
{
    public class RentalService
    {
        public IRental Rental { get; set; }
        public string Description;
        public decimal Cost = 0M;
        public RentalService(IRental rental)
        {
            Rental = rental;
        }
        public decimal GetCost()
        {
            return Rental.GetCost() + Cost;
        }

        public string GetDescription()
        {
            return Rental.GetDescription() + ", " + Description;
        }
    }
}
