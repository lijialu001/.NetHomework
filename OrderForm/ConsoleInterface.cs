using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderForm
{
	class ConsoleInterface
	{

		/// <summary>
		/// Read a non-negative integer from standard input.
		/// </summary>
		/// <param name="max">The maximun number of the input.</param>
		/// <returns>The number read or null.</returns>
		public static int ReadInt(int max = 2147483647) => ReadInt(0, max);

		/// <summary>
		/// Read an integer from standard input.
		/// </summary>
		/// <param name="min">The minimum number of the input.</param>
		/// <param name="max">The maximun number of the input.</param>
		/// <returns></returns>
		public static int ReadInt(int min, int max)
		{
			string s;
			int v;
			s = Console.ReadLine();
			while (!int.TryParse(s, out v) || v < min || v > max)
			{
				Console.WriteLine("输入无效，请重新输入！");
				s = Console.ReadLine();
			}
			return v;
		}

		/// <summary>
		/// Read an integer from standard input. Returns null if nullable is set to true and the user left it blank.
		/// </summary>
		/// <param name="min">The minimum number of the input.</param>
		/// <param name="max">The maximun number of the input.</param>
		/// <param name="nullable">Whether function returns null when the user leave it blank.</param>
		/// <returns></returns>
		public static int? ReadInt(int min, int max, bool nullable)
		{
			string s;
			int v;
			s = Console.ReadLine();
			while ((!int.TryParse(s, out v) || v < min || v > max) && !(nullable && s == ""))
			{
				Console.WriteLine("输入无效，请重新输入！");
				s = Console.ReadLine();
			}
			if (s == "") return null;
			return v;
		}

		/// <summary>
		/// Read a non-negative deciaml from standard input.
		/// </summary>
		/// <returns>The number read.</returns>
		public static decimal ReadDecimal() => ReadDecimal(false).Value;

		/// <summary>
		/// Read a non-negative deciaml from standard input. Returns null if nullable is set to true and the user left it blank.
		/// </summary>
		/// <param name="nullable">Whether function returns null when the user leave it blank.</param>
		/// <returns>The number read.</returns>
		public static decimal? ReadDecimal(bool nullable)
		{
			string s;
			decimal d;
			s = Console.ReadLine();
			while ((!decimal.TryParse(s, out d) || d < 0) && !(nullable && s == ""))
			{
				Console.WriteLine("输入无效，请重新输入！");
				s = Console.ReadLine();
			}
			if (s == "") return null;
			return d;
		}

		/// <summary>
		/// Read a bool value from standard input in form of "Y" or "N".
		/// </summary>
		/// <returns>The vale read.</returns>
		public static bool ReadBool()
		{
			string s;
			s = Console.ReadLine();
			while (s != "Y" && s != "y" && s != "N" && s != "n")
			{
				Console.WriteLine("输入无效，请重新输入！");
				s = Console.ReadLine();
			}
			return s == "Y" || s == "y";
		}

		/// <summary>
		/// Clear the screen and print the title.
		/// </summary>
		public static void ClearScreen()
		{
			Console.Clear();
			Console.WriteLine("欢迎使用订单管理系统");
		}

		/// <summary>
		/// Print the main menu of the program.
		/// </summary>
		public static void ShowMenu()
		{
			Console.WriteLine("1.添加订单");
			Console.WriteLine("2.查询订单");
			Console.WriteLine("3.导入订单");
			Console.WriteLine("4.导出订单");
			Console.WriteLine("5.退出系统");
		}

		/// <summary>
		/// Print order menu, usually after displaying the detail of the order.
		/// </summary>
		public static void ShowOrderMenu()
		{
			Console.WriteLine("1.添加商品");
			Console.WriteLine("2.修改商品");
			Console.WriteLine("3.删除商品");
			Console.WriteLine("4.删除订单");
			Console.WriteLine("5.保存并返回主菜单");
			Console.WriteLine("6.放弃并返回主菜单");
		}

		/// <summary>
		/// Guide the user to select the key of sort.
		/// </summary>
		public static SortKey SelectSortKey()
		{
			Console.WriteLine("请选择排序方式，留空则默认按金额排序：");
			Console.WriteLine("1.ID升序");
			Console.WriteLine("2.金额升序");
			Console.WriteLine("3.客户名升序");
			Console.WriteLine("4.ID降序");
			Console.WriteLine("5.金额降序");
			Console.WriteLine("6.客户名降序");
			int result = (ReadInt(1, 6, true) ?? 2) - 1;
			return (SortKey)result;
		}

		/// <summary>
		/// Add the order to the order service.
		/// </summary>
		/// <param name="os">The order service.</param>
		public static void AddOrder(OrderService os)
		{
			Console.WriteLine("请输入客户名称，留空则放弃：");
			string str = Console.ReadLine();
			if (str == "") return;
			Order order = new Order { CustomerName = str };
			AddItem(order);
			UpdateOrder(os, os.CreateOrder(order));
		}

		/// <summary>
		/// Add items to the order.
		/// </summary>
		/// <param name="order">The order.</param>
		private static void AddItem(Order order)
		{
			bool loop = true;
			while (loop)
			{
				OrderDetail detail = new OrderDetail();
				Console.WriteLine("请输入商品名称，留空则放弃：");
				string str = Console.ReadLine();
				if (str == "") break;
				detail.Name = str;
				detail.Price = 0;
				bool duplicated = (from OrderDetail i in order.GetDetails() where i.Name == str select i).Count() != 0;
				if (duplicated)
				{
					Console.WriteLine("该商品已存在，是否继续？Y/N");
					bool Comfirmed = ReadBool();
					if (!Comfirmed) continue;
				}
				else
				{
					Console.WriteLine("请输入商品价格：");
					detail.Price = ReadDecimal();
				}
				Console.WriteLine("请输入商品数量：");
				detail.Count = ReadDecimal();
				order.AddItem(detail);
				Console.WriteLine("是否继续？Y/N");
				loop = ReadBool();
			}
		}

		public static void UpdateItem(Order order)
		{
			List<OrderDetail> details = order.GetDetails();
			Console.WriteLine("请输入要修改的商品编号，留空放弃：");
			int index = ReadInt(1, details.Count, true) ?? -1;
			if (index == -1) return;
			OrderDetail detail = details[index - 1];
			string oldName = detail.Name;
			Console.WriteLine("请输入新的商品名称，留空则保留 [" + detail.Name + "]：");
			string newName = Console.ReadLine();
			if (newName != "") detail.Name = newName;
			Console.WriteLine("请输入新的商品价格，留空则保留 [" + $"$ {detail.Price:F2}" + "]：");
			decimal? price = ReadDecimal(true);
			if (price.HasValue) detail.Price = price.Value;
			Console.WriteLine("请输入新的商品数量，留空则保留 [" + $"{detail.Count:F3}" + "]：");
			decimal? count = ReadDecimal(true);
			if (count.HasValue) detail.Count = count.Value;
			order.UpdateDetail(detail, oldName);
		}

		public static void DeleteItem(Order order)
		{
			List<OrderDetail> details = order.GetDetails();
			Console.WriteLine("请输入要删除的商品编号，留空放弃：");
			int index = ReadInt(1, details.Count, true) ?? -1;
			if (index == -1) return;
			Console.WriteLine("确定要删除商品 " + details[index - 1].Name + " 吗？Y/N");
			bool confirm = ReadBool();
			if (confirm) order.DeleteDetail(details[index - 1].Name);
		}

		public static Order SelectOrder(OrderService os)
		{
			Console.WriteLine("请输入订单ID，-1放弃查询，留空则使用条件查询");
			int? id;
			do
			{
				id = ReadInt(-1, 2147483647, true);
				if (id.HasValue)
				{
					if (id == -1) return null;
					Order order = os.GetOrderByID(id.Value);
					if (order == null)
					{
						Console.WriteLine("该订单不存在，请重新输入ID：");
						continue;
					}
					else return order;
				}
			} while (id.HasValue);
			OrderQueryArgs args = new OrderQueryArgs();
			Console.WriteLine("请输入订单客户名，留空则不使用此条件");
			args.customerName = Console.ReadLine();
			Console.WriteLine("请输入包含的商品名，留空结束输入");
			string itemName;
			do
			{
				itemName = Console.ReadLine();
				if (itemName != "") args.itemNames.Add(itemName);
			}
			while (itemName != "");
			Console.WriteLine("请输入最小金额，留空则不使用此条件");
			args.minPrice = ReadDecimal(true) ?? -1;
			Console.WriteLine("请输入最大金额，留空则不使用此条件");
			args.maxPrice = ReadDecimal(true) ?? -1;
			args.sortKey = SelectSortKey();
			List<Order> orders = os.QueryOrder(args);
			if (orders.Count == 0)
			{
				Console.WriteLine("没有符合条件的订单");
				Console.WriteLine("按任意键继续...");
				Console.ReadKey(true);
				return null;
			}
			for (int i = 0; i < orders.Count; i++)
			{
				Console.WriteLine($"{i + 1}. {orders[i].ToString()}");
			}
			Console.WriteLine("请输入所选择订单的编号");
			int index = ReadInt(1, orders.Count);
			return orders[index - 1];
		}

		public static bool DeleteOrder(OrderService os, Order order)
		{
			Console.WriteLine("确定要删除该订单吗？Y/N");
			bool confirm = ReadBool();
			if (confirm) os.DeleteOrder(order.ID);
			return confirm;
		}

		public static void ShowOrderDetails(Order order)
		{
			Console.WriteLine("客户名：" + order.CustomerName);
			Console.WriteLine("编号                     品名        单价      数量           总价");
			List<OrderDetail> details = order.GetDetails();
			for (int i = 0; i < details.Count; i++)
			{
				Console.WriteLine((i + 1).ToString().PadLeft(4) + details[i].ToString());
			}
		}

		public static void UpdateOrder(OrderService os, Order order)
		{
			if (order == null) return;
			int op;
			do
			{
				ClearScreen();
				ShowOrderDetails(order);
				ShowOrderMenu();
				op = ReadInt(1, 6);
				switch (op)
				{
					case 1: AddItem(order); break;
					case 2: UpdateItem(order); break;
					case 3: DeleteItem(order); break;
					case 4:
						if (DeleteOrder(os, order)) return;
						break;
				}
			}
			while (op < 5);
			if (op == 5) os.UpdateOrder(order);
		}

		public static void ImportOS(OrderService os)
		{
			try
			{
				os.Import("data.xml");
				Console.WriteLine("导入成功！");
				Console.ReadKey(true);
			}
			catch (Exception ex)
			{
				Console.WriteLine("导入失败！");
				Console.WriteLine(ex.Message);
				Console.WriteLine(ex.StackTrace);
				Console.ReadKey(true);
			}
		}

		public static void ExportOS(OrderService os)
		{
			try
			{
				os.Export("data.xml");
				Console.WriteLine("导出成功！");
				Console.ReadKey(true);
			}
			catch (Exception ex)
			{
				Console.WriteLine("导出失败！");
				Console.WriteLine(ex.Message);
				Console.WriteLine(ex.StackTrace);
				Console.ReadKey(true);
			}
		}
	}
}
