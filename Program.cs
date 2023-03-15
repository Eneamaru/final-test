string [] array = {"home", "cat", "refrigerator", "dog", "me"};

string[] GetShortStrings(string[] strings)
{
    int shortStringsCount = 0;
    for (int i = 0; i < strings.Length; i++)
    {
        if (strings[i].Length <= 3)
        {
            shortStringsCount++;
        }
    }
    string[] shortStrings = new string[shortStringsCount];
    int j = 0;
    for (int i = 0; i < strings.Length; i++)
    {
        if (strings[i].Length <= 3)
        {
            shortStrings[j] = strings[i];
            j++;
        }
    }
    return shortStrings;
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