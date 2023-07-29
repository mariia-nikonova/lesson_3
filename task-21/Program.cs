Console.Write("Введите значение X1: ");
int x1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите значение Y1: ");
int y1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите значение Z1: ");
int z1 = int.Parse(Console.ReadLine()!);

Console.Write("Введите значение X2: ");
int x2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите значение Y2: ");
int y2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите значение Z2: ");
int z2 = int.Parse(Console.ReadLine()!);


double dist= Math.Sqrt((x1-x2)*(x1-x2) +(y1-y2)*(y1-y2) + (z1-z2)*(z1-z2));
Console.Write("Расстояние между точками в 3D пространстве = ");
Console.Write("{0:0.00}", dist);
