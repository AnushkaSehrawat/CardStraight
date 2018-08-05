using System;
using System.Collections.Generic;
using System.Linq;

namespace starightCards
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> ref_list = new List<int>();
            int n = 9;
            int x = 0;
            int count0 = 0;
            int countn = 0;
            int diff = 0;
            List<int> ref_list1 = new List<int>();
            List<int> final_list = new List<int>();
            for(int i = 0; i < n; i++)
            {
                x = int.Parse(Console.ReadLine());
                ref_list.Add(x);

            }
            ref_list.Sort();
            for (int i = 0; i < ref_list.Count; i++)
            {
                if (ref_list[i] == 0)
                {
                    count0++;
                   
                    
                }
                else if (!ref_list1.Contains(ref_list[i]))
                {
                    ref_list1.Add(ref_list[i]);
                }
            }

            int countZ = count0;
            for(int k = 0; k < ref_list1.Count-1; k++)
            {
                count0 = countZ;
                countn = 0;

                for(int j = k; j < ref_list1.Count - 1; j++)
                {
                    diff = ref_list1[j + 1] - ref_list1[j];
                    if (diff <= count0 + 1)
                    {
                        countn += diff;
                        if (count0 >= 0 && diff > 1)
                        {
                            count0 = count0 - diff + 1;
                        }

                    }
                    else if (count0 > 0)
                    {
                        countn += count0;
                        count0 = 0;
                        break;
                    }
                    if (j + 1 == ref_list1.Count-1 && count0 > 0)
                    {
                        countn += count0;
                        count0 = 0;
                        break;
                    }
                   



                }
                final_list.Add(countn+1);
            }
            Console.WriteLine(final_list.Max());
           
        
            Console.ReadKey();

        }
    }
}
