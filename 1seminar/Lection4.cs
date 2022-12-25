string[,]table = new string[2,5];
table[1,2] = "слово";
for(int rows=0;rows<2;rows++)
{
    for(int column=0;column<5;column++)
    {
        Console.WriteLine($"{table [rows, column]}");
    }
    //2
}
int[,] matrix = new int [3,4];
for(int rows=0;rows< matrix.GetLength(0);rows++)
{
    for(int column=0;column< matrix.GetLength(1);column++)
    {
        matrix[rows,column] = new Random().Next(1,10);
        Console.Write($"{matrix [rows, column]}");
    }
    Console.WriteLine();
}
//3
int[,] matrix = new int [3,4];
for(int rows=0;rows< matrix.GetLength(0);rows++)
{
    for(int column=0;column< matrix.GetLength(1);column++)
    {
        matrix[rows,column] = new Random().Next(1,10);
        Console.Write($"{matrix [rows, column]}");
    }
    Console.WriteLine();
}
//4
void PrintImage (int[,]image);
{
for(int rows=0;rows < image.GetLength(0);rows++)
{
    for(int column=0;column < image.GetLength(1);column++)
    {
        image[rows,column] = new Random().Next(1,10);
        Console.Write($"{image [rows, column]}");
        if(image[rows,column]==0) Console.WriteLine($" ");
        else Console.Write($"+");
    }
    Console.WriteLine();
}
PrintImage(image);
}
//5
void FillImage(int rows,int column)
{
    if (pic[row,col]==0)
    {
        pic[row,col]==1;
        FillImage(row-1,col);
        FillImage(row,col-1);
        FillImage(row+1,col);
        FillImage(row,col+1);
        
    }
}
//6
int factorial(int n);
{
    if (n == 1) return 1;
    else return n*factorial(n-1);
}
Console.WriteLine(factorial(3));

//7
double fibonacci(int n)
{
if(n==1||n==2) return 1;
else return fibonacci(n-1) + fibonacci(n-2);
}
for(int i = 0;i<10;i++)
{
    Console.WriteLine(fibonacci($"{i}"));
}
