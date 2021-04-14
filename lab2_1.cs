using System;

namespace lab2_1
{
	class Program
	{
		public static void Main(string[] args)
		{
			int a;
			double i;
			float c;
			bool l;
			string n;
			Console.WriteLine("Input a");
			a = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Input i");
			i = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Input c");
			c = Convert.ToSingle(Console.ReadLine());
			Console.WriteLine("Input l");
			l = Convert.ToBoolean(Console.ReadLine());
			Console.WriteLine("Input n");
			n = Console.ReadLine();
			System.Console.WriteLine("a ={0, 4}, i = {1,20:e8}, c = {2,10:f5} l = {3, 4}, name = {4, 6}", a,i,c,l,n);
			System.Console.ReadLine();		
		}
	}
}