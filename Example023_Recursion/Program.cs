double Factorial(double number)
{
    if(number == 1 || number == 0) return 1;
    else return number * Factorial(number - 1);
}
for (int i = 0; i < 40; i++)
{
    Console.WriteLine($"{i}! = {Factorial(i)}");
}