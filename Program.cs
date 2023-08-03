// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам

Console.Write("Введите необходимое количество элементов массива: ");
int size = int.Parse(Console.ReadLine()!);

string[] array1 = new string[size];
for (int i = 0; i < size; i++)
{
    Console.Write($"Введите {i+1}-й элемент: ");
    string element = Console.ReadLine()!;
    array1[i] = element;
}

string [] array2 = new string [array1.Length];

void FinalArray (string [] array1, string [] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
        array2 [count] = array1 [i];
        count ++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();
FinalArray(array1, array2);
PrintArray(array2);


