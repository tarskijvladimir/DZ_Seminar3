Console.WriteLine("Введите координаты X, точки А: ");
int x1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты Y, точки А: ");
int y1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты Z, точки А: ");
int z1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты X, точки B: ");
int x2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты Y, точки B: ");
int y2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты Z, точки B: ");
int z2 = int.Parse(Console.ReadLine());


double c = Math.Sqrt (Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2) + Math.Pow((z1 - z2), 2));

Console.WriteLine($"Расстояние между координатами: {c} ");

