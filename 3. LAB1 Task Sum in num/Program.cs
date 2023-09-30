// 3. Вычислить сумму и произведение чисел произвольного трехзначного числа.
class Program
{
    static void Main()
    {
        // Объявляем переменную для хранения трехзначного числа
        int number;

        // Вводим трехзначное число и преобразуем его в целое число
        Console.Write("Введите трехзначное число: ");
        number = Convert.ToInt32(Console.ReadLine());

        // Проверяем, что введено трехзначное число (от 100 до 999)
        if (number >= 100 && number <= 999)
        {
            // Вычисляем сумму цифр числа
            int digit1 = number / 100;         // Первая цифра числа
            int digit2 = (number % 100) / 10;  // Вторая цифра числа
            int digit3 = number % 10;          // Третья цифра числа
            int sum = digit1 + digit2 + digit3;

            // Вычисляем произведение цифр числа
            int product = digit1 * digit2 * digit3;

            // Выводим результаты на экран
            Console.WriteLine("Сумма цифр числа: " + sum);
            Console.WriteLine("Произведение цифр числа: " + product);
        }
        else
        {
            Console.WriteLine("Вы ввели не трехзначное число.");
        }

        // Ожидаем, пока пользователь нажмет Enter, чтобы закрыть консоль
        Console.WriteLine("Нажмите Enter для выхода...");
        Console.ReadLine();
    }
}
