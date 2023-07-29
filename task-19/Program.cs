Console.Write("Введите пятизначное число: ");
int numb = int.Parse(Console.ReadLine()!);

if (numb < 10000 || numb >= 100000) Console.WriteLine($"Число {numb} не является пятизначным");
int numb1 = numb / 10000;
int numb2 = (numb % 10000) / 1000;
int numb3 = (numb % 1000) / 100;
int numb4 = (numb % 100) / 10;
int numb5 = numb % 10;

if (numb1 == numb5 && numb2 == numb4) Console.Write($"Число {numb} является палиндромом");
else Console.Write($"Число {numb} не является палиндромом");
