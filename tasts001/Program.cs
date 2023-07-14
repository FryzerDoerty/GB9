//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30
void Main()
{
    int M = Num("Write first number:");
    int N = Num("Write second number:");
    if (M < N)
    {
        System.Console.WriteLine($"Result: {Sum(M, N)}");
    }
    else
    {
        System.Console.WriteLine($"Result: {Sum(N, M)}");
    }
}

int Num(string text)
{
    System.Console.WriteLine(text);
    int n = Convert.ToInt32(Console.ReadLine());
    return n;
}
int Sum(int M, int N)
{
    if (M > N) return 0;
    int sum = M + Sum(M + 1, N);
    return sum;
}
Main();