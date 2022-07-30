string[] mainArray = new string[5] {"123", "1567", "-2", "c", "City"};
int lettersNumbers = 3; // Количество символов элемента по условию переноса в новый массив

Console.Clear();
Console.WriteLine("********************************************************");
Console.WriteLine("Дан следующий масcив строк:");

Console.Write(PrintArray(mainArray));
Console.WriteLine();

Console.WriteLine("********************************************************");
Console.WriteLine("Удалим элементы с числом символов больше или равно 3:");

string[] cleanedArray = new string[CheckLettersCount(mainArray, lettersNumbers)];
CleanFromLetters(mainArray, cleanedArray, lettersNumbers);
Console.Write(PrintArray(cleanedArray));
Console.WriteLine();

Console.WriteLine("********************************************************");

// Описание методов программы

string PrintArray(string[] currentArray)
{
    string output = String.Empty;
    for (int i = 0; i < currentArray.Length; i++)
    {
        output += ($"{currentArray[i]} \t");
    }
    return output;
}

// Проверка по условию задачи и заполнение нового массива
void CleanFromLetters(string[] currentArray, string[] checkedArray, int number)
{
    int count = 0;
    for (int i = 0; i < currentArray.Length; i++)
    {
        if (currentArray[i].Length <= number) 
        {
            checkedArray[count] = currentArray[i];
            count = count + 1;
        }
    }
}

// Подсчет количества элментов массива по условию для создания нового зависимой длины
int CheckLettersCount(string[] currentArray, int number)
{
    int count = 0;
    for (int i = 0; i < currentArray.Length; i++)
    {
        if (currentArray[i].Length <= number) count++;
    }
    return count;
}