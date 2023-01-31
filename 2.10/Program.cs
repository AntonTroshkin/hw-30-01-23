// Вторая цифра из 3хначног
Console.WriteLine("Введите 3 значное число");
int x = Convert.ToInt32(Console.ReadLine());
if (x>99 && x<1000)
{
  int y = (x-x/100*100-x%10)/10;
  Console.WriteLine($"Второе число {y}");

}
else
Console.WriteLine("Введеное число не 3х значное");