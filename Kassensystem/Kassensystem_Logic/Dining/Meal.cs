using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kassensystem_Logic.Dining {
    class Meal {
        public  int ID { get; set; }
        public String Name { get; set; }
        public decimal FullCost { get; set; }
        public decimal HalfCost { get; set; }

        public Meal(int id, string name, decimal fullcost, decimal halfcost) {
            ID = id;
            Name = name;
            FullCost = fullcost;
            HalfCost = halfcost;
        }
    }
}
