//int Max(int arg1, int arg2, int arg3)
//{
  //  int result = arg1;
    //if(arg2>result) result =arg2;
    //if(arg3>result) result =arg3;
    //return result;
//}
//int a1=3;
//int b1=2;
//int c1=5;

//int a2=10;
//int b2=65;
//int c2=7;

//int a3=23;
//int b3=67;
//int c3=68;


//int max1 = Max(a1,b1,c1);
//int max2 = Max(a2,b2,c2);
//int max3 = Max(a3,b3,c3);
//int max = Max(max1,max2,max3);

//int max = Max(Max(a1,b1,c1),Max(a2,b2,c2),Max(a3,b3,c3));
//Console.WriteLine(max);

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2>result) result =arg2;
    if(arg3>result) result =arg3;
    return result;
}
int[] array ={3,211,5,10,65,7,23,67,68};

int max = Max(
    Max(array[0],array[1],array[2]),
    Max(array[3],array[4],array[5]),
    Max(array[6],array[7],array[8])
    );
    Console.WriteLine(max);