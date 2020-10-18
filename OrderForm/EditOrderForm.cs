using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OrderForm
{
    public partial class EditOrderForm : Form
	{
		private Order order;
		private OrderService OS;
		private bool createMode;

		public EditOrderForm(OrderService os, Order order = null)
		{
			InitializeComponent();
			OS = os;
			if (order == null)
			{
				createMode = true;
				this.order = new Order();
			}
			else
			{
				createMode = false;
				this.order = order;
			}
			OrderDetailBS.DataSource = this.order.GetDetails();
		}

		private List<OrderDetail> GetSelectedDetails()
		{
			List<OrderDetail> details = new List<OrderDetail>();
			foreach (DataGridViewCell cell in OrderDetailGridView.SelectedCells)
			{
				if (cell.OwningColumn.DataPropertyName == "Name")
				{
					details.Add(order.GetDetailByName((string)cell.Value));
				}
			}
			return details;
		}

		private void AddItemBtn_Click(object sender, EventArgs e)
		{
			EditItemForm form = new EditItemForm(order);
			form.FormClosed += (S, E) => OrderDetailBS.DataSource = order.GetDetails();
			form.ShowDialog();
		}

		private void UpdateItemBtn_Click(object sender, EventArgs e)
		{
			List<OrderDetail> details = GetSelectedDetails();
			if (details.Count == 0)
			{
				MessageBox.Show("未选择任何商品", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			EditItemForm form = new EditItemForm(order, details[0]);
			form.FormClosed += (S, E) => OrderDetailBS.DataSource = order.GetDetails();
			form.ShowDialog();
		}

		private void DeleteItemBtn_Click(object sender, EventArgs e)
		{
			foreach (OrderDetail detail in GetSelectedDetails())
			{
				order.DeleteDetail(detail.Name);
			}
			OrderDetailBS.DataSource = order.GetDetails();
		}

		private void SaveBtn_Click(object sender, EventArgs e)
		{
			if (createMode) OS.CreateOrder(order);
			else OS.UpdateOrder(order);
			Close();
		}

		private void CancelBtn_Click(object sender, EventArgs e) => Close();
	}
}
