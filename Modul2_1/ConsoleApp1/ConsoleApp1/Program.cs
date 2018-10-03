using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			int num;
			do
			{
				Console.Clear();
				Console.Write("Count objects - ");
			} while (!int.TryParse(Console.ReadLine(), out num));

			for (int i = 1; i <= num; i++)
			{
				Cars.Logic.Car obj1 = (Cars.Logic.Car) menu(i);
				Console.WriteLine(obj1.getinfo(i));

				Console.WriteLine();
			}

			Console.ReadLine();
		}

		static object menu(int num)
		{
			Console.WriteLine($"Create {num} object: ");

			Console.Write($"{num} Input name car, please ");
			string name = Console.ReadLine();

			Console.Write($"{num} Input color car, please ");
			string color = Console.ReadLine();

			double price;
			do
			{
				Console.Write($"{num} Input price car, please ");
			} while (!double.TryParse(Console.ReadLine(), out price));

			Cars.Logic.Car obj = new Cars.Logic.Car(price, color, name);
			return obj;
		}
	}
}
