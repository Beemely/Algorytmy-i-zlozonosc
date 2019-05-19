using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorytmyDominikKacprza
{
    class Pesel
    {

        public string CheckPesel(string textBox_PESEL)
        {
            string message = "";
            char[] tablicaZnakow = textBox_PESEL.ToCharArray();
            
            int[] tablicaCyfr = new int[11];
            int[] tablicaMnozenia = new int[] { 1, 3, 7, 9, 1, 3, 7, 9, 1, 3 };
            
            

            for (int i = 0; i < 11; i++)
            {
                tablicaCyfr[i] = Int32.Parse(tablicaZnakow[i].ToString());
            }
            if (tablicaCyfr.Length == 11)
            {

                int suma = 0;
                for (int i = 0; i < 10; i++)
                {
                    tablicaCyfr[i] *= tablicaMnozenia[i];
                    suma = suma + tablicaCyfr[i];
                }
                suma %= 10;
                suma = 10 - suma;
                suma %= 10;

                if (suma == tablicaCyfr[10])
                {
                    message = "pesel jest prawidlowy";
                }

                else
                {
                    message = "Pesel jest nieprawidlowy";
                }
            }
            else
            {
                message = "Pesel jest nieprawidlowy";
            }


            return message;
        }

    }
}
