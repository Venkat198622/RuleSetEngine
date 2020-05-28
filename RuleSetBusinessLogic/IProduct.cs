namespace RuleSetBusinessLogic
{
    public interface IProduct
    {
        string GetName();
        void SetStrategy(IStrategy strategy);
        string Payment();
    }
}
