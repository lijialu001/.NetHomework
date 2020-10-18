namespace OrderForm
{
	partial class EditOrderForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.Splitter = new System.Windows.Forms.SplitContainer();
			this.CustomerInfoPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.AddItemBtn = new System.Windows.Forms.Button();
			this.UpdateItemBtn = new System.Windows.Forms.Button();
			this.DeleteItemBtn = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.CustomerNameTxt = new System.Windows.Forms.TextBox();
			this.SaveBtn = new System.Windows.Forms.Button();
			this.CancelBtn = new System.Windows.Forms.Button();
			this.OrderDetailGridView = new System.Windows.Forms.DataGridView();
			this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.countDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.totalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.OrderDetailBS = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.Splitter)).BeginInit();
			this.Splitter.Panel1.SuspendLayout();
			this.Splitter.Panel2.SuspendLayout();
			this.Splitter.SuspendLayout();
			this.CustomerInfoPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.OrderDetailGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.OrderDetailBS)).BeginInit();
			this.SuspendLayout();
			// 
			// Splitter
			// 
			this.Splitter.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Splitter.Location = new System.Drawing.Point(0, 0);
			this.Splitter.Name = "Splitter";
			this.Splitter.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// Splitter.Panel1
			// 
			this.Splitter.Panel1.Controls.Add(this.CustomerInfoPanel);
			// 
			// Splitter.Panel2
			// 
			this.Splitter.Panel2.Controls.Add(this.OrderDetailGridView);
			this.Splitter.Size = new System.Drawing.Size(800, 450);
			this.Splitter.SplitterDistance = 40;
			this.Splitter.TabIndex = 3;
			// 
			// CustomerInfoPanel
			// 
			this.CustomerInfoPanel.Controls.Add(this.AddItemBtn);
			this.CustomerInfoPanel.Controls.Add(this.UpdateItemBtn);
			this.CustomerInfoPanel.Controls.Add(this.DeleteItemBtn);
			this.CustomerInfoPanel.Controls.Add(this.label1);
			this.CustomerInfoPanel.Controls.Add(this.CustomerNameTxt);
			this.CustomerInfoPanel.Controls.Add(this.SaveBtn);
			this.CustomerInfoPanel.Controls.Add(this.CancelBtn);
			this.CustomerInfoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.CustomerInfoPanel.Location = new System.Drawing.Point(0, 0);
			this.CustomerInfoPanel.Name = "CustomerInfoPanel";
			this.CustomerInfoPanel.Size = new System.Drawing.Size(800, 40);
			this.CustomerInfoPanel.TabIndex = 2;
			// 
			// AddItemBtn
			// 
			this.AddItemBtn.Location = new System.Drawing.Point(3, 3);
			this.AddItemBtn.Name = "AddItemBtn";
			this.AddItemBtn.Size = new System.Drawing.Size(90, 30);
			this.AddItemBtn.TabIndex = 2;
			this.AddItemBtn.Text = "添加商品";
			this.AddItemBtn.UseVisualStyleBackColor = true;
			this.AddItemBtn.Click += new System.EventHandler(this.AddItemBtn_Click);
			// 
			// UpdateItemBtn
			// 
			this.UpdateItemBtn.Location = new System.Drawing.Point(99, 3);
			this.UpdateItemBtn.Name = "UpdateItemBtn";
			this.UpdateItemBtn.Size = new System.Drawing.Size(90, 30);
			this.UpdateItemBtn.TabIndex = 2;
			this.UpdateItemBtn.Text = "修改商品";
			this.UpdateItemBtn.UseVisualStyleBackColor = true;
			this.UpdateItemBtn.Click += new System.EventHandler(this.UpdateItemBtn_Click);
			// 
			// DeleteItemBtn
			// 
			this.DeleteItemBtn.Location = new System.Drawing.Point(195, 3);
			this.DeleteItemBtn.Name = "DeleteItemBtn";
			this.DeleteItemBtn.Size = new System.Drawing.Size(90, 30);
			this.DeleteItemBtn.TabIndex = 2;
			this.DeleteItemBtn.Text = "删除商品";
			this.DeleteItemBtn.UseVisualStyleBackColor = true;
			this.DeleteItemBtn.Click += new System.EventHandler(this.DeleteItemBtn_Click);
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(291, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(67, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "客户名称";
			// 
			// CustomerNameTxt
			// 
			this.CustomerNameTxt.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.CustomerNameTxt.Location = new System.Drawing.Point(364, 5);
			this.CustomerNameTxt.Name = "CustomerNameTxt";
			this.CustomerNameTxt.Size = new System.Drawing.Size(166, 25);
			this.CustomerNameTxt.TabIndex = 1;
			// 
			// SaveBtn
			// 
			this.SaveBtn.Location = new System.Drawing.Point(536, 3);
			this.SaveBtn.Name = "SaveBtn";
			this.SaveBtn.Size = new System.Drawing.Size(60, 30);
			this.SaveBtn.TabIndex = 2;
			this.SaveBtn.Text = "保存";
			this.SaveBtn.UseVisualStyleBackColor = true;
			this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
			// 
			// CancelBtn
			// 
			this.CancelBtn.Location = new System.Drawing.Point(602, 3);
			this.CancelBtn.Name = "CancelBtn";
			this.CancelBtn.Size = new System.Drawing.Size(60, 30);
			this.CancelBtn.TabIndex = 2;
			this.CancelBtn.Text = "取消";
			this.CancelBtn.UseVisualStyleBackColor = true;
			this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
			// 
			// OrderDetailGridView
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
			this.totalPriceDataGridViewTextBoxColumn});
			this.OrderDetailGridView.DataSource = this.OrderDetailBS;
			this.OrderDetailGridView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.OrderDetailGridView.Location = new System.Drawing.Point(0, 0);
			this.OrderDetailGridView.Name = "OrderDetailGridView";
			this.OrderDetailGridView.ReadOnly = true;
			this.OrderDetailGridView.RowTemplate.Height = 27;
			this.OrderDetailGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.OrderDetailGridView.Size = new System.Drawing.Size(800, 406);
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
			// totalPriceDataGridViewTextBoxColumn
			// 
			this.totalPriceDataGridViewTextBoxColumn.DataPropertyName = "TotalPrice";
			this.totalPriceDataGridViewTextBoxColumn.HeaderText = "总价";
			this.totalPriceDataGridViewTextBoxColumn.Name = "totalPriceDataGridViewTextBoxColumn";
			this.totalPriceDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// OrderDetailBS
			// 
			this.OrderDetailBS.DataSource = typeof(OrderDetail);
			// 
			// EditOrderForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.Splitter);
			this.Name = "EditOrderForm";
			this.Text = "EditOrder";
			this.Splitter.Panel1.ResumeLayout(false);
			this.Splitter.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.Splitter)).EndInit();
			this.Splitter.ResumeLayout(false);
			this.CustomerInfoPanel.ResumeLayout(false);
			this.CustomerInfoPanel.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.OrderDetailGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.OrderDetailBS)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.SplitContainer Splitter;
		private System.Windows.Forms.FlowLayoutPanel CustomerInfoPanel;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox CustomerNameTxt;
		private System.Windows.Forms.DataGridView OrderDetailGridView;
		private System.Windows.Forms.BindingSource OrderDetailBS;
		private System.Windows.Forms.Button AddItemBtn;
		private System.Windows.Forms.Button DeleteItemBtn;
		private System.Windows.Forms.Button SaveBtn;
		private System.Windows.Forms.Button CancelBtn;
		private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn countDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
		private System.Windows.Forms.Button UpdateItemBtn;
	}
}