using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuleSetBusinessLogic.Strategy
{
	public class BookingStrategy : BaseStrategy
	{

		public BookingStrategy(IStrategy strategy) : base(strategy) { 
		
		}

		public string execute(String name)
		{
			string duplicate = "Duplicate " + base.execute(name);

			return duplicate;
		}
	}
}
