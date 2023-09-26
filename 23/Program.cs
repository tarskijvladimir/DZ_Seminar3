Console.Write("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= n; i++)
{
    double pow1 = Math.Pow(i, 3); // куб числа
    Console.Write($"{pow1}, ");
}
Console.Write("\b\b ");  // убираем последнюю запятую

