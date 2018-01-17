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
        //opening a connection to the sql server. creating an instance 

        private static OliveOylModel db = new OliveOylModel();
        

        public static CustomerAccount CreateAccount(string CustomerEmailAddress, string CustomerName,
                CustomerSubscriptions Subscription = CustomerSubscriptions.Vegetarian)
        {

            var account = new CustomerAccount
            {

                CustomerEmailAddress = CustomerEmailAddress,
                CustomerSubscription = Subscription,
                CustomerName = CustomerName

            };
            db.Accounts.Add(account);
            db.SaveChanges();
            
            return account;


        }

        public static List<CustomerAccount> GetAllAccounts(string CustomerEmailAddress)

        {
            return db.Accounts.Where(a => a.CustomerEmailAddress == CustomerEmailAddress).ToList();

        }

        

        public static List<Transactions> GetAllTransactions(int customerID)


        {

            return db.Transactions.Where(t => t.CustomerID == customerID).OrderByDescending(t => t.TransactionDate).ToList();



        }


        public static Recipes AddRecipesToCollection(TypeofIngredient TypeofIngredient = TypeofIngredient.Vegetables,TypesofCuisines typesofCuisines = TypesofCuisines.American )
        {

            var recipe = new Recipes
            {

                TypeofIngredient = TypeofIngredient,
                TypesofCuisines = typesofCuisines,

            };
            db.Recipes.Add(recipe);
            db.SaveChanges();

            return recipe;


        }

        public static CustomerAccount AddSubscription(CustomerSubscriptions  CustomerSubscriptions = CustomerSubscriptions.Vegetarian)
        {

            var subscription = new CustomerAccount
            {

                CustomerSubscription = CustomerSubscriptions,   

            };
            db.Accounts.Add(subscription);
            db.SaveChanges();

            return subscription;


        }

      
    }
}
