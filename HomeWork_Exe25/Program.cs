// 

int Number(string n)
{
    Console.Write($"Введите число {n}:");
    return Convert.ToInt32(Console.ReadLine());
}
int A = Number("A");
int B = Number("B");

int pow = 1;
for(int i=1; i<=B; i++)
{
    pow *=A ;
}
Console.WriteLine($"{A} ^ {B}= {pow}");
