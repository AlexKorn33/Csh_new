//int n = 10;
int[] arr = { 2, 5, 13, 16, 35, 7, 8, 197, 24, 25 };
int i = 0;

while (i < arr.Length)
{
    if(arr[i] % 2 == 0)
    {
        Console.Write($"{arr[i]} ");
    }
    i = i + 1;
}