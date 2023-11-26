using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        // Создаем коллекцию List<int>
        List<int> numbers = new List<int> { 5, 10, 3, 8, 15, 7, 20, 12 };

        // Выводим на экран позицию и значение второго максимального элемента
        DisplaySecondMax(numbers);

        // Удаляем все нечетные элементы
        RemoveOddNumbers(numbers);

        // Выводим на экран обновленную коллекцию
        Console.WriteLine("\nКоллекция после удаления нечетных элементов:");
        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }
    }

    static void DisplaySecondMax(List<int> numbers)
    {
        if (numbers.Count < 2)
        {
            Console.WriteLine("Недостаточно элементов в коллекции.");
            return;
        }

        int max = int.MinValue;
        int secondMax = int.MinValue;

        foreach (var number in numbers)
        {
            if (number > max)
            {
                secondMax = max;
                max = number;
            }
            else if (number > secondMax && number < max)
            {
                secondMax = number;
            }
        }

        int secondMaxIndex = numbers.IndexOf(secondMax);

        Console.WriteLine($"Второе максимальное значение: {secondMax}, позиция: {secondMaxIndex}");
    }

    static void RemoveOddNumbers(List<int> numbers)
    {
        numbers.RemoveAll(num => num % 2 != 0);
    }
}
