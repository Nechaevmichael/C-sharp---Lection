void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);

        index += 1;
    }

}
void PrintArray(int[] col)
{
    int count = col.Length;
    int postion = 0;
    while (postion < count)
    {
        Console.Write($"{col[postion]} ");
        postion += 1;
    }
}

int Indexof(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index += 1;
    }
    return position;
}

int[] array = new int[10];

FillArray(array);
array[4] = 4;
array[6] = 4;
PrintArray(array);
Console.WriteLine();

int pos = Indexof(array, 44);
Console.WriteLine(pos);