using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kassensystem_Logic.Dining
{
    public class Meal
    {

        #region " --- Events ---"
        public delegate void amountChangedHandler(Meal sender, int diffAmount);
        public delegate void amountHalfPricedHandler(Meal sender, int diffAmountHalfPriced);
        public event amountChangedHandler amountChanged;
        public event amountHalfPricedHandler amountHalfPriceChanged;
        #endregion
        #region " --- Properties ---"
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal HalfPrice { get; set; }

        private int amount;
        public int Amount
        {
            get
            {
                return amount;
            }
            set
            {
                if (amount != value && amount >= 0)
                {
                    int diff = value - amount;
                    amount = value;
                    if (amountChanged != null)
                    {
                        amountChanged(this, diff);
                    }
                }
            }
        }

        private int amountHalfPrice;
        public int AmountHalfPrice
        {
            get
            {
                return amountHalfPrice;
            }
            set
            {
                if (amountHalfPrice != value)
                {
                    int diff = value - amountHalfPrice;
                    amountHalfPrice = value;
                    if (amountHalfPriceChanged != null)
                    {
                        amountHalfPriceChanged(this, diff);
                    }
                }
            }
        }

        private int totalAmount;
        public int TotalAmount
        {
            get
            {
                return totalAmount;
            }
        }

        private int totalHalfAmount;
        public int TotalAmountHalfPrice
        {
            get
            {
                return totalHalfAmount;
            }
        }
        #endregion
        public Meal(int id, string name, decimal price, decimal halfPrice = 0, int totalAmount = 0, int totalHalfAmount = 0)
        {
            ID = id;
            Name = name;
            Price = price;
            HalfPrice = halfPrice;
            this.totalAmount = totalAmount;
            this.totalHalfAmount = totalHalfAmount;
        }

        public void PayOrder()
        {
            totalAmount += amount;
            Amount = 0;
            totalHalfAmount += amountHalfPrice;
            AmountHalfPrice = 0;
        }
    }
}
