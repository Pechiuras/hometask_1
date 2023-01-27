// Задача 4: вывод наибольшего числа из трех
Console.Clear();

Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
  if (a > c)
  {
    Console.WriteLine($" Маскимальное число:  {a}");
  }
  else 
  {
   Console.WriteLine($" Маскимальное число:  {c}");
  }
}
else if (b > c)
{
   Console.WriteLine($" Маскимальное число:  {b}");
}
else
{
Console.WriteLine($" Маскимальное число:  {c}");
}

 