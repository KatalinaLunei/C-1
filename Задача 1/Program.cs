// Напишите программу, которая 
//на вход принимает два числа и выдает, 
// какое число большее, какое меньшее

Console.Clear();
Console.Write("Введите 1-е число: ");
int n = int.Parse(Console.ReadLine()!);
Console.Write("Введите 2-е число: ");
int m = int.Parse(Console.ReadLine()!);
int max = m > n ? m : n;
int min = m < n ? m : n;
Console.WriteLine("max = " + max);
Console.WriteLine("min = " + min);
