class Program
{
    static void Main()
    {
        int M = 2;
        int N = 7;
        
        PrintNumbersInRange(M, N);
    }

    static void PrintNumbersInRange(int m, int n)
    {
        if (m <= n)
        {
            Console.WriteLine(m);
            PrintNumbersInRange(m + 1, n);
        }
    }
}