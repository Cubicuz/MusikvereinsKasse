using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kassensystem_Logic.Dining {
    public class Meal {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal HalfPrice { get; set; }

        public Meal(int id, string name, decimal price, decimal halfPrice) {
            ID = id;
            Name = name;
            Price = price;
            HalfPrice = halfPrice;
        }
    }
}
