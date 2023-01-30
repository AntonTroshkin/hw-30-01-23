// Максимальное из 3х
Console.WriteLine("Введите 1е число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2е число");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 3е число");
int num3 = Convert.ToInt32(Console.ReadLine());
int max = num1;

if(num2>num1)
{
    max=num2;
}
if(num3>max)
{
    max=num3;
}
Console.WriteLine($"максимальное число:{max}");


