using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace _3._1
{
    public class OrderService : IXmlSerializable
	{
		private List<Order> orders = new List<Order>();
		private int currentID = 1;

		public Order CreateOrder(Order order)
		{
			order.OrderId = currentID++;
			orders.Add(order);
			return order;
		}

		//检查所需订单号是否存在
		private int GetOrderIndex(int ID)
		{
			for (int i = 0; i < orders.Count; i++)
			{
				if (orders[i].OrderId == ID) return i;
			}
			return -1;
		}

		//按照输入的ID寻找对应订单
		public Order GetOrderByID(int ID)
		{
			int index = GetOrderIndex(ID);
			if (index == -1) return null;
			else return new Order(orders[index]);
		}

		public void UpdateOrder(Order order)
		{
			int index = GetOrderIndex(order.OrderId);
			if (index == -1) throw new KeyNotFoundException("未找到对应的订单");
			else orders[index] = order;
		}

		public void DeleteOrder(int ID)
		{
			int index = GetOrderIndex(ID);
			if (index == -1) throw new KeyNotFoundException("该订单不存在");
			else orders.RemoveAt(index);
		}

		public List<Order> QueryOrder(OrderQueryArgs args)
		{
			IEnumerable<Order> result;
			switch (args.sortKey)
			{
				case SortKey.IDAscending:
					result = from order in orders where args.Check(order) orderby order.OrderId ascending select order;
					break;
				case SortKey.PriceAscending:
					result = from order in orders where args.Check(order) orderby order.Balance ascending select order;
					break;
				case SortKey.CustomerNameAscending:
					result = from order in orders where args.Check(order) orderby order.Customer ascending select order;
					break;
				case SortKey.IDDescending:
					result = from order in orders where args.Check(order) orderby order.OrderId descending select order;
					break;
				case SortKey.PriceDescending:
					result = from order in orders where args.Check(order) orderby order.Balance descending select order;
					break;
				case SortKey.CustomerNameDescending:
					result = from order in orders where args.Check(order) orderby order.Customer descending select order;
					break;
				default:
					result = null;
					break;
			}
			List<Order> resultList = new List<Order>();
			foreach (Order i in result)
			{
				resultList.Add(new Order(i));
			}
			return resultList;
		}
		public void Sort()
		{
			orders.Sort((Order a, Order b) => a.Balance.CompareTo(b.Balance));
		}

		public void Sort(IComparer<Order> comparer)
		{
			orders.Sort(comparer);
		}

		public void Import(string FilePath)
		{
			FileStream fs = new FileStream(FilePath, FileMode.Open);
			XmlSerializer reader = new XmlSerializer(typeof(OrderService));
			OrderService newOS = (OrderService)reader.Deserialize(fs);
			currentID = newOS.currentID;
			orders = newOS.orders;
			fs.Close();
		}

		public void Export(string FilePath)
		{
			FileStream fs = new FileStream(FilePath, FileMode.Create);
			XmlSerializer writer = new XmlSerializer(typeof(OrderService));
			writer.Serialize(fs, this);
			fs.Close();
		}

		public XmlSchema GetSchema() => null;

		public void ReadXml(XmlReader reader)
		{
			reader.Read();
			reader.ReadStartElement("CurrentID");
			currentID = (int)new XmlSerializer(typeof(int)).Deserialize(reader);
			reader.ReadEndElement();
			reader.ReadStartElement("Orders");
			orders = (List<Order>)new XmlSerializer(typeof(List<Order>)).Deserialize(reader);
			reader.ReadEndElement();
			reader.ReadEndElement();
		}

		public void WriteXml(XmlWriter writer)
		{
			writer.WriteStartElement("CurrentID");
			new XmlSerializer(typeof(int)).Serialize(writer, currentID);
			writer.WriteEndElement();
			writer.WriteStartElement("Orders");
			new XmlSerializer(typeof(List<Order>)).Serialize(writer, orders);
			writer.WriteEndElement();
		}
	}
}



