// Напишите программу, которая принимает на вход цифру, обозначающую день недели , и проверяет, является ли этот день выходным

int dayNumber = ReadInt("Введите число от 1 до 7: ");
Console.WriteLine(WorkHoliday(dayNumber));

int ReadInt(string message)
{
 Console.Write(message);
 return Convert.ToInt32(Console.ReadLine());
}

string WorkHoliday(int a)
{
 if (a > 0 && a < 8)
    {
 if (a == 7 || a == 6)
        {
 Console.Write("Тебе повезло, тут " + a + " - Выходной");
        }
 else
        {
 Console.Write("Грустное, сейчас " + a + " - Рабочий");
        }
    }
    else
    {
 Console.Write("Спокойнее, друг, у нас только 7 дней");
    }
 return " день.";
}