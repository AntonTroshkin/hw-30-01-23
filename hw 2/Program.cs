// Максимальное из 2х
Console.WriteLine("Введите 1е число");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2е число");
int number2 = Convert.ToInt32(Console.ReadLine());
if(number1>number2)
{
    Console.WriteLine($"Первое число больше:{number1} Второе число меньше :{number2}");
}
if(number1<number2)
{
    Console.WriteLine($"Первое число меньше:{number1} Второе число больше :{number2}");
}
if(number1==number2)
{
    Console.WriteLine($"Числа равны:{number1}");
}
