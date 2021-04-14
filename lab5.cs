using System;
using System.IO;

namespace lab5
{
	class Program
	{
		public static void Main(string[] args)
		{
    StreamReader sr = new StreamReader("input.txt");
 
    string[] s = sr.ReadLine().Split();
    sr.Close();

    int[] a = new int[s.Length];
    for (int i = 0; i < a.Length; i++){
    	a[i] = int.Parse(s[i]);
    }
	int ko = 0, kp = 0, sa = 0;
	for (int i = 0; i < a.Length; i++){
		if (a[i] < 0) ko++;
		else if (a[i] > 0) kp++;
		sa += a[i];
	}	

    System.Console.WriteLine("Отрицательных = {0} \t Положительных = {1} \t Среднее = {2}",
							ko, kp, sa / a.Length);
    
 
    System.Console.ReadKey();
		}
	}
}