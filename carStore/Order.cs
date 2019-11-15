using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carStore
{
    class Order:IOrder
    {
        public IPerson Person { get; set; }

        public IVehicle Vehicle { get; set; }

        public int DeliveryDate { get; set; }
        

       
       
    }
    public enum Name
    {
        Skoda, Ford, AlfaRomeo, Fiat, Volvo, Audi, Opel
    };
}
