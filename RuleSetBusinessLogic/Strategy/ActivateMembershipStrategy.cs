namespace RuleSetBusinessLogic.Strategy
{
	class ActivateMembershipStrategy : IStrategy
	{
		public string execute(string name)
		{
			return "activate";
		}

	}
}
