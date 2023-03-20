//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите число: ");
string input = Console.ReadLine();
//int s = int.Parse(input);
int len = input.Length;
int kek;
if (!int.TryParse(input, out kek))
{
    Console.WriteLine("Ах ты ж хитрая жепа, это не так работает");
}
else if(len == 5)
{
    if (input [0] == input [4] && input [1] == input [3])
    {
        Console.WriteLine($"{input} - Мы попали, это палиндром");
    }
    else
    {
        Console.WriteLine($"{input} - Нет, это не палиндром");
    }
}
else
{
    Console.WriteLine($"Неурядица: {input} - не является пятизначным");
}

