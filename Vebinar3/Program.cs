// Console.Clear();
// Console.Write("Введите число:");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// for (int i = 0; i < array.Length; i++)
//     array[i] = new Random().Next(0, 10); //от(0 до 9)
// Console.Write(string.Join(" ", array));


// Console.Clear();
// Console.Write("Введите число:");
// int n = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число:");
// int k = Convert.ToInt32(Console.ReadLine());

// int[] array = new int[n];
// for (int i = 0; i < array.Length; i++)
//     array[i] = new Random().Next(0, 10); //от(0 до 9)
// Console.WriteLine(string.Join(" ", array));

// bool flag = true;
// for (int i = 0; i < array.Length; i++)
// {
//     if (array[i] == k)
// {
//     Console.WriteLine("Да");
//     flag = false;
//     break;
// }
// }
// if(flag == true)
//     Console.WriteLine("Нет");


// Console.Clear();
// Console.Write("Введите число:");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// for (int i = 0; i < array.Length; i++)
//     array[i] = new Random().Next(-10, 10); //от(0 до 9)
// Console.WriteLine(string.Join(" ", array));
// for (int i = 0; i < array.Length; i++)
// {
//     array[i] = array[i] * -1;
// }
// Console.WriteLine(string.Join(" ", array));


// Console.Clear();
// Console.Write("Введите число:");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// int[] new_array = new int[n / 2];

// for (int i = 0; i < array.Length; i++)
//     array[i] = new Random().Next(0, 10); //от(0 до 9)
// Console.WriteLine(string.Join(" ", array));

// for (int i = 0; i < array.Length / 2; i++)
//     new_array[i] = array[i] * array[array.Length - 1 - i];
// Console.WriteLine(string.Join(" ", new_array));


Console.Clear();
Console.Write("Введите число:");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[3];
int i;
for(i = 0; i < array.Length; i++)
{
    array[i] = n % 10;
    n /= 10;
}
Console.WriteLine(string.Join(" ", array));
