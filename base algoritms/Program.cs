using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class Program
    {
        static List<uint> Main(string[] args)
        {
            uint n = Convert.ToUInt32(Console.ReadLine());
            List<uint> listOfPrimal = new List<uint>();
            for (uint i = 2; i * i <= n; i++)
            {
                if (n % i == 0)
                {
                    while (n % i == 0)
                    {
                        listOfPrimal.Add(i);
                        n = n / i;
                    }
                }
            }
            if (n > 1)
            {
                listOfPrimal.Add(n);
            }
            return listOfPrimal;
        }
    }
}

