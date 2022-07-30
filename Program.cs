string[] mainArray = new string[6] { "1203", "5067", "-20", "000c", "City", "it" };
int lettersNumbers = 3; // Количество символов элемента по условию переноса в новый массив

Console.Clear();
Console.WriteLine("***************************************************************");
Console.WriteLine("Дан следующий масcив строк:");

Console.Write(PrintArray(mainArray));
Console.WriteLine();

Console.WriteLine("***************************************************************");
Console.WriteLine($"Оставим элементы с количеством симоволов меньше или равно {lettersNumbers}...");

string[] cleanedArray = new string[CheckLettersCount(mainArray, lettersNumbers)];

// Проверка длины нового массива для более понятного вывода пользователю
if (cleanedArray.Length != 0)
{
    Console.WriteLine("Новый массив:");
    CleanFromLetters(mainArray, cleanedArray, lettersNumbers);
    Console.Write(PrintArray(cleanedArray));
    Console.WriteLine();
}
else Console.WriteLine("В массиве не осталось элементов удовлетворяющих условию");

Console.WriteLine("***************************************************************");

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
