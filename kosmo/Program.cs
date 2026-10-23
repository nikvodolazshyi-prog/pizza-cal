using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("--- Калькулятор пиццы ---");

        Console.Write("Сколько студентов пришло? ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Сколько куплено пицц? ");
        int p = int.Parse(Console.ReadLine());

        Console.Write("На сколько кусочков разрезана каждая пицца? ");
        int k = int.Parse(Console.ReadLine());

        int totalSlices = p * k;
        int perPerson = totalSlices / n;
        int remainder = totalSlices % n;
        double avgPizza = (double)p / n;

        Console.WriteLine("\n--- Результат ---");
        Console.WriteLine("Всего кусочков: " + totalSlices);
        Console.WriteLine("Кусочков каждому: " + perPerson);
        Console.WriteLine("Остаток кусочков: " + remainder);
        Console.WriteLine("В среднем пиццы на человека: " + avgPizza.ToString("F3"));

        Console.ReadLine();
    }
}