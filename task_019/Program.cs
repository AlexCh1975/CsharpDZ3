/*
    Задача 19
    Напишите программу, которая принимает на вход пятизначное 
    число и проверяет, является ли оно палиндромом.
    14212 -> нет
    12821 -> да
    23432 -> да
*/

//Console.Clear();

Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int five_digitNumber = DeterminesWhatNumber(number);
if (five_digitNumber == -1)
{
   PrintResult(five_digitNumber); 
}
else 
{
    int result = IsPalindromeNumber(five_digitNumber);
    PrintResult(result);
}

// Проверяем пятизначное число или нет.
int DeterminesWhatNumber(int number)
{ 
   if (number > 100000)
   {
        return -1;
   }
   else if (number < 10000)
   {
        return -1;
   }
   else
   {
        return number;
   }
}

// Проверка является ли число палиндромом
int IsPalindromeNumber(int number)
{
    int num = number / 100;
    int number1 = num / 10; 
    int number2 = number - (num * 100); 

    int number1_revers = ReversNumber(number1);

    // Переворачиваем первую часть числа
    int ReversNumber(int number)
    {   
        int result = 0; 
        int num = number % 10; 
        number = number / 10; 
        result += number + num * 10;
        return result; 
    }

    if (number1_revers == number2)
    {
        return 1;
    }
    else
    {
        return 0;
    }
}

// Вывод результата
void PrintResult(int result)
{
    if (result == -1)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"Ошибка!!! Вы ввели не пятизначное число!");
        Console.ResetColor();
    }
    else if (result == 1)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"Число {number} -> 'ДА' является палиндромом!");
        Console.ResetColor();
    }
    else if (result == 0)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"Число {number} -> 'Нет' не является палиндромом!");
        Console.ResetColor();
    }
}


