string [] array = {"jome", "kome", "lon", "nani", "op"};

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
