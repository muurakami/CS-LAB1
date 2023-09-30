class Program
{
    static void Main()
    {
        double x, y, z;

        // Задаем значения переменных x, y и z
        x = -4.5;
        y = 0.75 * 0.0001;
        z = 0.845 * 100;

        // Вычисляем числитель
        double numerator = Math.Pow(8 + Math.Pow(Math.Abs(x - y), 2) + 1, 1.0 / 3.0);
        Console.WriteLine("Числитель = " + numerator);

        // Вычисляем знаменатель
        double denominator = x * x + y * y + 2;
        Console.WriteLine("Знаминатель = " + denominator);

        // Вычисляем экспоненту
        double exponent = Math.Exp(Math.Abs(x - y));
        Console.WriteLine("экспонента = " + exponent);

        // Вычисляем квадрат тангенса
        double tangentSquared = Math.Pow(Math.Tan(z + 1), 2);
        Console.WriteLine("Тангенс = " + tangentSquared);

        // Вычисляем значение выражения u
        double u = (numerator / denominator - exponent * tangentSquared);


        Console.WriteLine("Значение выражения u = " + u);

        Console.WriteLine("Нажмите Enter чтобы выйти...");
        Console.ReadLine(); // Ожидаем, пока пользователь нажмет Enter
    }
}
