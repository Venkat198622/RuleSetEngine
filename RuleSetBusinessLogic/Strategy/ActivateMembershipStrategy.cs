using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
