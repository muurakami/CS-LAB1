// 2. Поменять местами значения двух переменных. Результат (новые значения переменных) вывести на экран. 

class Program
{
    static void Main()
    {
        // Объявляем две переменные для хранения значений
        int a, b;

        // Вводим значения переменных и преобразуем их в целые числа
        Console.Write("Введите значение переменной a: ");
        a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите значение переменной b: ");
        b = Convert.ToInt32(Console.ReadLine());

        // Выводим на экран начальные значения переменных
        Console.WriteLine("Начальные значения переменных:");
        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b);

        // Меняем значения переменных местами, используя временную переменную
        int temp = a;
        a = b;
        b = temp;

        // Выводим на экран новые значения переменных после обмена
        Console.WriteLine("Значения переменных после обмена:");
        Console.WriteLine("a = " + a);
        Console.WriteLine("b = " + b);

        // Ожидаем, пока пользователь нажмет Enter, чтобы закрыть консоль
        Console.WriteLine("Нажмите Enter для выхода...");
        Console.ReadLine();
    }
}