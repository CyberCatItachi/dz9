using System;
using static System.Console;
Clear();
WriteLine("Введите М: ");
int m = int.Parse(ReadLine()!);

WriteLine("Введите N: ");
int n = int.Parse(ReadLine()!);

WriteLine(PrintNumbers(m, n));

int PrintNumbers(int m, int n)
{
    if (n == m || n == 1)
    {
        return n;
    }
    int s = PrintNumbers(m, n - 1)+n;
    return s;
}