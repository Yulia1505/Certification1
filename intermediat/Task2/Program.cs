int m = 3;
int n = 14;
int FuncAckermann(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else
    {
        return FuncAckermann(m - 1, n + 1);
    }
}
Console.WriteLine(FuncAckermann(m, n));