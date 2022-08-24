// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

class Program
{
    static void Main(string[]args)
    {
        Random rand = new Random();
        int sum = 0;

        Console.WriteLine("Сколько чисел вы хотите вывести?");

        int numberCount = Convert.ToInt32(Console.ReadLine());
        int[]array=new int[numberCount];

        Console.Write("[");
        for (int i=0;i<numberCount;i++)
        {
            array[i]=rand.Next(100,999);
            Console.Write(array[i]);
            if(i!=numberCount -1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine("]");

        for(int j=1;j<numberCount; j+=2)
        {
            sum  += array[j];
        }
        Console.WriteLine("Сумма значений-" + sum);
    }
}