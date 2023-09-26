int num;
int r;
int sum = 0;
int t;
Console.Write("Введите пятизначное число: ");
num = Convert.ToInt32(Console.ReadLine());
if(num>9999 && num<100000)
    {
    for(t=num; num!=0; num=num/10)
        {
        r=num % 10;
        sum=sum*10+r; // через цикл число переворачивается: из 12345 становится 54321
        //  1) r = 12345 % 10 = 5
        //     sum = 0 * 10 + 5
        //  2) r = 1234 % 10 = 4
        //     sum = 5 * 10 + 4 = 54
        //  3) r = 123 % 10 = 3
        //     sum = 54 * 10 = 3 = 543
        //  4) r = 12 % 10 = 2
        //     sum = 543 *10 + 2 = 5432
        //  5) r = 1 % 10 = 1
        //     sum = 5432 * 10 + 1 = 54321   
        }
    if(t==sum)
        Console.Write($"{t} является палиндромом.");
    else
        Console.Write($"{t} не является палиндромом.");

    } 
else
    Console.Write("Введите пятизначное число! ");