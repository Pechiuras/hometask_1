// Задача 6: определение четного и нечетного числа:
Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n % 2 == 1)
{
    Console.Write("Число нечетное.");
}
else
{
    Console.Write("Число четное");
}
