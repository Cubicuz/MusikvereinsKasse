using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kassensystem_Logic.Dining {
    public class DiningPlan {

        #region "---------- Events ----------"
        public delegate void priceChangedHandler(decimal newPrice);

        public event priceChangedHandler priceChanged;

        public delegate void DiningPlanInstanceChangedHandler(DiningPlan instance);

        public static event DiningPlanInstanceChangedHandler DiningPlanInstanceChanged;
        #endregion



        private static DiningPlan _DiningPlanInstance;

        public static DiningPlan DiningPlanInstance
        {
            get { return _DiningPlanInstance; }
            set {
                _DiningPlanInstance = value;
                _DiningPlanInstance.Price = 0;
                if (DiningPlanInstanceChanged != null)
                {
                    DiningPlanInstanceChanged(_DiningPlanInstance);
                }
            }
        }


        public MealGroup [] Groups;

        private decimal _Price;

        public decimal Price
        {
            get { return _Price; }
            set
            {
                if (_Price != value)
                {
                    _Price = value;
                    if (priceChanged != null)
                    {
                        priceChanged(Price);
                    }
                }
            }
        }


        public DiningPlan(MealGroup [] g) {
            Groups = g;
            Price = 0;
            foreach (var mg in Groups) {
                foreach (var m in mg.Meals) {
                    m.amountChanged += onMealAmountChanged;
                    m.amountHalfPriceChanged += onMealHalfAmountChanged;
                }
            }
        }

        /// <summary>
        /// setts the current amounts to 0
        /// </summary>
        public void resetOrder() {
            foreach (var mg in Groups) {
                foreach (var m in mg.Meals) {
                    m.Amount = 0;
                    m.AmountHalfPrice = 0;
                }
            }
        }

        /// <summary>
        /// saves the current amounts to the Totals and setts them to 0
        /// </summary>
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
        }

        private void onMealHalfAmountChanged(Meal sender, int diffAmount) {
            Price += diffAmount * sender.HalfPrice;
        }
    }
}
