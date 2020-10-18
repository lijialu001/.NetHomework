using System;
using System.Windows.Forms;

namespace OrderForm
{
    public partial class EditItemForm : Form
	{
		private Order order;
		private OrderDetail detail;
		private string originalName = null;

		public EditItemForm(Order order, OrderDetail detail = null)
		{
			InitializeComponent();
			this.order = order;
			if (detail == null)
			{
				this.detail = new OrderDetail();
			}
			else
			{
				this.detail = detail;
				originalName = detail.Name;
			}
			NameTxt.DataBindings.Add("Text", this.detail, "Name", false, DataSourceUpdateMode.OnPropertyChanged);
			CountTxt.DataBindings.Add("Text", this.detail, "Count", false, DataSourceUpdateMode.OnPropertyChanged);
			PriceTxt.DataBindings.Add("Text", this.detail, "Price", false, DataSourceUpdateMode.OnPropertyChanged);
		}

		private void ConfirmBtn_Click(object sender, EventArgs e)
		{
			if (detail.Name == "")
			{
				MessageBox.Show("商品名不可为空！", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			if (originalName == null) order.AddItem(detail);
			else order.UpdateDetail(detail, originalName);
			Close();
		}

		private void CancelBtn_Click(object sender, EventArgs e) => Close();
	}
}
