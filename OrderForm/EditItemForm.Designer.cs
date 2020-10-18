namespace OrderForm
{
	partial class EditItemForm
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
			this.NameTxt = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
			this.label2 = new System.Windows.Forms.Label();
			this.PriceTxt = new System.Windows.Forms.TextBox();
			this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
			this.label3 = new System.Windows.Forms.Label();
			this.CountTxt = new System.Windows.Forms.TextBox();
			this.ConfirmBtn = new System.Windows.Forms.Button();
			this.CancelBtn = new System.Windows.Forms.Button();
			this.flowLayoutPanel1.SuspendLayout();
			this.flowLayoutPanel2.SuspendLayout();
			this.flowLayoutPanel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// NameTxt
			// 
			this.NameTxt.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.NameTxt.Location = new System.Drawing.Point(46, 3);
			this.NameTxt.Name = "NameTxt";
			this.NameTxt.Size = new System.Drawing.Size(175, 25);
			this.NameTxt.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(37, 15);
			this.label1.TabIndex = 1;
			this.label1.Text = "品名";
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Controls.Add(this.label1);
			this.flowLayoutPanel1.Controls.Add(this.NameTxt);
			this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(233, 33);
			this.flowLayoutPanel1.TabIndex = 2;
			// 
			// flowLayoutPanel2
			// 
			this.flowLayoutPanel2.Controls.Add(this.label2);
			this.flowLayoutPanel2.Controls.Add(this.PriceTxt);
			this.flowLayoutPanel2.Location = new System.Drawing.Point(12, 51);
			this.flowLayoutPanel2.Name = "flowLayoutPanel2";
			this.flowLayoutPanel2.Size = new System.Drawing.Size(233, 33);
			this.flowLayoutPanel2.TabIndex = 2;
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(3, 8);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(37, 15);
			this.label2.TabIndex = 1;
			this.label2.Text = "单价";
			// 
			// PriceTxt
			// 
			this.PriceTxt.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.PriceTxt.Location = new System.Drawing.Point(46, 3);
			this.PriceTxt.Name = "PriceTxt";
			this.PriceTxt.Size = new System.Drawing.Size(175, 25);
			this.PriceTxt.TabIndex = 2;
			// 
			// flowLayoutPanel3
			// 
			this.flowLayoutPanel3.Controls.Add(this.label3);
			this.flowLayoutPanel3.Controls.Add(this.CountTxt);
			this.flowLayoutPanel3.Location = new System.Drawing.Point(12, 90);
			this.flowLayoutPanel3.Name = "flowLayoutPanel3";
			this.flowLayoutPanel3.Size = new System.Drawing.Size(233, 33);
			this.flowLayoutPanel3.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(3, 8);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(37, 15);
			this.label3.TabIndex = 1;
			this.label3.Text = "数量";
			// 
			// CountTxt
			// 
			this.CountTxt.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.CountTxt.Location = new System.Drawing.Point(46, 3);
			this.CountTxt.Name = "CountTxt";
			this.CountTxt.Size = new System.Drawing.Size(175, 25);
			this.CountTxt.TabIndex = 2;
			// 
			// ConfirmBtn
			// 
			this.ConfirmBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.ConfirmBtn.Location = new System.Drawing.Point(59, 129);
			this.ConfirmBtn.Name = "ConfirmBtn";
			this.ConfirmBtn.Size = new System.Drawing.Size(90, 30);
			this.ConfirmBtn.TabIndex = 3;
			this.ConfirmBtn.Text = "确定";
			this.ConfirmBtn.UseVisualStyleBackColor = true;
			this.ConfirmBtn.Click += new System.EventHandler(this.ConfirmBtn_Click);
			// 
			// CancelBtn
			// 
			this.CancelBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.CancelBtn.Location = new System.Drawing.Point(155, 129);
			this.CancelBtn.Name = "CancelBtn";
			this.CancelBtn.Size = new System.Drawing.Size(90, 30);
			this.CancelBtn.TabIndex = 3;
			this.CancelBtn.Text = "取消";
			this.CancelBtn.UseVisualStyleBackColor = true;
			this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
			// 
			// EditItemForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(257, 166);
			this.Controls.Add(this.CancelBtn);
			this.Controls.Add(this.ConfirmBtn);
			this.Controls.Add(this.flowLayoutPanel3);
			this.Controls.Add(this.flowLayoutPanel2);
			this.Controls.Add(this.flowLayoutPanel1);
			this.Name = "EditItemForm";
			this.Text = "商品编辑";
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			this.flowLayoutPanel2.ResumeLayout(false);
			this.flowLayoutPanel2.PerformLayout();
			this.flowLayoutPanel3.ResumeLayout(false);
			this.flowLayoutPanel3.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TextBox NameTxt;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox PriceTxt;
		private System.Windows.Forms.TextBox CountTxt;
		private System.Windows.Forms.Button ConfirmBtn;
		private System.Windows.Forms.Button CancelBtn;
	}
}