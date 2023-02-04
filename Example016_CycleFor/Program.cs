// Работа с циклом for

string MethodTypeFour(int count, string text)
{    
    string result = String.Empty;
    for(int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}

string laugh = MethodTypeFour(5, "хахаха");
Console.WriteLine(laugh);
