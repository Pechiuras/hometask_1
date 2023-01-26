Console.Clear();
Console.Write("Введите 1 - ое число: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите 2 - ое число: ");
int m = Convert.ToInt32(Console.ReadLine());

if (n > m)
Console.WriteLine($" Число: {n} больше числа {m}");
else if (m > n)
Console.WriteLine($" Число: {m} больше числа {n}");

// else (n == m);
// Console.WriteLine($" Число: {m} равно {n}");

 