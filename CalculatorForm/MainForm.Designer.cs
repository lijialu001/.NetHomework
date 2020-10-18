namespace CalculatorForm
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
			this.opBox = new System.Windows.Forms.ComboBox();
			this.number2TextBox = new System.Windows.Forms.TextBox();
			this.number1TextBox = new System.Windows.Forms.TextBox();
			this.resultLabel = new System.Windows.Forms.Label();
			this.calcBtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// opBox
			// 
			this.opBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.opBox.FormattingEnabled = true;
			this.opBox.Items.AddRange(new object[] {
			"+",
			"-",
			"*",
			"/"});
			this.opBox.Location = new System.Drawing.Point(168, 12);
			this.opBox.Name = "opBox";
			this.opBox.Size = new System.Drawing.Size(43, 23);
			this.opBox.TabIndex = 0;
			// 
			// number2TextBox
			// 
			this.number2TextBox.Location = new System.Drawing.Point(217, 12);
			this.number2TextBox.Name = "number2TextBox";
			this.number2TextBox.Size = new System.Drawing.Size(150, 25);
			this.number2TextBox.TabIndex = 1;
			// 
			// number1TextBox
			// 
			this.number1TextBox.Location = new System.Drawing.Point(12, 12);
			this.number1TextBox.Name = "number1TextBox";
			this.number1TextBox.Size = new System.Drawing.Size(150, 25);
			this.number1TextBox.TabIndex = 1;
			// 
			// resultLabel
			// 
			this.resultLabel.AutoSize = true;
			this.resultLabel.Font = new System.Drawing.Font("宋体", 9F);
			this.resultLabel.Location = new System.Drawing.Point(12, 47);
			this.resultLabel.Name = "resultLabel";
			this.resultLabel.Size = new System.Drawing.Size(82, 15);
			this.resultLabel.TabIndex = 2;
			this.resultLabel.Text = "计算结果：";
			// 
			// calcBtn
			// 
			this.calcBtn.Location = new System.Drawing.Point(291, 43);
			this.calcBtn.Name = "calcBtn";
			this.calcBtn.Size = new System.Drawing.Size(75, 23);
			this.calcBtn.TabIndex = 3;
			this.calcBtn.Text = "计算";
			this.calcBtn.UseVisualStyleBackColor = true;
			this.calcBtn.Click += new System.EventHandler(this.calcBtn_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(378, 76);
			this.Controls.Add(this.calcBtn);
			this.Controls.Add(this.resultLabel);
			this.Controls.Add(this.number1TextBox);
			this.Controls.Add(this.number2TextBox);
			this.Controls.Add(this.opBox);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox opBox;
		private System.Windows.Forms.TextBox number2TextBox;
		private System.Windows.Forms.TextBox number1TextBox;
		private System.Windows.Forms.Label resultLabel;
		private System.Windows.Forms.Button calcBtn;
	}
}

