//Как случайным образом заполнить массив и вывести на экран?
void FillArray(int[]collection) // collection это название аргумента(массива) , может быть любое, мы задаем.
{
    int length=collection.Length; //ищем автоматически длинную массива, определяем ее, то есть сколько позиций в массиве.
    int index=0;
    while (index<length) //пока тндекс(позиция в массиве) меньше чем его длинна,будем что-то делать.
    {
        collection[index]=new Random().Next(1,10); //обращаемся к массиву collection на позицию index  и кладем туда случайное число

        // счетчик индекса, то есть его значение меняется каждый раз пока прога не выходит из цикла, меняет на 1,это и пишем:       
        index++;

     }

}

void PrintArray(int[]col)
{
    int count = col.Length;
    int position =0;
    while(position<count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);