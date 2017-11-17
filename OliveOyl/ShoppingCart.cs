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
        public string CustomerName { get; set; }
        public decimal Total { get; set; }
    #endregion


    }
}