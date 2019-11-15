using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carStore
{
    interface IStore
    {
        Name Name { get; set; }
        //IVehicle Model Name { get; set; }

        IOrder MakeOrder(IPerson person, IVehicle vehicle, int deliveryweeks);

        void CancelOrder(IOrder order);
    }
}
