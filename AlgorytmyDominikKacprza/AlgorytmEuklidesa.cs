using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorytmyDominikKacprza
{
    class AlgorytmEuklidesa
    {

        public string CountEuklides(int pierwsza, int druga)
        {
            int sum = 0;

            while (pierwsza != druga) {
                if (pierwsza > druga)
                {
                    pierwsza -= druga;
                }
                else if (druga > pierwsza)
                {
                    druga -= pierwsza;
                } 
            }
            sum = pierwsza;

            return sum.ToString();
        }
        
    }
}
