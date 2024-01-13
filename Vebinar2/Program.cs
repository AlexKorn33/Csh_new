// Console.Clear();
// Console.Write("Введите число:");
// int n = Convert.ToInt32(Console.ReadLine());
// int n1 = n / 100;
// int n3 = n % 10;
// Console.WriteLine(n1*10 + n3);


// Console.Clear();
// Console.Write("Введите число:");
// int n = Convert.ToInt32(Console.ReadLine());
// int n1 = n / 10 % 10;
// //int n2 = n1 % 10;
// int n3 = n % 10;
// //Math.Pow(n2, n3);
// Console.WriteLine(Math.Pow(n1, n3));

Console.Clear();
Console.Write("Введите число:");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число:");
int b = Convert.ToInt32(Console.ReadLine());
if (a % b == 0)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет" + ',' +a % b);
}