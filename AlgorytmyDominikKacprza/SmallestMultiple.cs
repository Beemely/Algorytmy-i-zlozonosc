using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorytmyDominikKacprza
{
    class SmallestMultiple
    {
       
        public string CheckSmallestMultiple()
        {
            int number = 2520;
            int answer = 0;
            for (int i = 1; i < 20; i++)
            {
                if (number % i == 0)
                {
                    answer = number;
                }
                else
                {

                    i = 1;
                    number++;

                }
            }

            return answer.ToString();
            //232792560

        }
    }



}
