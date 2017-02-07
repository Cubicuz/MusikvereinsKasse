using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kassensystem_Logic.Dining {
    public class Meal {

        #region " --- Events ---"
        public delegate void amountChangedHandler(Meal sender, int diffAmount);
        public delegate void amountHalfPricedHandler(Meal sender, int diffAmountHalfPriced);
        public event amountChangedHandler amountChanged;
        public event amountHalfPricedHandler amountHalfPricedChanged;
        #endregion
        #region " --- Properties ---"
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal HalfPrice { get; set; }
        private int amount;
        public int Amount {
            get{
                return amount;
            }
            set {
                if (amount != value) {
                    int diff = value - amount;
                    amount = value;
                    amountChanged(this, diff);
                }
            } }
        private int amountHalfPriced;
        public int AmountHalfPriced {
            get {
                return amountHalfPriced;
            }
            set {
                if (amountHalfPriced != value) {
                    int diff = value - amountHalfPriced;
                    amountHalfPriced = value;
                    amountHalfPricedChanged(this, diff);
                }
            }
        }
        #endregion
        public Meal(int id, string name, decimal price, decimal halfPrice) {
            ID = id;
            Name = name;
            Price = price;
            HalfPrice = halfPrice;
        }
    }
}
