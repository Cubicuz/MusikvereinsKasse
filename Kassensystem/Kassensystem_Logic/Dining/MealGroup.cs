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

        public string tab = "0";

        public MealGroup(Meal [] m, string name, string color, string tab = "0") {
            Meals = m;
            Name = name;
            if (color.First() == '#')
            {
                BgColor = System.Drawing.ColorTranslator.FromHtml(color);
            } else
            {
                BgColor = System.Drawing.Color.FromName(color);
            }
            this.tab = tab;
        }

        public MealGroup(Meal [] m, string name, System.Drawing.Color color, string tab = "0") {
            Meals = m;
            Name = name;
            BgColor = color;
            this.tab = tab;
        }

        public override string ToString()
        {
            string line = "";
            for (int i = 0; i < Meals.Length; i++)
            {
                line += Meals[i].ToString() + ";";
            }
            return line;
        }

    }
}
