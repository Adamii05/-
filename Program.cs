Console.Clear();
Console.Write("Введите колличество элементов массива: ");
int size = Convert.ToInt32(Console.ReadLine());
string[] Array = new string[size];
int max = 3;
int position = 0;
for (int index = 0; index < size; index++)
{
 Console.WriteLine($"Введите {index+1}-й элемент массива: ");
 string element = Convert.ToString(Console.ReadLine());
 if (element.Length <= max)
    {
 Array[position] = element;
 position++;
    }
}
Console.WriteLine();
PrintArray(Array);
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}


