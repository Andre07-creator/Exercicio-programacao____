using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seis_Impares
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine();
            List<int> lista = new List<int>();
            for(int i = 0; i < 12; i++)
            {
                if(x % 2 != 0)
                {
                    lista.Add(x);
                }
                x++;
            }
            foreach(int list in lista)
            {
                Console.WriteLine(list);
            }
        }
    }
}
