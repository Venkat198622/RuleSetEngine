using RuleSetBusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RusetEngine
{
    class Program
    {
        private static string[] orders = { "physical", "booking", "activatemembership", "upgrademembership", "video" };
        static void Main(string[] args)
        {
            GenerateRules();
        }

        static void GenerateRules()
        {

            foreach (string slip in orders)
            {
                ShoppingCart.GetInstance().AddProduct(ChooseProduct.GetProduct(slip));
            }
        }
            
    }
}
