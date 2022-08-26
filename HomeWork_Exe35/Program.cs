// Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

    int[] ourarray = Getarray(123, 0, 1000);
   
    Console.WriteLine ($"Количество элементов в отрезке [10,99] = {SumInPeriod(ourarray, 10, 99)}");
    
    int[] Getarray(int size, int minvalue, int maxvalue)
    {
        int[] res =new int[size];

        for(int i=0; i< size; i++)
        {
            res[i]=new Random().Next(minvalue,maxvalue+1);
        }
        return res;
    }

    int SumInPeriod(int[] array, int left, int rigth)
    {
        int count =0;
        foreach (var item in array)
        {
            if (item>=left && item <= rigth) count++;
        }
        return count;
    }
   

