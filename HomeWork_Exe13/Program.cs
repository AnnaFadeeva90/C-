
// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите трехзначное число");
string number = Console.ReadLine();
if (number.Length==3)
{
    Console.WriteLine("Третья цифра числа:"+ number[2]);
}

else 
if (number.Length<3)
{
    Console.WriteLine("Третьего числа нет");
}

else
{
    Console.WriteLine("Вы ввели не трехзначное число");
}