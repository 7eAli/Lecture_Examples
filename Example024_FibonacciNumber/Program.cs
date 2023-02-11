// f(1) = 1
// f(2) = 1
// f(n) = f(n-1) + f(n-2)

double Fibonacci(int num)
{
    if(num == 1 || num == 2) return 1;
    else return Fibonacci(num - 1) + Fibonacci(num - 2);
}

for (int i = 1; i < 100; i++)
{
    Console.WriteLine($"{i}:   {Fibonacci(i)}");
}