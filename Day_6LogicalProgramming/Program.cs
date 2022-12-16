namespace Day_6LogicalProgramming
{
    class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Diaplaying Logical Programming");
            Console.WriteLine("------------------------------");
            FibonacciSeries series = new FibonacciSeries();
            series.DisplayFibbonacci();
            Console.WriteLine("------------------------------");
            PerfectNumber.DisplayPerfectnumber();
            Console.WriteLine("------------------------------");
            PrimeNumber.Prime();
            Console.WriteLine("------------------------------");
            ReverseNumber reverseNumber = new ReverseNumber();
            reverseNumber.DisplayReverse();
            Console.WriteLine("------------------------------");
            CouponsNumber.Coupon(3);
            Console.WriteLine("------------------------------");
            StopWatch stopWatch = new StopWatch();
            stopWatch.Dispaly();



        }
    }
}