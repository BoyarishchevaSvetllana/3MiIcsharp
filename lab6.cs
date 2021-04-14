using System;
using System.IO;

namespace lab6
{
	class Program
	{
		public static void Main(string[] args)
		{
    StreamReader sr = new StreamReader("input.txt");

    int[,] a = new int[5, 6];
    int sum = 0;
    for (int i = 0; i < 5; i++){
      	string[] s = sr.ReadLine().Split();
    	for (int j = 0; j < 6; j++) {
   			a[i, j] = int.Parse(s[j]);
   		sum += a[i, j];
    	}
    }
    sr.Close();

    System.Console.WriteLine("Сумма = {0}", sum);
    System.Console.ReadKey();
		}
	}
}