using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kassensystem_Logic.Billing {
    class BillEntry {
        public int MealID { get; set; }
        public int HalfMealCount { get; set; }
        public int FullMealCount { get; set; }
    }
}
