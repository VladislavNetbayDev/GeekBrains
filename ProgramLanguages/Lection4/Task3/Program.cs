double Factorial (int N) // double - тк int не может вместить в себя все значения факториал, начиная с 17!
{
    if (N ==1) return 1; // 1! = 1(факториал 1 равен 1); 0! = 1(факториал 0 равен 1).
    else return N * Factorial (N - 1);
}

for (int i = 1; i < 40; i++)
{
    System.Console.WriteLine($"{i}! = {Factorial(i)}");
}

// System.Console.WriteLine(Factorial(5));