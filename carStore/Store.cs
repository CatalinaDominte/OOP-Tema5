using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carStore
{
    class Store:IStore
    {
        private List<IOrder> Orders;
        public Name Name { get; set; }
        

        public Store(Name name)
        {
            this.Name = name;
            Orders = new List<IOrder>();
           
        }
       
        public void CancelOrder(IOrder order)
        {
            Console.WriteLine($"{order.Person.Name} cancel {order.Vehicle.Name}");

            Orders.Remove(order);
            
        }

        public IOrder MakeOrder(IPerson person, IVehicle vehicle, int deliveryweeks)
        {
            Console.WriteLine($"{person.Name} order {vehicle.Producer.Name} {vehicle.Name}");
            Console.WriteLine($"The cost is: {vehicle.Price}.The car will be delivered in {deliveryweeks} weeks");

            var order = new Order
            {
                Person = person,
                Vehicle = vehicle,
                DeliveryDate = deliveryweeks
            };

            Orders.Add(order);

            return order;
        }
    }
}
