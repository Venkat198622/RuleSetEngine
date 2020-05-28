using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuleSetBusinessLogic.Strategy
{
	class UpgradeMembershipStrategy:IStrategy
	{
		public string execute(string name)
		{
			return "upgrade";
		}

	}
}