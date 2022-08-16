// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите пятизначое число");
int n = Convert.ToInt32(Console.ReadLine());
string OurNumber = Convert.ToString(n);
if (OurNumber[0] == OurNumber[4] || OurNumber[1]==OurNumber[3])
{
    Console.WriteLine("Число является полимером");
}
else
{
    Console.WriteLine("Число полимером не является");
}