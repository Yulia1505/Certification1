int M = 39;
int N = 83;
void RecursivePrint(int m, int n)
{
    if (m == n)
    {
        Console.Write(m);
        Console.Write(' ');
        return;
    }
    else
    {
        RecursivePrint(m + 1, n);
        Console.Write(m);
        Console.Write(' ');
    }
}
RecursivePrint(M, N);
