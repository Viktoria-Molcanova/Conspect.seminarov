Console.WriteLine("Hello, World!");

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
    Console.WriteLine("Ура!Это же Маша");

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

 //5

 Console.SetCursorPosition(10,4);
 Console.WriteLine("x");
 int xa = 1;
 int xb = 1;
 int ya = 1;
 int yb = 30;
 int xc = 40;
 int yc = 30;
 Console.SetCursorPosition(xa,ya);
Console.WriteLine("x");
Console.SetCursorPosition(xb,yb);
Console.WriteLine("x");
Console.SetCursorPosition(xc,yc);
Console.WriteLine("x");
int x = xa;
int y = xb;
int count = 0;
while( count < 10)
{
    int what = new Random().Next(0,3);
    if ( what==0 )
    {
        x =( x + xa )/2;
        y =( y + ya )/2;
    }
    if ( what==1 )
    {
        x =( x + xb )/2;
        y =( y + yb )/2;
        
    }
    if ( what==2)
    {
        x =( x + xc )/2;
        y =( y + yc )/2;
    }
    Console.SetCursorPosition(x,y);
    Console.WriteLine ("+");
    count++;
}

