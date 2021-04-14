using System;

namespace lab3_1
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.Write("Введите x = ");
			double x = Convert.ToDouble(Console.ReadLine());
			Console.Write("Введите y = ");
			double y = Convert.ToDouble(Console.ReadLine());
			Console.Write("Введите z = ");
			double z = Convert.ToDouble(Console.ReadLine());

			double zn = Math.Pow(Math.Max(x, y), 2) - Math.Sin(z);
			if (zn == 0.0){
				Console.WriteLine("Знаменатель равен 0!");
			}
			else{
				double ch = Math.Min(x, y) + 0.5;
				Console.WriteLine("F = {0:f3}", ch / zn);
			}
			
			Console.ReadKey(true);
		}
	}
}