string[] array = { "home", "cat", "refrigerator", "dog", "me" };

string[] GetShortStrings(string[] strings)
{
    // Подсчёт количества строк длиной 3 символа или меньше
    int shortStringsCount = 0;
    foreach (string str in strings)
    {
        if (str.Length <= 3)
        {
            shortStringsCount++;
        }
    }

    // Создание результирующего массива
    string[] shortStrings = new string[shortStringsCount];
    
    // Заполнение результирующего массива
    int index = 0;
    foreach (string str in strings)
    {
        if (str.Length <= 3)
        {
            shortStrings[index] = str;
            index++;
        }
    }

    return shortStrings;
}

string[] newArray = GetShortStrings(array);

void PrintStringArray(string[] strings)
{
    foreach (string str in strings)
    {
        Console.WriteLine(str);
    }
}

PrintStringArray(newArray);