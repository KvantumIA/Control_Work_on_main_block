// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


void PrintArray(string[] array)
{
    foreach(var item in array)
    {
        System.Console.Write($"{item} ");
    }
    System.Console.WriteLine();
}

void SearchArray(string[] array, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        int num = 0;
        string temp = array[i];
        num = temp.Length;
        if (num <= 3) 
        {
            array2[count] = temp;
            count++;
        }
        else continue;
    }
    System.Console.WriteLine();
}




Console.Clear();
string[] array = new string[] {"Russia", "Denmark", "Kazan", "Hello", "2", "world", ":-)"};
string[] array2 = new string[array.Length];
System.Console.Write("Первичный массив: ");
PrintArray(array);
SearchArray(array, array2);
System.Console.Write("Новый массив из строк, длина которых меньше или равна 3: ");
PrintArray(array2);