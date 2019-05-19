using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorytmyDominikKacprza
{
    class LiczbaDosk
    {

        public string LiczbaDoskCounter()
        {
            
            string wynik = "wynik: ";
            for (int i = 3; i <= 10000; i++)
            {
                int sum = 0;
                for (int x = 1; x <= i / 2; x++)
                {
                    if (i % x == 0)
                    {
                        sum += x;
                    }
                }
                if (sum == i)
                {
                    wynik += i.ToString() + ", ";

                }
            }
            return wynik;
        }

    }
}
