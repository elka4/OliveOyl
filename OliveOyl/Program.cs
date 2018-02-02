using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OliveOyl
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("****************************************************");
            Console.WriteLine("Welcome to OliveOyl");
            Console.WriteLine("****************************************************");


            Console.WriteLine("0: Exit");
            Console.WriteLine("1: Create Customer Account");
            Console.WriteLine("2: Add New Subscription");
            Console.WriteLine("3: Go to Shopping Cart");
            Console.WriteLine("4: Find Recipes");
            Console.WriteLine("5: Print All Transactions");


            Console.Write("Please choose an option:");
            var choice = Console.ReadLine();


            //case by case basis (OR)
            switch (choice)
            {

                case "0":
                    Console.WriteLine("Thank you for using Olive Oyl");
                    return;
                case "1":
                   
                        //accept user input to create customer account, user is given an option 
                        Console.WriteLine("Please enter Customer Name");
                        var CustomerName = Console.ReadLine();
                        Console.WriteLine("Please Enter Customer Email Address");
                        var CustomerEmailAddress = Console.ReadLine();

                        //Introducing a loop to go through the subscriptions enum List 
                        var CustomerSubscription = Enum.GetNames(typeof(CustomerSubscriptions));
                        for (var i = 0; i < CustomerSubscription.Length; i++)

                        {
                            Console.Write($"{i + 1}.{CustomerSubscription[i]}");
                        }

                        Console.Write("Please enter the Subscription you are interested in");
                    try
                    {
                        var Subscription = Convert.ToInt32(Console.ReadLine());
                        var CustomerAccount = OliveOyl.CreateAccount(CustomerEmailAddress, CustomerName, (CustomerSubscriptions)(Subscription - 1));
                        Console.WriteLine($"CustomerName: {CustomerAccount.CustomerName}, CustomerEmailAddress: {CustomerAccount.CustomerEmailAddress}");
                    }
                    catch (FormatException)

                    {
                        Console.WriteLine("Subscription Type option is invalid");

                    }
                    catch(ArgumentNullException)

                    break;
                case "2":
                    Console.WriteLine("Select Subscription to add ");
                    var Subscription1 = Convert.ToInt32(Console.ReadLine());
                    var subs = OliveOyl.AddSubscription((CustomerSubscriptions)(Subscription1 -1));

                    break;
                default:
                    break;
              






            }





            

        }

       
        

    }
}
