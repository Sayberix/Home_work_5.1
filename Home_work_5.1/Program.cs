// Программа, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите первое число:");
int number_1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int number_2 = Convert.ToInt32(Console.ReadLine());

if(number_1 != number_2)
{
    if(number_1 > number_2)
    {
        Console.WriteLine("Первое введеное число больше! Число " + number_1 + " больше чем число " + number_2);
    }
    else
    {
        Console.WriteLine("Второе введеное число больше! Число: " + number_2 + " больше чем число " + number_1);
    }
}
else
{
    Console.WriteLine("Оба числа одинаковы!");
}