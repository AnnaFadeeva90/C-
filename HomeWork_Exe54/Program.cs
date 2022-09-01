// Задайте двумерный массив. 
//Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

class Program
{
    static void Main()
    {
        Console.Clear();
        Console.WriteLine("Введение количество строк");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите количество элементов массива в строке");
        int n = Convert.ToInt32(Console.ReadLine());
        int[,] array = new int[m,n];
        Random myRandom = new Random();
        Console.WriteLine(" ");
        for (int i=0; i<m; i++)
        {
            for(int j=0;j<n; j++)
            {
                array[i,j]= myRandom.Next(0,10+n);
                Console.Write("{0}\t",array[i,j]);
            }
            Console.WriteLine(" ");
        }
        int indx;
        for (int k =0; k< m; k++)
        {
            for (int i=0;i<n; i++)
            {
                indx =i;
                for(int j=0; j<n; j++)
                {
                    if (array[k,j]> array [k, indx])
                    {
                        indx = j;
                    }
                }
                if (array[k,indx] == array[k,i])
                    continue;
                int temp = array[k,i];
                array[k,i] = array[k,indx];
                array[k,indx] = temp;   
            }
        }
    }
}