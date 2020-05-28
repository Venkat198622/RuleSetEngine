using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuleSetBusinessLogic.Strategy
{
	public class PhysicalStrategy : IStrategy
	{
		public string execute(string name)
		{
			 
			string slip = "Generate a packing slip for " + name;
			 
			return slip;
		}

	}
}