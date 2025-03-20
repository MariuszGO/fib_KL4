namespace MyApp
{
    internal class Program
    {

        public static void Fibonacci(int n)
        {
           
            int i = 0;
            Int128 max;
            Int128.TryParse("170141183460469231731687303715884105727",out max);

            Console.WriteLine("Max: " + max);

            Int128[] fib = new Int128[n];

            fib[0] = 0;
            fib[1] = 1;
            Console.WriteLine(fib[0] + " ");
            Console.WriteLine(fib[1] + " ");
            for (i = 2; i < n; i++)
            {

                fib[i] = fib[i - 1] + fib[i - 2];

                if (fib[i] > max && fib[i - 1] < fib[i] && fib[i] > 0)
                {
                    Console.WriteLine("Max reached at index: " + i);
                    break;
                }
                Console.WriteLine(i+  " " + fib[i] + " ");
            }



        }
        static void Main(string[] args)
        {
            //170 141 183 460 469 231 731 687 303 715 884 105 727
            Fibonacci(200);

            Console.WriteLine("Hello World!");
        }
    }
}