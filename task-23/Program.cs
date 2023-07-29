Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
int tmp = 0;

for (int i = 1; i <= n; i++)
{
    tmp = (i * i * i);
    Console.Write($"{tmp}, ");
}