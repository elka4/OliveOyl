using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OliveOyl
{
    class CustomerAccount
    {

        //These are my properties for Customer Aaccount 
  

             
        
        public string CustomerName { get; set; }
        public string CustomerEmailAddress { get; set; }
        public CustomerSubscriptions SubscriptionType { get; set; }




        public static CustomerAccount CreateAccount(string CustomerEmailAddress, string CustomerName,
                CustomerSubscriptions Subscription = CustomerSubscriptions.Vegetarian)
        {

            var account = new CustomerAccount
            {

                CustomerEmailAddress = CustomerEmailAddress,
                SubscriptionType = Subscription,
                CustomerName = CustomerName

            };

            return account;


        }








    }
}
