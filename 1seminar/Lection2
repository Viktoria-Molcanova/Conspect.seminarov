/1

int Max(int agr1, int arg2, int arg3)
{
    int result = agr1;
    if ( arg2> result ) result = arg2;
    if ( arg3> result ) result = arg3;
    return result;
}

int a1 = 2;
int b1 = 3;
int c1 = 4;
int a2 = 23;
int b2 = 32;
int c2 = 41;
int a3 = 233;
int b3 = 322;
int c3 = 411;
int max1 = Max(a1,b1,c1);
int max2 = Max(a2,b2,c2);
int max3 = Max(a3,b3,c3);
int max = Max(max1,max2,max3);
Console.WriteLine(max);

//2

int[] array = {1,2,3,4,5,6,7,8,9};
array[0] = 12;
Console.WriteLine(array[0]);
int max = Max(
    Max(array[0],array[1],array[2] ),
    Max(array[3],array[4],array[5] ),
    Max(array[6],array[7],array[8] ));
Console.WriteLine(max);
//3
int[] array = {1,2,3,4,5,6,7,8};
int n = array.Length;
int find = 4;
int index = 0;
while(index<n)
{
    if (array [index]==find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}

//3

void FillArray(int[] collection)
{
    int Length = collection.Length;
    int index = 0;
    while(index<Length)
    {
        collection[index]=new Random().Next(1,10);
        index++;
    }

}
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while(position<count)
    Console.WriteLine(col[position]);
    position++;
    int []array= new int [10];
    FillArray(array);
    PrintArray(array);
}
