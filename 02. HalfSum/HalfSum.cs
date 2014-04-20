using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class HalfSum
    {
        static void Main()
        {
            //input
            int n = int.Parse(Console.ReadLine());
            List<int> input = new List<int>();
            int sum = 0;
            int sumHalf = 0;
            for (int i = 0; i < 2*n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                input.Add(number);
            }
            for (int i = 0; i < input.Count/2; i++)
            {
                sum += input[i];
            }
            for (int k = input.Count / 2; k < input.Count ; k++)
            {
                sumHalf += input[k];
            }
            if (sum == sumHalf)
            {
                Console.WriteLine("Yes, sum={0}", sum);
            }
            else
            {
                if (sum > sumHalf)
                {
                    Console.WriteLine("No, diff={0}", sum - sumHalf);
                }
                else
                {
                    Console.WriteLine("No, diff={0}", sumHalf - sum);
                }
            }
        }
    }

