using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OliveOyl
{

    enum TypeofIngredient

    {
        Seafood,
        Poultry,
        Vegetables,
        Spices


    }

    enum Units
    {

        Grams,
        Pounds,
        Kilograms,
        Ounces 

    }




    class Ingredients
    {


        public TypeofIngredient TypeofIngredient { get; set; }

        public string Amount { get; set; }
        public Units Units { get; set; }         


    }
}
