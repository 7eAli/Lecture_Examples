// Четвертый тип методов

string MethodTypeFour(int count, string text)
{
    int i = 0;
    string result = String.Empty;
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string laugh = MethodTypeFour(5, "хахаха");
Console.WriteLine(laugh);