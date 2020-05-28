
namespace RuleSetBusinessLogic.Product
{
    public  class Product : IProduct
    {

        protected string name;

        protected IStrategy strategy;

        
        public string GetName()
        {
            return this.name;
        }

        
        public void SetStrategy(IStrategy strategy)
        {
            this.strategy = strategy;
        }

         
        public string Payment()
        {
            return this.strategy.execute(this.name);
        }
    }
}
