// Программа, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// Блок ввода сравниваемых значений
Console.WriteLine("Введите первое число:");
int number_1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int number_2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число:");
int number_3 = Convert.ToInt32(Console.ReadLine());

// Выполнение условий
if(number_1 != number_2 && number_1 != number_3 && number_2 != number_3) // Проверка на корректность ввода сравниваемыхх значений!
{
    if(number_1 > number_2 && number_1 > number_3)
    {
        Console.WriteLine("Первое введеное число больше! Число " + number_1 + " больше чем число " + number_2 + " и число " + number_3 + " !");
    }
    else
    {
        if(number_2 > number_3)
        {
            Console.WriteLine("Второе введеное число больше! Число: " + number_2 + " больше чем число " + number_1 + " и число " + number_3 + " !");
        }
        else
        {
            Console.WriteLine("Третье введеное число больше! Число: " + number_3 + " больше чем число " + number_1 + " и число " + number_2 + " !");
        }
        
    }
}
else
{
    Console.WriteLine("Присутствуют одинаковые числа!");
}