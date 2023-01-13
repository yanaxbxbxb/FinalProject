// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, 
// либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

void StringArrayFindElements()
{
    System.Console.Write("Input array length: ");
    int length = int.Parse(Console.ReadLine());

    System.Console.Write("Input array: ");
    string[] array = Console.ReadLine().Split(", ", length);

    PrintArray(FindElements(array));
}

StringArrayFindElements();


string[] FindElements(string[] array)
{
    string[] newArray = new string[array.GetLength(0)];
    int j = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (array[i].Length <= 3) 
        {
            newArray[j] = array[i];
            j++;
        }
    }
    return newArray;
}

void PrintArray(string[] array)
{
    array = array.Where(x => x != null).ToArray();
    System.Console.Write("[");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (i < array.GetLength(0)-1) {System.Console.Write($"{array[i]}, ");}
        else if (i == array.GetLength(0)-1) {System.Console.Write($"{array[i]}");}
    }
    System.Console.Write("]");
}    