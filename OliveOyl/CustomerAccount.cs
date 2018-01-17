using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OliveOyl
{


    public enum CustomerSubscriptions
    {

        Vegetarian,
        Family,
        TwoPeople

    }
    public class CustomerAccount
    {

        //These are my properties for Customer Account 
      
        public string CustomerName { get; set; }
        [Key]
        public string CustomerID { get; set; }
        public string CustomerEmailAddress { get; set; }
        public CustomerSubscriptions CustomerSubscription { get; set; }
        public decimal SubscriptionPrice { get; set; }
    }

    








}








