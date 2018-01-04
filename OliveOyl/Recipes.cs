using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OliveOyl
{
    enum TypesofCuisines
    {
        Indian,
        Asian,
        Italian,
        Mexican,
        American,
        Baking
    }
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




    class Recipes
    {


        public TypeofIngredient TypeofIngredient { get; set; }
        public TypesofCuisines TypesofCuisines { get; set; }
        public string Amount { get; set; }
        public Units Units { get; set; }


        #region Method for weight conversion 

        public void ConvertWeight(decimal Amount)

        {
      

        }

        #endregion







    }
}
