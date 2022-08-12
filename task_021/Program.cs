/*
    Задача 21
    Напишите программу, которая принимает на вход координаты двух 
    точек и находит расстояние между ними в 3D пространстве.
    A (3,6,8); B (2,1,-7), -> 15.84
    A (7,-5, 0); B (1,-1,9) -> 11.53
*/

//Console.Clear();

Console.Write("Введите х Тоски A: ");
int xa = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите y Тоски A: ");
int ya = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите z Тоски A: ");
int za = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите х Тоски B: ");
int xb = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите y Тоски B: ");
int yb = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите z Тоски B: ");
int zb = Convert.ToInt32(Console.ReadLine());

double result = Math.Sqrt((xb - xa)*(xb - xa) + (yb - ya)*(yb - ya) + (zb - za)*(zb - za)); 
result = Math.Round(result, 2);
Console.WriteLine(result);