// Вид1
void Method1()
{
    Console.WriteLine("автор");

}
Method1();

//Вид2
void Method2(string msg)
{
    Console.WriteLine(msg);
}
Method2("текст сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while(i<count)
    {
        i++;
    }
    
}
Method21("текст сообщения",count = 4);

//Вид 3
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);
//Вид 4
string Method4(int count, string text)
{
    int i = 0;
    string result = string.Empty;
    while(i<count)
    {
        result=result+text;
        i++;
    }
    return result;
}
string res = Method4(10,"asdf");
Console.WriteLine(res);
//Цикл for

string Method4(int count, string text)
{
    
    string result = string.Empty;
    for(int i = 0;i<count; i++)
    {
        result=result+text;
        
    }
    return result;
}
string res = Method4(10,"asdf");
Console.WriteLine(res);
//таблица умножения
for(int i = 2;i<10;i++)
{
    for(int j = 2;j<10;j++)
    {
        Console.WriteLine($"{i}*{j}={i*j}");
    }
    Console.WriteLine();
}

string Replace(string text,char OldValue,char NewValue)
{
    string result = string.Empty;
    int length = text.length;
    for(int i = 0; i<length;i++)
    {
        if(text[i]==OldValue) result = result+$"{NewValue}";
        else result+$"{text[i]}";
    }
    return result;
}
string newText = Replace(text,"","|");
Console.WriteLine(newText);

int[]array{1,3,4,5,6,4,4,3,2,2};
void PrintArray(int[]array)
{
    int count = array.length;
    for(int i =0;i<array.length-1;i++)
    {
        int minPosition=i;
        for(int j =0;j<array.length;j++)
        {
        if(array[j]<array[minPosition]) minPosition=j;
        }
        Console.Write($"{array[i]}")
    }
    Console.WriteLine();
void selection(int [] array)
{
    
    int temp = array[i];
    array[i] = array[minPosition];
    array[minPosition] = temp;
}
}
PrintArray(array);
PrintArray(array);
selection(array);
