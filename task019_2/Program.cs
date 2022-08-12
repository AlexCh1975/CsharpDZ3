/*
    Задача 19
    Напишите программу, которая принимает на вход пятизначное 
    число и проверяет, является ли оно палиндромом.
    14212 -> нет
    12821 -> да
    23432 -> да
*/

//Console.Clear();

Console.Write("Введите число в диапазоне Int32: ");
Console.ForegroundColor = ConsoleColor.Yellow;
int number = Convert.ToInt32(Console.ReadLine());
Console.ResetColor();

int indexNumber = GetIndexNumber(number);
bool evenOrOddNumber = EvenNumber(indexNumber);

int flag;

// Запускаем проверку является ли число палиндромом
if (evenOrOddNumber == true)
{
    flag = 0;
    int result = IsPalindromeNumber(number, indexNumber, flag);
    PrintResult(result);
}
else
{
    flag = 1;
    int result = IsPalindromeNumber(number, indexNumber, flag);
    PrintResult(result);
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

// Определяем четное число или нет
bool EvenNumber(int index)
{ 
    if (index % 2 == 0)
    {
        return true;
    }
    else 
    {
        return false;
    }
}

// Проверка является ли число палиндромом
// Разбиваем число на две части
int IsPalindromeNumber(int number, int indexNumber, int flag)
{
    int index = indexNumber / 2;
    int num = 10;

    for (int i = 0; i < index-1; i++)
    {
        num = num * 10;
    }

    int number1 = number / num; 
    int number2 = number - (number1 * num); 
    if (flag == 1)
    {
        number1 = number1 / 10;
    }

    int number1_revers = ReversNumber(number1, index);
    int result = ComparisonOfPartsOfANumber(number1_revers, number2);
    return result;
}


// Переворачиваем первую часть числа
int ReversNumber(int number, int index)
{   
    int result = 0; 
    int degreeOf;
    int numb;
    int indexNumber = index;
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

// Сравниваем первую перевернутую и вторую часть
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



