using System;
using RuleSetBusinessLogic.Product;
using RuleSetBusinessLogic.Strategy;

namespace RuleSetBusinessLogic
{
    public class ChooseProduct
    {
        private ChooseProduct() { }
 

    public static IProduct GetProduct(string type)
    {
            IProduct product = null;
            switch (type)
            {
                case "physical":
                    product = new PhysicalProduct("Pyhsical");
                    product.SetStrategy(new PhysicalStrategy());
                    break;
                case "booking":
                    product = new PhysicalProduct("booking");
                    product.SetStrategy(new BookingStrategy(new PhysicalStrategy()));
                    break;
                case "activatemembership":
                    product = new PhysicalProduct("membership");
                    product.SetStrategy(new NotifyMemebershipChange(new ActivateMembershipStrategy()));
                    break;
                case "upgrademembership":
                    product = new PhysicalProduct("membership");
                    product.SetStrategy(new NotifyMemebershipChange(new UpgradeMembershipStrategy()));
                    break;
                case "video":
                    product = new PhysicalProduct("video");
                    product.SetStrategy(new VideoStrategy());
                    break;
                default:
                    product = null;
                    break;
            }
           

            return product;
        }
    }
    
}
