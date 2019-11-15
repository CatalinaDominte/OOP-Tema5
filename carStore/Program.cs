using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carStore
{
    class Program
    {
        static void Main(string[] args)
        {
            IPerson alex = new Client { Name = "Alex" };

            IStore ford = new Store(Name.Ford);
            IVehicle focus = new Vehicle((new Producer { Name = Name.Ford }), Model.Focus, 15000);

            IStore skoda = new Store(Name.Skoda);
            IVehicle fabia = new Vehicle((new Producer { Name = Name.Skoda }), Model.Fabia, 14000 );
            
            IOrder focusOrder = ford.MakeOrder(alex, focus, 4);

            IOrder skodaOrder = skoda.MakeOrder(alex, fabia, 3);

            if (focusOrder.DeliveryDate < skodaOrder.DeliveryDate)
            {
                skoda.CancelOrder(skodaOrder);
            }
            else
            {
                ford.CancelOrder(focusOrder);
            }
            
            
            Console.Read();
        }
    }
}
