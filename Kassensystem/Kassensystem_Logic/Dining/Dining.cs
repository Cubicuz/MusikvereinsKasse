using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kassensystem_Logic.Dining {

    public struct meal {
        public int ID;
        public String Name;
        public UInt64 FullCost;
        public UInt64 HalfCost;
        public string Color;

        public meal(int id, string name, UInt64 fullcost, UInt64 halfcost, string color) {
            ID = id;
            Name = name;
            FullCost = fullcost;
            HalfCost = halfcost;
            Color = color;
        }
    }

    class Dining {
    }
}
