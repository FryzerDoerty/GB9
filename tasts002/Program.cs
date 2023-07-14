//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29
void Main()
{
    int M = Num("Write first number:");
    int N = Num("Write second number:");

    System.Console.WriteLine($"Result: {Sum(M, N)}");

}

int Num(string text)
{
    System.Console.WriteLine(text);
    int n = Convert.ToInt32(Console.ReadLine());
    return n;
}
int Sum(int N, int M)
{
    int res = 0;
    if (N == 0) return res = M + 1;
    if (N != 0 && M == 0) return res = Sum(N - 1, 1);
    if (N > 0 && M > 0) return res = Sum(N - 1, Sum(N, M - 1));
    return res;
}
Main();