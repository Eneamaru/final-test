string [] array = {"home", "cat", "refrigerator", "dog", "me"};

string[] GetShortStrings(string[] strings)
{
    int ShortStringsCount = 0;
    for (int i = 0; i < strings.Length; i++)
    {
        if (strings[i].Length <= 3)
        {
            ShortStringsCount++;
        }
    }
    string[] ShortStrings = new string[ShortStringsCount];
    int j = 0;
    for (int i = 0; i < strings.Length; i++)
    {
        if (strings[i].Length <= 3)
        {
            ShortStrings[j] = strings[i];
            j++;
        }
    }
    return ShortStrings;
}

string[] newArray = GetShortStrings(array);

void PrintStringMatrix(string[] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        System.Console.WriteLine(matrix[i] + " ");
    }
}

PrintStringMatrix(newArray);