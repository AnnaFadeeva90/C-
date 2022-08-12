
// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите цифру, обозначающую день недели:");

int NameOfTheDay = Convert.ToInt32(Console.ReadLine());

if(NameOfTheDay ==6 || NameOfTheDay ==7)
{
    Console.WriteLine("да,это выходной");
}
else
{
    Console.WriteLine("нет,это не выходной");
}