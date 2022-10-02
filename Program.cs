// Задача: Написать программу, которая из имеющегося массива 
// строк формирует новый массив из строк, длина которых меньше, 
// либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


string[] NewArray()
{
    Console.WriteLine("Введите размерность массива");
    int n = Convert.ToInt32(Console.ReadLine());
    string[] firstArr = new string[n];
    int FirstIndex = 0;

    while (FirstIndex < n)
    {
        Console.WriteLine($"Введите {FirstIndex + 1} элемент массива");
        firstArr[FirstIndex] = Convert.ToString(Console.ReadLine());
        FirstIndex++;
    }
    Console.Write("Первый массив:");
    PrintArray(firstArr);
    return firstArr;
}

string[] SecondArray(string[] FirstArr)
{
    int n = FirstArr.Length;
    int count = 0;
    int FirstIndex = 0;
    int SecondIndex = 0;
    for (FirstIndex = 0; FirstIndex < n; FirstIndex++)
        if (FirstArr[FirstIndex].Length < 4) count++;
    string[] secondArr = new string[count];

    for (FirstIndex = 0; FirstIndex < n; FirstIndex++)
    {
        if (FirstArr[FirstIndex].Length < 4)
        {
            secondArr[SecondIndex] = FirstArr[FirstIndex];
            SecondIndex++;
        }
    }
    Console.Write("Второй массив:");
    PrintArray(secondArr);
    return secondArr;
}

void PrintArray (string[] Array)
{
for (int i = 0; i < Array.Length; i++)
{
    Console.Write($" {Array[i]}");
}
Console.WriteLine();
}

SecondArray(NewArray());