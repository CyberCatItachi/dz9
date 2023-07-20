using System;
using static System.Console;
Clear();

WriteLine("Bведите N: ");
int n = int.Parse(ReadLine()!);

WriteLine(PrintNums(n));

string PrintNums(int n)
{
    if (n == 1)
    {
        return "1";
    }
    string s = n.ToString() + ", " + PrintNums(n-1);
    return s;
}