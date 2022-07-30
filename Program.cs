// Написать программу, которая из имеющегося массива строк формирует 
// массив из строк, длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 

// **Примеры**:
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []

string[] mainArray = new string[5] {"1234", "1567", "-2", "computer science", "City"};
string[] cleanedArray = new string[5];

Console.Clear();
Console.WriteLine("********************************************************");
Console.WriteLine("Дан следующий масcив строк:");

PrintArray(mainArray);


Console.WriteLine("********************************************************");

// Описание методов программы

void PrintArray(string[] currentArray)
{
    for (int i = 0; i < currentArray.Length; i++)
    {
        Console.Write(currentArray[i] + "\t");
    }
    Console.WriteLine();
}
