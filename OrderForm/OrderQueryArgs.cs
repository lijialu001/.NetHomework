using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace OrderForm
{
	public enum SortKey
	{
		IDAscending, PriceAscending, CustomerNameAscending,
		IDDescending, PriceDescending, CustomerNameDescending
	}

	public class OrderQueryArgs
	{
		public decimal maxPrice = -1;
		public decimal minPrice = -1;
		public List<string> itemNames = new List<string>();
		public string customerName = "";
		public SortKey sortKey = SortKey.PriceAscending;

		public bool Check(Order order)
		{
			//Check Customer Name
			if (customerName != "")
			{
				Match match = Regex.Match(order.CustomerName, customerName);
				if (!match.Success) return false;
			}

			//Check Total Price
			decimal price = order.TotalPrice;
			if ((minPrice >= 0 && price < minPrice) || (maxPrice >= 0 && price > maxPrice)) return false;

			//Check Item Names
			foreach (string str in itemNames)
			{
				bool matchFound = false;
				foreach (OrderDetail detail in order.GetDetails())
				{
					Match match = Regex.Match(detail.Name, str);
					if (match.Success)
					{
						matchFound = true;
						break;
					}
				}
				if (!matchFound) return false;
			}

			return true;
		}
	}
}
