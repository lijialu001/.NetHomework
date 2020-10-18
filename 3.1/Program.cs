using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._1
{
    class Program
    {
		static void Main(string[] args)
		{
			OrderService os = new OrderService();
			int op;
			do
			{
				ConsoleInterface.ClearScreen();
				ConsoleInterface.ShowMenu();
				op = ConsoleInterface.ReadInt(1, 5);
				switch (op)
				{
					case 1: ConsoleInterface.AddOrder(os); break;
					case 2: ConsoleInterface.UpdateOrder(os, ConsoleInterface.SelectOrder(os)); break;
					case 3: ConsoleInterface.ImportOS(os); break;
					case 4: ConsoleInterface.ExportOS(os); break;
				}
			}
			while (op < 5);
		}
	}
}
