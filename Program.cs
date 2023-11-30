using System;

class Program
{
    static void Main(string[] args)
    {
        // Создаем массив на 10 целых чисел
        int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        int evenCount = 0; // переменная для хранения количества четных чисел
        Console.Write("Массив ["); 
        // Проходим по каждому элементу массива
        foreach (int number in numbers)
        {
             Console.Write(number + " ");
            // Проверяем, является ли число четным
            if (number % 2 == 0)
            {
                evenCount++; // увеличиваем счетчик на 1
            }
        }

        // Выводим результат
        Console.Write("] => " + evenCount); 

        // Задержка консоли
        Console.ReadLine();
    }
}
