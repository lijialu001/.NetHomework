using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace _3._1
{
    public class Order : IXmlSerializable
    {
        public int OrderId { get; set; }
        public string Customer;
        public List<OrderDetails> OrderList = new List<OrderDetails>();
        public decimal Balance { get
            {
                decimal balance = 0;
                foreach(OrderDetails i in OrderList)
                {
                    balance = balance + i.Price * i.Number;
                }
                return balance;
            }
        }

        public Order() { }

        public Order(Order anotherorder)
        {
            foreach (OrderDetails i in anotherorder.OrderList)
            {
                OrderList.Add(new OrderDetails(i));
            }
            Customer = anotherorder.Customer;
            OrderId = anotherorder.OrderId;
        }

        public List<OrderDetails> GetDetails()
        {
            List<OrderDetails> result = new List<OrderDetails>();
            foreach (OrderDetails i in OrderList)
            {
                result.Add(new OrderDetails(i));
            }
            return result;
        }
        public void AddDetail(OrderDetails a)
        {
            bool duplicated = false;
            foreach (OrderDetails i in OrderList)
            {
                if (i.LoadName == a.LoadName)
                {
                    i.Number += a.Number;
                    duplicated = true;
                    break;
                }             
            }
            if (!duplicated) OrderList.Add(a);
        }

        public override bool Equals(object obj)
        {
            if(!(obj is Order))
            {
                return false;
            }
            return this.OrderId==((Order)obj).OrderId;
        }

        public void UpdateItem(OrderDetails detail, string originalName = null)
        {
            foreach (OrderDetails i in OrderList)
            {
                if (originalName == null && detail.LoadName == i.LoadName || originalName == i.LoadName)
                {
                    i.LoadName = detail.LoadName;
                    i.Number = detail.Number;
                    i.Price = detail.Price;
                    break;
                }
            }
        }

        public void RemoveItem(string itemName)
        {
            for (int i = 0; i < OrderList.Count; i++)
            {
                if (OrderList[i].LoadName == itemName)
                {
                    OrderList.RemoveAt(i);
                    break;
                }
            }
        }

        public override string ToString()
        {
            return $"{OrderId:D6}".PadLeft(8) + Customer.PadLeft(25) + $"$ {Balance:F2}".PadLeft(15);
        }
        public XmlSchema GetSchema() => null;

        public void ReadXml(XmlReader reader)
        {
            reader.Read();
            reader.ReadStartElement("Customer");
            Customer = (string)new XmlSerializer(typeof(string)).Deserialize(reader);
            reader.ReadEndElement();
            reader.ReadStartElement("ID");
            OrderId = (int)new XmlSerializer(typeof(int)).Deserialize(reader);
            reader.ReadEndElement();
            reader.ReadStartElement("Details");
            OrderList = (List<OrderDetails>)new XmlSerializer(typeof(List<OrderDetails>)).Deserialize(reader);
            reader.ReadEndElement();
            reader.ReadEndElement();
        }

        public void WriteXml(XmlWriter writer)
        {
            writer.WriteStartElement("Customer");
            new XmlSerializer(typeof(string)).Serialize(writer, Customer);
            writer.WriteEndElement();
            writer.WriteStartElement("ID");
            new XmlSerializer(typeof(int)).Serialize(writer, OrderId);
            writer.WriteEndElement();
            writer.WriteStartElement("Details");
            new XmlSerializer(typeof(List<OrderDetails>)).Serialize(writer, OrderId);
            writer.WriteEndElement();
        }
    }
}
