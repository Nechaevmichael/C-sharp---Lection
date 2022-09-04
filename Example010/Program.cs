int[] array = { 1, 2, 3, 45, 4, 12, 15, 42, 34, 45 };

int n = array.Length;

int find = 45;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index += 1; // или index++;
}