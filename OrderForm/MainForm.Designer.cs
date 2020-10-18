namespace OrderForm
{
	partial class MainForm
	{
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要修改
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.HorizontalSpliter = new System.Windows.Forms.SplitContainer();
			this.BtnPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.CreateOrderBtn = new System.Windows.Forms.Button();
			this.DeleteOrderBtn = new System.Windows.Forms.Button();
			this.UpdateOrderBtn = new System.Windows.Forms.Button();
			this.ImportOrderBtn = new System.Windows.Forms.Button();
			this.ExportOrderBtn = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SortCriteriaComboBox = new System.Windows.Forms.ComboBox();
			this.ReverseCheckBox = new System.Windows.Forms.CheckBox();
			this.button6 = new System.Windows.Forms.Button();
			this.VerticalSplitter = new System.Windows.Forms.SplitContainer();
			this.OrderGridView = new System.Windows.Forms.DataGridView();
			this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.customerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.totalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.OrderBS = new System.Windows.Forms.BindingSource(this.components);
			this.OrderDetailGridView = new System.Windows.Forms.DataGridView();
			this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.countDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.totalPriceDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.OrderDetailBS = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.HorizontalSpliter)).BeginInit();
			this.HorizontalSpliter.Panel1.SuspendLayout();
			this.HorizontalSpliter.Panel2.SuspendLayout();
			this.HorizontalSpliter.SuspendLayout();
			this.BtnPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.VerticalSplitter)).BeginInit();
			this.VerticalSplitter.Panel1.SuspendLayout();
			this.VerticalSplitter.Panel2.SuspendLayout();
			this.VerticalSplitter.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.OrderGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.OrderBS)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.OrderDetailGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.OrderDetailBS)).BeginInit();
			this.SuspendLayout();
			// 
			// HorizontalSpliter
			// 
			this.HorizontalSpliter.Dock = System.Windows.Forms.DockStyle.Fill;
			this.HorizontalSpliter.Location = new System.Drawing.Point(0, 0);
			this.HorizontalSpliter.Name = "HorizontalSpliter";
			this.HorizontalSpliter.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// HorizontalSpliter.Panel1
			// 
			this.HorizontalSpliter.Panel1.Controls.Add(this.BtnPanel);
			// 
			// HorizontalSpliter.Panel2
			// 
			this.HorizontalSpliter.Panel2.Controls.Add(this.VerticalSplitter);
			this.HorizontalSpliter.Size = new System.Drawing.Size(862, 450);
			this.HorizontalSpliter.SplitterDistance = 40;
			this.HorizontalSpliter.TabIndex = 0;
			// 
			// BtnPanel
			// 
			this.BtnPanel.Controls.Add(this.CreateOrderBtn);
			this.BtnPanel.Controls.Add(this.DeleteOrderBtn);
			this.BtnPanel.Controls.Add(this.UpdateOrderBtn);
			this.BtnPanel.Controls.Add(this.ImportOrderBtn);
			this.BtnPanel.Controls.Add(this.ExportOrderBtn);
			this.BtnPanel.Controls.Add(this.label1);
			this.BtnPanel.Controls.Add(this.SortCriteriaComboBox);
			this.BtnPanel.Controls.Add(this.ReverseCheckBox);
			this.BtnPanel.Controls.Add(this.button6);
			this.BtnPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.BtnPanel.Location = new System.Drawing.Point(0, 0);
			this.BtnPanel.Name = "BtnPanel";
			this.BtnPanel.Size = new System.Drawing.Size(862, 40);
			this.BtnPanel.TabIndex = 0;
			// 
			// CreateOrderBtn
			// 
			this.CreateOrderBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.CreateOrderBtn.Location = new System.Drawing.Point(3, 3);
			this.CreateOrderBtn.Name = "CreateOrderBtn";
			this.CreateOrderBtn.Size = new System.Drawing.Size(90, 30);
			this.CreateOrderBtn.TabIndex = 0;
			this.CreateOrderBtn.Text = "添加订单";
			this.CreateOrderBtn.UseVisualStyleBackColor = true;
			this.CreateOrderBtn.Click += new System.EventHandler(this.AddOrderBtn_Click);
			// 
			// DeleteOrderBtn
			// 
			this.DeleteOrderBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.DeleteOrderBtn.Location = new System.Drawing.Point(99, 3);
			this.DeleteOrderBtn.Name = "DeleteOrderBtn";
			this.DeleteOrderBtn.Size = new System.Drawing.Size(90, 30);
			this.DeleteOrderBtn.TabIndex = 1;
			this.DeleteOrderBtn.Text = "删除订单";
			this.DeleteOrderBtn.UseVisualStyleBackColor = true;
			this.DeleteOrderBtn.Click += new System.EventHandler(this.DeleteOrderBtn_Click);
			// 
			// UpdateOrderBtn
			// 
			this.UpdateOrderBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.UpdateOrderBtn.Location = new System.Drawing.Point(195, 3);
			this.UpdateOrderBtn.Name = "UpdateOrderBtn";
			this.UpdateOrderBtn.Size = new System.Drawing.Size(90, 30);
			this.UpdateOrderBtn.TabIndex = 2;
			this.UpdateOrderBtn.Text = "修改订单";
			this.UpdateOrderBtn.UseVisualStyleBackColor = true;
			this.UpdateOrderBtn.Click += new System.EventHandler(this.UpdateOrderBtn_Click);
			// 
			// ImportOrderBtn
			// 
			this.ImportOrderBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.ImportOrderBtn.Location = new System.Drawing.Point(291, 3);
			this.ImportOrderBtn.Name = "ImportOrderBtn";
			this.ImportOrderBtn.Size = new System.Drawing.Size(90, 30);
			this.ImportOrderBtn.TabIndex = 3;
			this.ImportOrderBtn.Text = "导入订单";
			this.ImportOrderBtn.UseVisualStyleBackColor = true;
			this.ImportOrderBtn.Click += new System.EventHandler(this.ImportOrderBtn_Click);
			// 
			// ExportOrderBtn
			// 
			this.ExportOrderBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.ExportOrderBtn.Location = new System.Drawing.Point(387, 3);
			this.ExportOrderBtn.Name = "ExportOrderBtn";
			this.ExportOrderBtn.Size = new System.Drawing.Size(90, 30);
			this.ExportOrderBtn.TabIndex = 4;
			this.ExportOrderBtn.Text = "导出订单";
			this.ExportOrderBtn.UseVisualStyleBackColor = true;
			this.ExportOrderBtn.Click += new System.EventHandler(this.ExportOrderBtn_Click);
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(483, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(67, 15);
			this.label1.TabIndex = 7;
			this.label1.Text = "排序方式";
			// 
			// SortCriteriaComboBox
			// 
			this.SortCriteriaComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.SortCriteriaComboBox.FormattingEnabled = true;
			this.SortCriteriaComboBox.Location = new System.Drawing.Point(556, 6);
			this.SortCriteriaComboBox.Name = "SortCriteriaComboBox";
			this.SortCriteriaComboBox.Size = new System.Drawing.Size(121, 23);
			this.SortCriteriaComboBox.TabIndex = 6;
			// 
			// ReverseCheckBox
			// 
			this.ReverseCheckBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.ReverseCheckBox.AutoSize = true;
			this.ReverseCheckBox.Location = new System.Drawing.Point(683, 8);
			this.ReverseCheckBox.Name = "ReverseCheckBox";
			this.ReverseCheckBox.Size = new System.Drawing.Size(59, 19);
			this.ReverseCheckBox.TabIndex = 8;
			this.ReverseCheckBox.Text = "逆序";
			this.ReverseCheckBox.UseVisualStyleBackColor = true;
			// 
			// button6
			// 
			this.button6.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.button6.Location = new System.Drawing.Point(748, 3);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(90, 30);
			this.button6.TabIndex = 5;
			this.button6.Text = "查询条件";
			this.button6.UseVisualStyleBackColor = true;
			// 
			// VerticalSplitter
			// 
			this.VerticalSplitter.Dock = System.Windows.Forms.DockStyle.Fill;
			this.VerticalSplitter.Location = new System.Drawing.Point(0, 0);
			this.VerticalSplitter.Name = "VerticalSplitter";
			// 
			// VerticalSplitter.Panel1
			// 
			this.VerticalSplitter.Panel1.Controls.Add(this.OrderGridView);
			// 
			// VerticalSplitter.Panel2
			// 
			this.VerticalSplitter.Panel2.Controls.Add(this.OrderDetailGridView);
			this.VerticalSplitter.Size = new System.Drawing.Size(862, 406);
			this.VerticalSplitter.SplitterDistance = 449;
			this.VerticalSplitter.TabIndex = 0;
			// 
			// OrderGridView
			// 
			this.OrderGridView.AllowUserToAddRows = false;
			this.OrderGridView.AllowUserToDeleteRows = false;
			this.OrderGridView.AllowUserToResizeRows = false;
			this.OrderGridView.AutoGenerateColumns = false;
			this.OrderGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.OrderGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.iDDataGridViewTextBoxColumn,
			this.customerNameDataGridViewTextBoxColumn,
			this.totalPriceDataGridViewTextBoxColumn});
			this.OrderGridView.DataSource = this.OrderBS;
			this.OrderGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.OrderGridView.Location = new System.Drawing.Point(0, 0);
			this.OrderGridView.Name = "OrderGridView";
			this.OrderGridView.ReadOnly = true;
			this.OrderGridView.RowTemplate.Height = 27;
			this.OrderGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.OrderGridView.Size = new System.Drawing.Size(449, 406);
			this.OrderGridView.TabIndex = 0;
			// 
			// iDDataGridViewTextBoxColumn
			// 
			this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
			this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
			this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
			this.iDDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// customerNameDataGridViewTextBoxColumn
			// 
			this.customerNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerName";
			this.customerNameDataGridViewTextBoxColumn.HeaderText = "客户名";
			this.customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
			this.customerNameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// totalPriceDataGridViewTextBoxColumn
			// 
			this.totalPriceDataGridViewTextBoxColumn.DataPropertyName = "TotalPrice";
			this.totalPriceDataGridViewTextBoxColumn.HeaderText = "总价格";
			this.totalPriceDataGridViewTextBoxColumn.Name = "totalPriceDataGridViewTextBoxColumn";
			this.totalPriceDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// OrderBS
			// 
			this.OrderBS.DataSource = typeof(Order);
			// 
			// DetailGridView
			// 
			this.OrderDetailGridView.AllowUserToAddRows = false;
			this.OrderDetailGridView.AllowUserToDeleteRows = false;
			this.OrderDetailGridView.AllowUserToResizeRows = false;
			this.OrderDetailGridView.AutoGenerateColumns = false;
			this.OrderDetailGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.OrderDetailGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.nameDataGridViewTextBoxColumn,
			this.priceDataGridViewTextBoxColumn,
			this.countDataGridViewTextBoxColumn,
			this.totalPriceDataGridViewTextBoxColumn1});
			this.OrderDetailGridView.DataSource = this.OrderDetailBS;
			this.OrderDetailGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.OrderDetailGridView.Location = new System.Drawing.Point(0, 0);
			this.OrderDetailGridView.Name = "DetailGridView";
			this.OrderDetailGridView.ReadOnly = true;
			this.OrderDetailGridView.RowTemplate.Height = 27;
			this.OrderDetailGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.OrderDetailGridView.Size = new System.Drawing.Size(409, 406);
			this.OrderDetailGridView.TabIndex = 0;
			// 
			// nameDataGridViewTextBoxColumn
			// 
			this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
			this.nameDataGridViewTextBoxColumn.HeaderText = "品名";
			this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
			this.nameDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// priceDataGridViewTextBoxColumn
			// 
			this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
			this.priceDataGridViewTextBoxColumn.HeaderText = "价格";
			this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
			this.priceDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// countDataGridViewTextBoxColumn
			// 
			this.countDataGridViewTextBoxColumn.DataPropertyName = "Count";
			this.countDataGridViewTextBoxColumn.HeaderText = "数量";
			this.countDataGridViewTextBoxColumn.Name = "countDataGridViewTextBoxColumn";
			this.countDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// totalPriceDataGridViewTextBoxColumn1
			// 
			this.totalPriceDataGridViewTextBoxColumn1.DataPropertyName = "TotalPrice";
			this.totalPriceDataGridViewTextBoxColumn1.HeaderText = "总价";
			this.totalPriceDataGridViewTextBoxColumn1.Name = "totalPriceDataGridViewTextBoxColumn1";
			this.totalPriceDataGridViewTextBoxColumn1.ReadOnly = true;
			// 
			// OrderDetailBS
			// 
			this.OrderDetailBS.DataSource = typeof(OrderDetail);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(862, 450);
			this.Controls.Add(this.HorizontalSpliter);
			this.MinimumSize = new System.Drawing.Size(880, 47);
			this.Name = "MainForm";
			this.Text = "Form1";
			this.HorizontalSpliter.Panel1.ResumeLayout(false);
			this.HorizontalSpliter.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.HorizontalSpliter)).EndInit();
			this.HorizontalSpliter.ResumeLayout(false);
			this.BtnPanel.ResumeLayout(false);
			this.BtnPanel.PerformLayout();
			this.VerticalSplitter.Panel1.ResumeLayout(false);
			this.VerticalSplitter.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.VerticalSplitter)).EndInit();
			this.VerticalSplitter.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.OrderGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.OrderBS)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.OrderDetailGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.OrderDetailBS)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.BindingSource OrderBS;
		private System.Windows.Forms.BindingSource OrderDetailBS;
		private System.Windows.Forms.SplitContainer HorizontalSpliter;
		private System.Windows.Forms.FlowLayoutPanel BtnPanel;
		private System.Windows.Forms.Button CreateOrderBtn;
		private System.Windows.Forms.Button DeleteOrderBtn;
		private System.Windows.Forms.Button UpdateOrderBtn;
		private System.Windows.Forms.Button ImportOrderBtn;
		private System.Windows.Forms.Button ExportOrderBtn;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox SortCriteriaComboBox;
		private System.Windows.Forms.CheckBox ReverseCheckBox;
		private System.Windows.Forms.SplitContainer VerticalSplitter;
		private System.Windows.Forms.DataGridView OrderGridView;
		private System.Windows.Forms.DataGridView OrderDetailGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn1;

	}
}

