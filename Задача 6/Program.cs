// Напишите программу, которая на вход принимает число и выдает,
// является ли число четным (делится ли оно на два без остатка).

Console.Clear();
Console.Write("Введите 1-е число: ");
int n = int.Parse(Console.ReadLine()!);
if (n % 2 == 0 ) Console.WriteLine("да, брат, оно четное");
else Console.WriteLine("нет, брат, оно нам не надо");
