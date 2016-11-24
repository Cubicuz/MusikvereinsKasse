using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kassensystem_Logic.Dining {
    public class MealGroup {

        public Meal[] meals;

        public string Name { get; set; }
        public System.Drawing.Color BgColor { get; set; }
        
        private int numberOfMeals = 0;
        public MealGroup(Meal [] m, string name, string color) {
            meals = m;
            Name = name;
            BgColor = System.Drawing.Color.FromName(color);
        }

        public MealGroup(Meal [] m, string name, System.Drawing.Color color) {
            meals = m;
            Name = name;
            BgColor = color;
        }

    }
}
