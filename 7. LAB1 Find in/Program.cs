// 7. Длина стороны треугольник равна a, периметр P. Длины 2-х других сторон равны между собой. Найти эти стороны.


class Program
{
    static void Main()
    {
        // Объявляем переменные для хранения длины одной стороны, периметра и длины двух других сторон
        double sideA, perimeter, sideB, sideC;

        // Вводим длину одной стороны (a) и преобразуем ее в вещественное число (double)
        Console.Write("Введите длину стороны a: ");
        sideA = Convert.ToDouble(Console.ReadLine());

        // Вводим периметр (P) и преобразуем его в вещественное число (double)
        Console.Write("Введите периметр треугольника (P): ");
        perimeter = Convert.ToDouble(Console.ReadLine());

        // Вычисляем длину двух других сторон (sideB и sideC)
        // Эти стороны равны между собой и составляют периметр минус длина стороны a, разделенное на 2
        double remainingPerimeter = perimeter - sideA;
        sideB = remainingPerimeter / 2;
        sideC = remainingPerimeter / 2;

        // Выводим результаты на экран
        Console.WriteLine("Длина стороны b: " + sideB);
        Console.WriteLine("Длина стороны c: " + sideC);

        // Ожидаем, пока пользователь нажмет Enter, чтобы закрыть консоль
        Console.WriteLine("Нажмите Enter для выхода...");
        Console.ReadLine();
    }
}
