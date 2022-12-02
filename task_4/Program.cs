Console.WriteLine("введите первое число");
string num_1=Console.ReadLine()!;
Console.WriteLine("введите второе число");
string num_2=Console.ReadLine()!;
Console.WriteLine("введите третье число");
string num_3=Console.ReadLine()!;
int a=int.Parse (num_1);
int b=int.Parse (num_2);
int c=int.Parse (num_3);

int max=a;

if (a>max) max=a;
if (b>max) max=b;
if (c>max) max=c;

Console.Write ("max=");
Console.WriteLine (max);
