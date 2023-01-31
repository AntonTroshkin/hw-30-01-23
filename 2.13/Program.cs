// про 3-е число слева
Console.WriteLine("Введите число");
int x = Convert.ToInt32(Console.ReadLine());

if ((x/100<1) && (x/100>-1))
{
    Console.WriteLine("у числа нет 3-й цифры");
}
else
{
 int n = 1;
 while (n<1000000)
 {
    if (x/(100*n)>1 && x/(100*n)<10)
    {
    int y=(x-x/(10*n)*10*n)/n;
    Console.WriteLine($"3я цифра слева = {y}");
    }
    n=n*10;
 }
}
