using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorytmyDominikKacprza
{
    class BubbleSort
    {
        public string sort(int[] tab)
        {
            
            
            int[] tab2 = new int[tab.Length];

            int n = tab.Length; // liczba elementow

            do {
                for (int i = 0; i < tab.Length - 1; i++)
                {
                    if (tab[i] > tab[i + 1])
                    {
                        tab2[i] = tab[i];
                        tab[i] = tab[i + 1];
                        tab[i + 1] = tab2[i];
                    }
                }
                n -= 1;
            }while(n > 1);

            
            string view = "";
            for (int i = 0; i < tab.Length; i++)
            {
                view += tab[i] + "\n";

            }

            
            return view;
        }
    }
}
