// Про день недели
Console.WriteLine("Введите цифру от 1 до 7");
int x = Convert.ToInt32(Console.ReadLine());
if (x>0 && x<8)
{
 if (x>5)
 {
    Console.WriteLine("Выходной");
 }
 else
 {
    Console.WriteLine("Рабочий");
 }
}
else
Console.WriteLine("Введеное число не в заданном диапазоне");