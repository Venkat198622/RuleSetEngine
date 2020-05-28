using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuleSetBusinessLogic.Strategy
{
	class NotifyMemebershipChange : BaseStrategy
	{

		public NotifyMemebershipChange(IStrategy strategy) : base(strategy)
		{

		}
		public string execute(String name)
		{
			return "nofify";
		}
	}
}
