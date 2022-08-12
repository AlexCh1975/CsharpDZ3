/*
    Задача 23
    Напишите программу, которая принимает на вход число 
    (N) и выдаёт таблицу кубов чисел от 1 до N.
    3 -> 1, 8, 27
    5 -> 1, 8, 27, 64, 125
*/

//Console.Clear();

Console.ForegroundColor = ConsoleColor.Blue;
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.ResetColor(); 

Console.ForegroundColor = ConsoleColor.Green;
Console.Write($"| {N}^3 |");
Console.ResetColor(); 

int cubeNumber = 1;
for (int i = 1; i <= N; i++)
{
    cubeNumber = i*i*i;
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write($" {cubeNumber} |"); 
    Console.ResetColor();   
}

Console.WriteLine();
