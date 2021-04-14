using System;

namespace lab3_2
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.Write("Введите координату x = ");
			double x = Convert.ToDouble(Console.ReadLine());
			Console.Write("Введите координату y = ");
			double y = Convert.ToDouble(Console.ReadLine());

			const double R = 12.0;
			
			int N = 4;
			double r = Math.Sqrt(Math.Pow(x, 2) + (Math.Pow(y, 2)));
			if (r < R){
			   	if (x < 0 && y > 0) N = 1;
				else if (x > 0 && y <= 0) N = 3;
					else N = 2;
			}				

			Console.Write("N = {0}", N);
			Console.ReadKey(true);
		}
	}
}