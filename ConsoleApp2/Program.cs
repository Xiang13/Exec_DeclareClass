using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
	internal class Program
	{


		static void Main(string[] args)
		{
			string input = GetInput();

			input = PostProcess(input);

			string[] words = SplitInput(input);

			DisplayWords(words);
		}

		// 使用者輸入一個英文句子
		public static string GetInput()
		{
			Console.Write("請輸入英文句子: ");
			return Console.ReadLine(); ;
		}
		// 刪除前後空白以及最後句點
		public static string PostProcess(string value)
		{
			value = value.Trim();
			if (value.EndsWith("."))
			{
				value = value.Substring(0, value.Length - 1);
			}
			return value;
		}
		// 用 split 切割成陣列
		public static string[] SplitInput(string value)
		{
			string[] words = value.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
			return words;
		}
		// 並用相反順序呈現內容
		public static void DisplayWords(string[] items)
		{
			for(int i = items.Length - 1; i >= 0; i--)
			{
				Console.WriteLine(items[i]);
			}
		}
	}
}
