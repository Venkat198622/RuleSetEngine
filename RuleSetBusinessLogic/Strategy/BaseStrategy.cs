using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuleSetBusinessLogic.Strategy
{
	public abstract class BaseStrategy : IStrategy
	{
		protected IStrategy strategy;

		public BaseStrategy(IStrategy strategy)
		{
			this.strategy = strategy;
		}


		public  string execute(String name)
		{
			return strategy.execute(name);
		}
	}
}
