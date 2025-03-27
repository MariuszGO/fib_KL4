namespace MyApp
{
    internal class Program
    {
        public static void Fibonacci(int n) { 

            int i = 0;
            Int128 max,zmienna_tmp;
            Int128[] fib = new Int128[n];
            char[] liczba_binarna = new char[128];

            Int128.TryParse("170141183460469231731687303715884105727",out max);
            Console.WriteLine("Max: " + max);
        
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
                    zmienna_tmp >>= 1; //kkkk
                }

                if (liczba_binarna[0] == '1')
                {
                    break;
                }

              //  zmienna_tmp = fib[i];
                zmienna_tmp.ToString();

                
               // Console.WriteLine(liczba_binarna);
                Console.WriteLine(i + " " + fib[i] + " ");
            }
        }
        static void Main(string[] args)
        {
            Fibonacci(20);

        }
    }
}