// Второй тип методов

void MethodTypeTwo(string msg)
{
    Console.Clear();
    Console.WriteLine(msg);
}

MethodTypeTwo("Текст сообщения");

void MethodTypeTwo_2(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
MethodTypeTwo_2(msg: "пример", count: 5);