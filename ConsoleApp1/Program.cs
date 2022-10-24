using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// 使用者輸入一個英文句子, 刪除前後空白以及最後句點之後, 用 split 切割成陣列, 並用相反順序呈現內容

			// StartWith 判斷第一個字  EndWith 判斷最後一個字

			Console.Write("請輸入英文句子: ");
			string input = Console.ReadLine();

			// 刪除前後空白
			input = input.Trim();

			// 刪除最後句點
			if (input.EndsWith("."))
			{
				input = input.Substring(' ', input.Length - 1);
			}

			// 用 split 切割成陣列
			string[] words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

			// 用相反順序呈現內容
			for (int i = words.Length - 1; i >= 0; i--)
			{
				Console.WriteLine(words[i]);
			}
		}
	}
}
