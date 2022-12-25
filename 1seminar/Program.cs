//Console.WriteLine("Hello, World!");

//1

Console.WriteLine("Введите ваше имя");
string username = Console.ReadLine();
Console.WriteLine("Привет");
Console.WriteLine(username);

//2

int numberA = new Random().Next(1,10);
Console.WriteLine(numberA);
int numberB = new Random().Next(1,10);
Console.WriteLine(numberB);
int result = numberA+numberB;
Console.WriteLine(result);

//3

Console.WriteLine("Введите имя пользователя ");
string username = Console.ReadLine();
if(username.ToLower()==Маша)
{
    Console.WriteLine("Ура!Это же Маша")

}
else
{
    Console.WriteLine("привет" username);
}

//4

int a = 1;
int b = 2;
int c = 6;
int d = 8;
int e = 4;
int max = a;
 if ( a > max ) max=a;
 if ( b > max ) max=b;
 if ( c > max ) max=c;
 if ( d > max ) max=d;
 if ( e > max ) max=e;