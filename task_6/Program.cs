Console.WriteLine("введите число");
string input = Console.ReadLine()!;
int num = int.Parse(input);

if (num%2==0)
{
    Console.WriteLine("Yes");
}
if (num%2==1)
{
    Console.WriteLine("No");
}