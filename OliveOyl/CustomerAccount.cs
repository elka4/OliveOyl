using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OliveOyl
{


    enum CustomerSubscriptions
    {

        Vegetarian,
        Family,
        TwoPeople

    }
    class CustomerAccount
    {

        //These are my properties for Customer Account 
      
        public string CustomerName { get; set; }
        public string CustomerEmailAddress { get; set; }
        public CustomerSubscriptions SubscriptionType { get; set; }


    }
}
