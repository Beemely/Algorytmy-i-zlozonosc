using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorytmyDominikKacprza
{
    class Palindrom
    {
        public string FindPalindrom()
        {
            int theLargestPali = 0;
            int acumulator = 0;
            

            int numberOne = 0;
            int numberTwo = 0;

            for (int i = 100; i < 1000; i++)
            {
                for (int j = 100; j < 1000; j++)
                {
                    acumulator = i * j;
                    if (checkPali(acumulator) == acumulator && checkPali(acumulator) > theLargestPali)
                    {
                        theLargestPali = acumulator;
                        numberOne = i;
                        numberTwo = j;
                    }
                }
            }
            return theLargestPali.ToString() + " = " + numberOne + " X " + numberTwo ;
        }

        private int checkPali(int acumulator)
        {
            int revers = 0;
            
            while(acumulator > 0)
            {
                revers *= 10;
                revers += (acumulator % 10);
                acumulator /= 10;
            }

            return revers;
        }
    }
}
