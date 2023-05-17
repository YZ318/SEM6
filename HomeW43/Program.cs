double k1, b1, k2, b2, x, y;

// чтение коэффициентов первой прямой
Console.WriteLine("Введите коэффициенты первой прямой:");
Console.Write("k1 = ");
k1 = double.Parse(Console.ReadLine());
Console.Write("b1 = ");
b1 = double.Parse(Console.ReadLine());

// чтение коэффициентов второй прямой
Console.WriteLine("Введите коэффициенты второй прямой:");
Console.Write("k2 = ");
k2 = double.Parse(Console.ReadLine());
Console.Write("b2 = ");
b2 = double.Parse(Console.ReadLine());

// вычисление координат точки пересечения
x = (b2 - b1) / (k1 - k2);
y = k1 * x + b1;

// вывод результата на экран
Console.WriteLine("Точка пересечения прямых: ({0}, {1})", x, y);
