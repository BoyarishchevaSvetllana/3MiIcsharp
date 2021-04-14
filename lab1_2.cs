using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace lab0
{
class Program
{
static void Main(string[] args)
{
Console.Write("Input x = ");
double x = Convert.ToDouble(Console.ReadLine());

double y = Math.Sqrt(Math.Log((4 / 3) + x) + (9 / 7)) - Math.Exp(-(Math.Sin(1.3 * x - 0.7)));
Console.WriteLine(" x = {0} \t y = {1}", x, y);

y = Math.Sqrt(Math.Log((4 / 3) + x) + (9 / 7)) - Math.Pow(Math.E,-(Math.Sin(1.3 * x - 0.7)));
Console.WriteLine(" x = {0} \t y = {1}", x, y);
Console.ReadKey();
}
}
}