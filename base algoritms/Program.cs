using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    public class Program
    {
        public static int[] TwoArr(int[] arr1, int[] arr2)
        {
            int[] arr = new int[arr1.Length + arr2.Length];
            int k = 0;
            int t = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (k != arr1.Length && t != arr2.Length)
                {
                    if (arr1[k] < arr2[t])
                    {
                        arr[i] = arr1[k];
                        k++;
                        continue;
                    }
                    if (arr1[k] >= arr2[t])
                    {
                        arr[i] = arr2[t];
                        t++;
                        continue;
                    }

                }
                if (k == arr1.Length || t == arr2.Length)
                {
                    if (k == arr1.Length)
                    {
                        arr[i] = arr2[t];
                        t++;
                        continue;
                    }
                    if (t == arr2.Length)
                    {
                        arr[i] = arr1[k];
                        k++;
                        continue;
                    }
                }
            }
            return arr;
        }
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
            /*  List<int> list = Prime(Convert.ToInt32(Console.ReadLine()));
              for(int i = 0; i < list.Count(); i++)
              {
                  Console.Write(list[i] + " ");
              } */
            
            
        }
    }
}

