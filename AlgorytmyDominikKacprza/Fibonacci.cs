using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorytmyDominikKacprza
{
    class Fibonacci
    {
        public string FibonacciIteracja(int n)
        {
            
            long fib = 0;
            long fib1 = 1;
            long fib2 = 1;

            string fibChain = "1, 1, ";
            if (n > 2)
            {
                for (int i = 3; i <= n; i++)
                {
                    fib = fib1 + fib2;
                    fib1 = fib2;
                    fib2 = fib;
                    fibChain += fib + ", ";
                }
            }
            else if (n == 1)
            {
                fibChain = "1";
            }
            else if (n == 2)
            {
                fibChain = "1, 1";
            }
            else fibChain = "Wprowadzona liczba nie moze byc rowna 0 i powinna byc cyfra";
           

            return fibChain;
        }


       
        
        public long FiibonacciRekurencja(long n, ref long[] cached)
        {
            long fib = 0;
            
            if (cached[n] > 0)
            {
                return cached[n];
            }
            else if (n == 1 || n == 0)
            {
                return n;
            }
            else
            {
                fib = FiibonacciRekurencja(n - 1, ref cached) + FiibonacciRekurencja(n - 2, ref cached);
                cached[n] = FiibonacciRekurencja(n - 1, ref cached) + FiibonacciRekurencja(n - 2, ref cached);
            }

            return fib;


        }
       
    }

}


// 1 1 2 3 5 8