namespace LogicalProblems
{
    public class FibonacciSeries
    {
        public static void fibonacciSeries()
        {
            int N1 = 0, N2 = 1, N3=N1+N2,i, count;
            count = 10;

            Console.WriteLine("INPUT NUMBER :");
            Console.Write(N1+" "+N2+" ");
            for (i = 2; i < count; i++)
                N3 = N1 + N2;
                 
            Console.WriteLine(N3+ " ");
            N1 = N2;
            N2 = N3;
             

        }
    }
}
