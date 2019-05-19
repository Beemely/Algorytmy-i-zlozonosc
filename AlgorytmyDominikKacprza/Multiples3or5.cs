using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorytmyDominikKacprza
{
    class Multiples3or5
    {

        public string CheckSumOfMultiples()
        {
            const int numberThree = 3;
            const int numberFive = 5;

            int sumOfNumbers = 0;
            
            for (int i = 1; i < 1000; i++)
            {
                if (i % numberThree == 0)
                {
                    sumOfNumbers += i;
                }
                else if (i % numberFive == 0)
                {
                    sumOfNumbers += i;
                }
            }
            
            return sumOfNumbers.ToString(); ;
        }
    }
}
