// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Укажите число N");
int N = Convert.ToInt32(Console.ReadLine());
for(int i=0; i<N; i++)
{
    if (i%2==0)
    {
        Console.WriteLine(i);
    }
}
