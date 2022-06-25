// Программа, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.

Console.WriteLine("Введите трехзначное число:");
int number = Convert.ToInt32(Console.ReadLine());
if (number/100 > 1 && number/100 < 10)
{
    
}
else
{
    Console.WriteLine("Ошибка! Введено не трехзначное число!")
}