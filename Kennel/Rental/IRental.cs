using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kennel.Rental
{
    public interface IRental
    {
        decimal GetCost();
        string GetDescription();
    }
}
