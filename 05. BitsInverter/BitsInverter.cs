using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class BitsInverter
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int step = int.Parse(Console.ReadLine());
            int count = 0;
           
            for (int i = 0; i < n; i++)
            {
                int numbers = int.Parse(Console.ReadLine());
                for (int bit = 7; bit >=0; bit--)
                {
                    count++;
                    if ((step == 1) || (count % step == 1))
                    {
                        numbers = numbers ^ (1 << bit);
                    }
                }
                Console.WriteLine(numbers);
            }
           
            }
          
        }
    

