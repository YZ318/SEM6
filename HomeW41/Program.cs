int m, count = 0;

// чтение количества чисел, которые нужно ввести
Console.WriteLine("Введите количество чисел, которые нужно ввести: ");
m = int.Parse(Console.ReadLine());

// чтение чисел и подсчёт количества чисел больше 0
for (int i = 0; i < m; i++)
{
    Console.Write("Введите число: ");
    int number = int.Parse(Console.ReadLine());

    if (number > 0)
    {
        count++;
    }
}

// вывод результата на экран
Console.WriteLine("Количество чисел, больше 0: {0}", count);
