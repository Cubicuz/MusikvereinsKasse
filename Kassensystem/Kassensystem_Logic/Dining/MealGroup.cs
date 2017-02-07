using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kassensystem_Logic.Dining {
    public class MealGroup {

        public Meal[] Meals;

        public string Name { get; set; }
        public System.Drawing.Color BgColor { get; set; }
        
        public MealGroup(Meal [] m, string name, string color) {
            Meals = m;
            Name = name;
            BgColor = System.Drawing.Color.FromName(color);
        }

        public MealGroup(Meal [] m, string name, System.Drawing.Color color) {
            Meals = m;
            Name = name;
            BgColor = color;
        }

    }
}
