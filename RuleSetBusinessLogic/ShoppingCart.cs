using System;
using System.Collections.Generic;

namespace RuleSetBusinessLogic
{
	public class ShoppingCart
	{
		private static ShoppingCart instance;
		private List<IProduct> carts =new List<IProduct>();

		private ShoppingCart()
		{
			 
		}

		public static ShoppingCart GetInstance()
		{
			if (instance == null)
			{
				instance = new ShoppingCart();
			}

			return instance;
		}

		public void AddProduct(IProduct product)
		{
			this.carts.Add(product);
		}

		public void RemoveProduct(IProduct product)
		{
			this.carts.Remove(product);
		}

		 
	}
}
