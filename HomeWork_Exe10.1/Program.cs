// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
Console.WriteLine("Введите трехзначное число");
string number = Console.ReadLine();
if (number.Length==3)
{
    Console.WriteLine("Вторая цифра числа:"+ number[1]);
}

else
{
    Console.WriteLine("Это не трехзначное число");
}