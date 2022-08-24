// See https://aka.ms/new-console-template for more information
class Program
{
    static int MaxNumberArray(int[]array)
    {
        int max = 0;
        for (int i=0;i<array.Length; i++)
        {
            if (array[i]> max)
            {
                max = array[i];
            }
        }
        return max;
    }

    static int MinNumberArray(int[]array)
    {
        int min = array[0];
        for (int i=0;i<array.Length; i++)
        {
            if (array[i]< min)
            {
                min = array[i];
            }
        }
        return min;
    }
    static void Main (string[] args)
    {
        int[] array = {1,2,4,5,56,6,2,61,67,16,1};
        int max = MaxNumberArray(array);
        int min = MinNumberArray(array);
        Console.WriteLine(max);
        Console.WriteLine(min);
        Console.WriteLine(max-min);
    }
}