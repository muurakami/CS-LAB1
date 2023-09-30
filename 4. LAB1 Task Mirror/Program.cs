// 4. Поменять местами цифры произвольного 3-х значного числа по правилу: 123-321.
class Program
{
    static void Main()
    {
        int number;

        Console.Write("Введите трехзначное число: ");
        number = Convert.ToInt32(Console.ReadLine());

        // Проверяем, что введено трехзначное число (от -999 до 999)
        if (number >= -999 && number <= 999)
        {
            // Вычисляем цифры в числе
            // Math.Abs() для получения абсолютного значения введенного числа,
            // чтобы учесть отрицательные числа.
            int digit1 = Math.Abs(number) / 100;           // Первая цифра числа
            int digit2 = (Math.Abs(number) % 100) / 10;    // Вторая цифра числа
            int digit3 = Math.Abs(number) % 10;            // Третья цифра числа

            // Меняем местами цифры, чтобы получить новое число
            int newNumber = digit3 * 100 + digit2 * 10 + digit1;

            // Восстанавливаем знак, если исходное число было отрицательным
            if (number < 0)
            {
                newNumber = -newNumber;
            }

            Console.WriteLine("Новое число после замены цифр: " + newNumber);
        }
        else
        {
            Console.WriteLine("Вы ввели не трехзначное число.");
        }

        Console.WriteLine("Нажмите Enter для выхода...");
        Console.ReadLine();
    }
}
