using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kassensystem_Logic.Dining {
    public class DiningPlan {
        private List<meal> MealList;

        void AddMeal(meal m) {
            MealList.Add(m);
        }


        void AddMeal(int index,  meal m) {
            MealList.Insert(index, m);
        }
    }
}
