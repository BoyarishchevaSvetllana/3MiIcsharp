using System;
using System.IO;

namespace lab2_2
{
	class Program
	{
		public static void Main(string[] args)
		{
			StreamReader f1 = new StreamReader("lab2.txt");
			StreamWriter f2 = new StreamWriter("lab2.res");
      		string[] s = f1.ReadLine().Split();
			f1.Close();
      		
      		int min = int.Parse(s[0]); int max = int.Parse(s[1]);
      		double delta = (Math.Abs(min) + Math.Abs(max)) * 1.0 / 7;
			double x = min;
			
			f2.WriteLine("Таблица значений");
			f2.WriteLine("I---------------------I");
			f2.WriteLine("I    X    I  Функция  I");
			f2.WriteLine("I---------------------I");
			double y;
			while (x <= max) {
				y = (1 - Math.Pow(x, 2)) / (1 + Math.Pow(x, 4));
				f2.WriteLine("I X={0:f3} I Y={1:f3} I", x, y);
				x += delta;
			}
			f2.WriteLine("I---------------------I");
			f2.WriteLine("Составил: Боярищева Светлана Вячеславовна");
			f2.Close();
		}
	}
}