using Kassensystem_Logic.Dining;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kassensystem_Logic.Billing {
    struct BillEntry {
        int id;
        int FullMealCount;
        int HalfMealCount;
    }

    class Bill {
        public List<BillEntry> entries;

        public void AddEntry(Meal m, int FullMealCoutn, int HalfMealCount) {

        }
    }


}