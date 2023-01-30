// Все четные от 0 до N
Console.WriteLine("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
if(n>0)
{int count = 1;
while(count<=n)
{
   if(count%2==0)
   {
   Console.Write($" {count},");
   count=count+1;
   }
   else
   {
     count=count+1;
   }
}
}   
else
{
int count = 1;
while(count>=n)
{
   if(count%2==0)
   {
   Console.Write($" {count},");
   count=count-1;
   }
   else
   {
     count=count-1;
   }
}
}