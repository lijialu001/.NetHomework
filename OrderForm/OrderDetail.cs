using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace OrderForm
{
	public class OrderDetail
	{
		public string Name { get; set; }
		public decimal Price { get; set; }
		public decimal Count { get; set; }

		public decimal TotalPrice { get => Price * Count; }

		public override string ToString()
		{
			return Name.PadLeft(25)
				+ $"$ {Price:F2}".PadLeft(12)
				+ $"{Count:F3}".PadLeft(10)
				+ $"$ {TotalPrice:F2}".PadLeft(15);
		}

		public override bool Equals(object obj)
		{
			var detail = obj as OrderDetail;
			return detail != null &&
				   Name == detail.Name &&
				   Price == detail.Price &&
				   Count == detail.Count;
		}

		public override int GetHashCode()
		{
			var hashCode = -1416335276;
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
			hashCode = hashCode * -1521134295 + Price.GetHashCode();
			hashCode = hashCode * -1521134295 + Count.GetHashCode();
			return hashCode;
		}

		public OrderDetail()
		{
			Name = "";
			Price = 0;
			Count = 0;
		}

		public OrderDetail(OrderDetail detail)
		{
			Name = detail.Name;
			Price = detail.Price;
			Count = detail.Count;
		}
	}
}

