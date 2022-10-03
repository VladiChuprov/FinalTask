string[] array1 = new string[4] {"hello", "2","world", ":)"};
string[] array2 = new string[array1.Length];
void NewArray(string[] array1, string[] array2)
{
  int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

Console.WriteLine("Исходный массив данных");
PrintArray( array1);
NewArray(array1, array2);
Console.WriteLine("измененный массив с длинной элемента <3 ");
PrintArray(array2);
