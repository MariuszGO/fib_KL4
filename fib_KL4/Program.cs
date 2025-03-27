namespace MyApp
{
    internal class Program
    {

        public static void Fibonacci(int n)
        {
            
            int i = 0;
            Int128 max,zmienna_tmp;
            Int128.TryParse("170141183460469231731687303715884105727",out max);

            Console.WriteLine("Max: " + max);

            Int128[] fib = new Int128[n];
            char[] liczba_binarna = new char[128];

            fib[0] = 0;
            fib[1] = 1;
            Console.WriteLine(fib[0] + " ");
            Console.WriteLine(fib[1] + " ");
            for (i = 2; i < n; i++)
            {

                fib[i] = fib[i - 1] + fib[i - 2];
                zmienna_tmp = fib[i];

                //dla inta  Convert.ToString(fib[i], 2);

                for (int j = 127; j >= 0; j--)
                {
                    liczba_binarna[j] = (zmienna_tmp & 1) == 1 ? '1' : '0';
                    zmienna_tmp >>= 1;
                }



                // if (fib[i] > max && fib[i - 1] < fib[i] && fib[i] > 0)
                // {

              if (liczba_binarna[0] == '1')
              {
                    break;
                }

                zmienna_tmp = fib[i];
                    zmienna_tmp.ToString();

                    Console.WriteLine("Max reached at index: " + i);
                    Console.WriteLine(liczba_binarna);
                    // break;
                    // }
                    Console.WriteLine(i + " " + fib[i] + " ");

              
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