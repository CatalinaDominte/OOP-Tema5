using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carStore
{
    interface IOrder
    {
        IPerson Person { get; set; }

        IVehicle Vehicle { get; set; }

        int DeliveryDate { get; set; }
    }
}
