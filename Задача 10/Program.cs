// Напишите программу, которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа

Console.Clear();
Console.Write("Введите рандомное число: ");
int n = int.Parse(Console.ReadLine()!);
int n1 = n%100;
int n2 = n1%10;
Console.WriteLine((n1-n2)/10);

