using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carStore
{
    class Vehicle:IVehicle
    {
        public IProducer Producer { get; set; }

        public Model Name { get; set; }

        public decimal Price { get; set; }
        public Vehicle(IProducer Producer, Model Name, decimal Price)
        {
            this.Producer = Producer;
            this.Name = Name;
            this.Price = Price;
        }
       
    }
    public enum Model
    {
        Fabia, Focus, Octavia, Mondeo, Corsa, Astra
    }
}
