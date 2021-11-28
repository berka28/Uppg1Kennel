using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kennel.Rental.Services
{
    class Washing : RentalService, IWashing
    {
        public Washing(IRental rental) : base(rental)
        {
            Description = "Washing";
            Cost = 5M;
        }
    }    
}
