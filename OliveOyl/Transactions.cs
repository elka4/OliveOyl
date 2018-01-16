using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OliveOyl
{
    public class Transactions
    {

        
            [Key]
            public int TransactionID { get; set; }
            public DateTime TransactionDate { get; set; }
            public string Description { get; set; }
            public decimal TransactionAmount { get; set; }

            [ForeignKey("CustomerAccount")]
            public int CustomerID { get; set; }
            public virtual CustomerAccount CustomerAccount { get; set; }

        




    }
}
