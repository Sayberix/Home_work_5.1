// Программа, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.


// Блок ввода начального значения
Console.WriteLine("Введите число:");
int number = Convert.ToInt32(Console.ReadLine());

// Выполнение условий
if (number > 1) // Проверка на валидность начального значения
{
    int count = 1;
    while (count <= number)
    {
        if (count % 2 == 0)
        {
            Console.Write(count + " ");
        }
        count++;
    }
}
else
{
    Console.WriteLine("Ошибка! Введеное число должно быть больше 1 !");
}