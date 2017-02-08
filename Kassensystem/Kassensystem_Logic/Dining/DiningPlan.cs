using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kassensystem_Logic.Dining {
    public class DiningPlan {

        #region "--- Events ---"
        public delegate void priceChangedHandler(decimal newPrice);

        public event priceChangedHandler priceChanged;
        #endregion

        public MealGroup [] Groups;
        public decimal Price;

        public DiningPlan(MealGroup [] g) {
            Groups = g;
            Price = 0;
            foreach (var mg in Groups) {
                foreach (var m in mg.Meals) {
                    m.amountChanged += onMealAmountChanged;
                }
            }
        }

        public void resetOrder() {
            foreach (var mg in Groups) {
                foreach (var m in mg.Meals) {
                    m.Amount = 0;
                    m.AmountHalfPriced = 0;
                }
            }
        }

        public void PayOrder() {
            foreach (var mg in Groups)
            {
                foreach (var m in mg.Meals)
                {
                    m.PayOrder();
                }
            }
        }

        private void onMealAmountChanged(Meal sender, int diffAmount) {
            Price += diffAmount * sender.Price;
            priceChanged(Price);
        }

        private void onMealHalfAmountChanged(Meal sender, int diffAmount) {
            Price += diffAmount * sender.HalfPrice;
            priceChanged(Price);
        }
    }
}
