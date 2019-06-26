using System;

namespace Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //printPrima();
            printFibonacci();

            Console.ReadLine();
        }

        public static void printPrima()
        {
            bool prima = true;
            for (int i = 2; i <= 20; i++)
            {
                //loop mulai dari 2 ke i
                for (int j = 2; j < i; j++)
                {
                    //bukan blangan prima jika i habis dibagi j
                    if ((i % j) == 0)
                    {
                        prima = false;
                        break;
                    }
                }
                //jika bilangan == prima
                if (prima)
                    Console.WriteLine(i);
                prima = true;
            }
        }
        
        public static void printFibonacci()
        {
            Console.Write("Masukan jumlah bilangan fibonacci = ");
            int jumlah = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < jumlah; i++)
            {
                Console.WriteLine(Fibonacci(i));
            }
        }

        public static int Fibonacci(int n)
        {
            int a = 0;
            int b = 1;
            // In N steps compute Fibonacci sequence iteratively.
            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }

            return a;
        }
    }
}
