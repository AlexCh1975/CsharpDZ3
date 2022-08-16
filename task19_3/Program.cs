/*
    Задача 19
    Напишите программу, которая принимает на вход пятизначное 
    число и проверяет, является ли оно палиндромом.
    14212 -> нет
    12821 -> да
    23432 -> да

    !!! Попробовал реализовать задачу так, чтобы можно было проверять любые числа.
    Оптимизация task 019!
*/

Console.Clear();

Console.Write("Введите число в диапазоне Int32: ");
Console.ForegroundColor = ConsoleColor.Yellow;
int number = Convert.ToInt32(Console.ReadLine());
Console.ResetColor();

int result = IsPalindromeNumber(number);
PrintResult(result);

int IsPalindromeNumber(int number)
{
   // int resultIndex = GetIndexNumber(number);
    int number1_revers = ReversNumber(number);
    int result = ComparisonOfPartsOfANumber(number1_revers, number);
    
    return result;
}

// Определяем скольки значное число
int GetIndexNumber(int number)
{
    int indexNumber = 1;
    while (true)
    {
        number = number / 10;
        indexNumber++;
        if (number < 10)
        {
            break;
        }
    }
    return indexNumber;
}

// Переворачиваем число
int ReversNumber(int number)
{   
    int result = 0; 
    int degreeOf;
    int numb;
    int indexNumber = GetIndexNumber(number);
    int index = indexNumber;
    for (int i = 0; i < index; i++)
    {
        if (number > 10)
        {
            numb = number % 10;
            number = number / 10;
        }
        else
        {
            numb = number;
        }
        degreeOf = DegreeOf(indexNumber);
        result = result + numb * degreeOf;
        degreeOf = degreeOf / 10;
        indexNumber--;
    }

    // 10 в степени Index
    int DegreeOf(int index)
    {  
        int result = 1;
        while(index-1 != 0)
        {
            result = result*10;
            index--;
        }
        return result;
    }
    return result; 
}

// Сравниваем перевернутое число с вводимым.
int ComparisonOfPartsOfANumber(int number1_revers, int number2)
{
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
    if (result == 1)
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