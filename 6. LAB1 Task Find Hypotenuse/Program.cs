// 6.Периметр треугольника равен P, известны длины 2-х сторон треугольника. Вычислить длину третьей стороны.
class Program
{
    static void Main()
    {
        // Объявляем переменные для хранения периметра и длин двух известных сторон
        double perimeter, side1, side2;

        // Вводим периметр с клавиатуры и преобразуем его в вещественное число (double)
        Console.Write("Введите периметр треугольника (P): ");
        perimeter = Convert.ToDouble(Console.ReadLine());

        // Вводим длины двух известных сторон с клавиатуры и преобразуем их в вещественные числа (double)
        Console.Write("Введите длину первой известной стороны: ");
        side1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите длину второй известной стороны: ");
        side2 = Convert.ToDouble(Console.ReadLine());

        // Вычисляем длину третьей стороны, используя формулу периметра
        double side3 = perimeter - side1 - side2;

        // Выводим результат на экран
        Console.WriteLine("Длина третьей стороны треугольника: " + side3);

        // Ожидаем, пока пользователь нажмет Enter, чтобы закрыть консоль
        Console.WriteLine("Нажмите Enter для выхода...");
        Console.ReadLine();
    }
}
