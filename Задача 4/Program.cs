// Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел.

Console.Clear();
Console.Write("Введите 1-е число: ");
int n = int.Parse(Console.ReadLine()!);
Console.Write("Введите 2-е число: ");
int m = int.Parse(Console.ReadLine()!);
Console.Write("Введите 3-е число: ");
int x = int.Parse(Console.ReadLine()!);
int max = n;
if( m > max) max = m;
if( x > max) max = x;
Console.WriteLine("max = " + max);