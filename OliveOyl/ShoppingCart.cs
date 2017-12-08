using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OliveOyl
{
    class ShoppingCart
    #region Properties
    {
        public string ListofItems { get; set; }
        public string BillingAddress { get; set; }
        public string ShippingAddress { get; set; }
        public string CustomerName { get; set; }
        public decimal Total { get; set; }
        public decimal GiftCardBalance { get; set; }
        public decimal PromotionalCodePercent { get; set; }
        public decimal Quantity { get; set; }
        #endregion

        #region Methods
        /// <summary>
        /// Use Gift card to purchase items 
        /// </summary>
        /// <param name="Total">Amount to be paid</param>

        public void UsegiftCard(decimal total)
        {
           GiftCardBalance -= Total;
        }

        public void AddpromotionalCode(decimal total)
        {
            Total = (Total * (1 - PromotionalCodePercent));
        }



        #endregion


    }
}