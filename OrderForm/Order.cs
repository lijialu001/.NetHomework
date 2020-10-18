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
	public class Order : IXmlSerializable
	{
		private List<OrderDetail> details = new List<OrderDetail>();
		public string CustomerName { get; set; }
		public int ID { get; set; }

		public decimal TotalPrice
		{
			get
			{
				decimal totalPrice = 0;
				foreach (OrderDetail i in details) totalPrice += i.Price * i.Count;
				return totalPrice;
			}
		}

		public override string ToString()
		{
			return $"{ID:D6}".PadLeft(8) + CustomerName.PadLeft(25) + $"$ {TotalPrice:F2}".PadLeft(15);
		}

		public Order() { }

		public Order(Order order)
		{
			//details = new List<OrderDetail>();
			foreach (OrderDetail i in order.details)
			{
				details.Add(new OrderDetail(i));
			}
			CustomerName = order.CustomerName;
			ID = order.ID;
		}

		public List<OrderDetail> GetDetails()
		{
			List<OrderDetail> result = new List<OrderDetail>();
			foreach (OrderDetail i in details)
			{
				result.Add(new OrderDetail(i));
			}
			return result;
		}

		public void AddItem(OrderDetail detail)
		{
			bool duplicated = false;
			foreach (OrderDetail i in details)
			{
				if (i.Name == detail.Name)
				{
					i.Count += detail.Count;
					duplicated = true;
					break;
				}
			}
			if (!duplicated) details.Add(detail);
		}

		public void UpdateDetail(OrderDetail detail, string originalName = null)
		{
			if (originalName == null) originalName = detail.Name;
			if (originalName != detail.Name && details.Where(i => i.Name == detail.Name).Count() != 0)
			{
				DeleteDetail(originalName);
				AddItem(detail);
			}
			foreach (OrderDetail i in details)
			{
				if (originalName == i.Name)
				{
					i.Name = detail.Name;
					i.Count = detail.Count;
					i.Price = detail.Price;
					break;
				}
			}
		}

		public OrderDetail GetDetailByName(string name)
		{
			List<OrderDetail> result = new List<OrderDetail>(from detail in details where detail.Name == name select detail);
			if (result.Count == 0) return null;
			else return new OrderDetail(result[0]);
		}

		public void DeleteDetail(string itemName)
		{
			for (int i = 0; i < details.Count; i++)
			{
				if (details[i].Name == itemName)
				{
					details.RemoveAt(i);
					break;
				}
			}
		}

		public XmlSchema GetSchema() => null;

		public void ReadXml(XmlReader reader)
		{
			reader.Read();
			reader.ReadStartElement("Customer");
			CustomerName = (string)new XmlSerializer(typeof(string)).Deserialize(reader);
			reader.ReadEndElement();
			reader.ReadStartElement("ID");
			ID = (int)new XmlSerializer(typeof(int)).Deserialize(reader);
			reader.ReadEndElement();
			reader.ReadStartElement("Details");
			details = (List<OrderDetail>)new XmlSerializer(typeof(List<OrderDetail>)).Deserialize(reader);
			reader.ReadEndElement();
			reader.ReadEndElement();
		}

		public void WriteXml(XmlWriter writer)
		{
			writer.WriteStartElement("Customer");
			new XmlSerializer(typeof(string)).Serialize(writer, CustomerName);
			writer.WriteEndElement();
			writer.WriteStartElement("ID");
			new XmlSerializer(typeof(int)).Serialize(writer, ID);
			writer.WriteEndElement();
			writer.WriteStartElement("Details");
			new XmlSerializer(typeof(List<OrderDetail>)).Serialize(writer, details);
			writer.WriteEndElement();
		}

		public override bool Equals(object obj)
		{
			if (obj.GetType() != GetType()) return false;
			Order order = (Order)obj;
			if (CustomerName == order.CustomerName && ID == order.ID)
			{
				Console.WriteLine("basic ok");
				if (details.Count != order.details.Count) return false;
				Console.WriteLine("count ok");
				for (int i = 0; i < details.Count; i++)
				{
					if (!details[i].Equals(order.details[i])) return false;
				}
				return true;
			}
			else return false;
		}

		public override int GetHashCode()
		{
			var hashCode = 434058583;
			hashCode = hashCode * -1521134295 + EqualityComparer<List<OrderDetail>>.Default.GetHashCode(details);
			hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(CustomerName);
			hashCode = hashCode * -1521134295 + ID.GetHashCode();
			return hashCode;
		}
	}
}
