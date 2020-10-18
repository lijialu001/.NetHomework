using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorForm
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void calcBtn_Click(object sender, EventArgs e)
		{
			double number1 = 0, number2 = 0;
			if (opBox.SelectedItem == null)
			{
				resultLabel.Text = "未选择运算符！";
				return;
			}
			if (double.TryParse(number1TextBox.Text, out number1) && double.TryParse(number2TextBox.Text, out number2))
			{
				double result = 0;
				switch (opBox.Text)
				{
					case "+": result = number1 + number2; break;
					case "-": result = number1 - number2; break;
					case "*": result = number1 * number2; break;
					case "/": result = number1 / number2; break;
				}
				resultLabel.Text = "计算结果：" + result.ToString();
			}
			else
			{
				resultLabel.Text = "无效数字！";
			}

		}
	}
}
