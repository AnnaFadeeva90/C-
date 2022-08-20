//  Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
int Number(string n)
{
    Console.Write($"Введите число {n}:");
    return Convert.ToInt32(Console.ReadLine());
}
int A = Number("A");

int sum=0;
while (A>0)
{
    int num = A % 10;
    A= A/10;
    sum = sum+num;
}
Console.WriteLine($"Сумма цифр в числе:{sum}");