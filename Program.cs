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

// Создаем первый массив, считаем сколько элементов меньше 4
Console.WriteLine("Введите размерность массива");
int n = Convert.ToInt32(Console.ReadLine());
string[] firstArr = new string[n];
int FirstIndex = 0;
int count = 0;
while (FirstIndex < n)
{
    Console.WriteLine($"Введите {FirstIndex + 1} элемент массива");
    firstArr[FirstIndex] = Convert.ToString(Console.ReadLine());
    if (firstArr[FirstIndex].Length < 4) count++;
    FirstIndex++;
}

// Печатаем первый массив
Console.Write("Первый массив:");
for (FirstIndex = 0; FirstIndex < n; FirstIndex++)
{
    Console.Write($" {firstArr[FirstIndex]}");
}
Console.WriteLine();

//Создаем и заполняем второй массив
string[] secondArr = new string[count];
int SecondIndex = 0;
for (FirstIndex = 0; FirstIndex < n; FirstIndex++)
{
    if (firstArr[FirstIndex].Length < 4)
    {
        secondArr[SecondIndex] = firstArr[FirstIndex];
        SecondIndex++;
    }
}

//Печатаем второй массив
Console.Write("Второй массив:");
for (SecondIndex = 0; SecondIndex < count; SecondIndex++)
{
    Console.Write($" {secondArr[SecondIndex]}");
}
Console.WriteLine();
