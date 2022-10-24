using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var result = new MathUtil().MultiplyTable();
			Console.WriteLine(result);

		}
	}
	class MathUtil
	{
		public string MultiplyTable()
		{
			string tables = string.Empty; 
			for (int i = 1; i < 10; i++)
			{
				tables += GenerateSingleTable(i);
			}
			return tables;
		}
		private string GenerateSingleTable(int firstNumber)
		{
			string table = string.Empty;
			for (int secondNumber = 1; secondNumber < 10; secondNumber++)
			{
				string row = $"{firstNumber} * {secondNumber} = {firstNumber * secondNumber}\n";
				int row1 = firstNumber * secondNumber;
				table += row;
			}
			return table + "\r\n";
		}
	}
}
