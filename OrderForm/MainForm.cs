using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrderForm
{
	public partial class MainForm : Form
	{
		private OrderService os = new OrderService();
		private OrderQueryArgs queryArgs = new OrderQueryArgs();
		private List<Order> shownOrders = new List<Order>();
		private List<OrderDetail> shownDetails = new List<OrderDetail>();

		public MainForm()
		{
			InitializeComponent();
			Order order = new Order() { CustomerName = "123" };
			order.AddItem(new OrderDetail() { Count = 10, Name = "1234", Price = 10 });
			os.CreateOrder(order);
			SetDataBindings();
			Shown += MainForm_SizeChanged;
			SizeChanged += MainForm_SizeChanged;
		}

		private void SetDataBindings()
		{
			shownOrders = os.QueryOrder(queryArgs);
			OrderBS.DataSource = shownOrders;
		}

		private void MainForm_SizeChanged(object sender, EventArgs e)
		{
			HorizontalSpliter.SplitterDistance = 30;
			VerticalSplitter.SplitterDistance = Width / 2;
		}

		private List<Order> GetSelectedOrders()
		{
			List<Order> result = new List<Order>();
			foreach (DataGridViewCell cell in OrderGridView.SelectedCells)
			{
				if (cell.OwningColumn.DataPropertyName == "ID")
				{
					result.Add(os.GetOrderByID((int)cell.Value));
				}
			}
			return result;
		}

		private void AddOrderBtn_Click(object sender, EventArgs e)
		{
			new EditOrderForm(os).ShowDialog();
		}

		private void DeleteOrderBtn_Click(object sender, EventArgs e)
		{

		}

		private void UpdateOrderBtn_Click(object sender, EventArgs e)
		{
			List<Order> orders = GetSelectedOrders();
			if (orders.Count != 0) new EditOrderForm(os, orders[0]).ShowDialog();
		}

		private void ImportOrderBtn_Click(object sender, EventArgs e)
		{

		}

		private void ExportOrderBtn_Click(object sender, EventArgs e)
		{

		}
	}
}
