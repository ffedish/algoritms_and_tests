using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class Program
    {
        public static List<int> Prime(int n)
        {
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
        static void Main(string[] args)
        {
            List<int> list = Prime(Convert.ToInt32(Console.ReadLine()));
            for(int i = 0; i < list.Count(); i++)
            {
                Console.Write(list[i] + " ");
            }
        }
    }
}

