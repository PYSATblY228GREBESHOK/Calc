using System;

class Calculator
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Выберите операцию: ");
            Console.WriteLine("1. Сложить 2 числа");
            Console.WriteLine("2. Вычесть первое из второго");
            Console.WriteLine("3. Перемножить два числа");
            Console.WriteLine("4. Разделить первое на второе");
            Console.WriteLine("5. Возвести в степень N первое число");
            Console.WriteLine("6. Найти квадратный корень из числа");
            Console.WriteLine("7. Найти 1 процент от числа");
            Console.WriteLine("8. Найти факториал из числа");
            Console.WriteLine("9. Выйти из программы");

            int choice = int.Parse(Console.ReadLine());

            if (choice == 9)
            {
                break;
            }

            int result = 0;

            Console.Write("Введите первое число: ");
            int num1 = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Введите второе число: ");
                    int num2 = int.Parse(Console.ReadLine());
                    result = num1 + num2;
                    break;
                case 2:
                    Console.Write("Введите второе число: ");
                    num2 = int.Parse(Console.ReadLine());
                    result = num1 - num2;
                    break;
                case 3:
                    Console.Write("Введите второе число: ");
                    num2 = int.Parse(Console.ReadLine());
                    result = num1 * num2;
                    break;
                case 4:
                    Console.Write("Введите второе число: ");
                    num2 = int.Parse(Console.ReadLine());
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("Ошибка: деление на ноль.");
                        continue;
                    }
                    break;
                case 5:
                    Console.Write("Введите степень: ");
                    int power = int.Parse(Console.ReadLine());
                    result = (int)Math.Pow(num1, power);
                    break;
                case 6:
                    result = (int)Math.Sqrt(num1);
                    break;
                case 7:
                    result = num1 / 100;
                    break;
                case 8:
                    result = CalculateFactorial(num1);
                    break;
                default:
                    Console.WriteLine("Некорректный выбор операции. Попробуйте еще раз.");
                    continue;
            }

            Console.WriteLine($"Результат: {result}");
            Console.WriteLine();
        }
    }

    static int CalculateFactorial(int n)
    {
        if (n == 0 || n == 1)
        {
            return 1;
        }
        return n * CalculateFactorial(n - 1);
    }
}
