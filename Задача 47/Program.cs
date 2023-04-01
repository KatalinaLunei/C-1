// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
double[,] myArr = new double[3, 4];

Random ran = new Random();

for (int m = 0; m < 3; m++)
{
    for (int n = 0; n < 4; n++)
    {
       myArr[m, n] = Math.Round(ran.NextDouble() * (20 - (-20)) + (-20) ,1);
       Console.Write("{0}\t", myArr[m, n]);
    }
    Console.WriteLine();
}