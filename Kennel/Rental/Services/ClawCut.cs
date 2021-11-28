using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kennel.Rental.Services
{
    internal class ClawCut : RentalService, IClawCut
    {
        public ClawCut(IRental rental) : base(rental)
        {
            Description = "Claw Cut";
            Cost = 4M;
        }
    }
}
