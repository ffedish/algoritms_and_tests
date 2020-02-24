using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class Program
    {
        static List<int> Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            List<int> listOfPrimal = new List<int>();
            for (int i = 2; i * i <= n; i++)
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

