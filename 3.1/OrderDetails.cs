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
     public class OrderDetails
    {
        public string LoadName { get; set; }
        public decimal Price { get; set; }
        public decimal Number { get; set; }
        public decimal TotalPrice { get => Price * Number; }

        public OrderDetails() { }
        public OrderDetails(OrderDetails a)
        {
            LoadName = a.LoadName;
            Price = a.Price;
            Number = a.Number;
        }

        public override bool Equals(object obj)
        {
            OrderDetails m = obj as OrderDetails;
            return m.LoadName == LoadName && m.Number == Number; ;
        }

        public override string ToString()
        {
            return LoadName.PadLeft(25)
                + $"$ {Price:F2}".PadLeft(12)
                + $"{Number:F3}".PadLeft(10)
                + $"$ {TotalPrice:F2}".PadLeft(15);
        }
    }
}
