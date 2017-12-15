using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OliveOyl
{

    //This is my Factory Class 


    static class OliveOyl
    {
        //To store list of Accounts Customers have made temporary since I do not know the size of the list

        private static List<CustomerAccount> customeraccounts = new List<CustomerAccount>();

        public static CustomerAccount CreateAccount(string CustomerEmailAddress, string CustomerName,
                CustomerSubscriptions Subscription = CustomerSubscriptions.Vegetarian)
        {

            var account = new CustomerAccount
            {

                CustomerEmailAddress = CustomerEmailAddress,
                SubscriptionType = Subscription,
                CustomerName = CustomerName

            };

            customeraccounts.Add(account);
            return account;


        }




    }
}
