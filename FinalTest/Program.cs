string[] array = { "1234", "125", "963", "45" };
string[] NewArray(string[] array)
{
    int arrSize = 0;
    int size = 0;
    while (arrSize < array.Length)
    {
        if (array[arrSize].Length <= 3) size++;
        arrSize++;

    }
    Console.WriteLine(size);
    string[] arr = new string[size];

    int i = 0;
    for (int j = 0; j < array.Length; j++)
    {
        
        if (array[j].Length <= 3)
        {
            arr[i] = array[j];
            i++;
            
        }
        Console.WriteLine(i);
    }


    return arr;
}

void ShowArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + ", ");
    }
}
ShowArray(NewArray(array));