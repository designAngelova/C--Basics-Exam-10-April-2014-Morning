using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class SunGlasses
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            char star = '*';
            char slash = '/';
            char line = '|';
            char space = ' ';
            for (int i = 0; i < 1; i++)
            {
                Console.Write(new string(star, 2*n));
                Console.Write(new string(space, n));
                Console.WriteLine(new string(star, 2*n));
            }
            for (int i = 1; i < n-1; i++)
            {
              Console.Write(star);
              Console.Write(new string(slash, 2*n-2));
              Console.Write(star);

              if (i == n / 2 )
              {
                  Console.Write(new string(line, n));
              }
              else
              {
                  Console.Write(new string(space, n));
              }
              Console.Write(star);
              Console.Write(new string(slash, 2 * n - 2));
              Console.WriteLine(star);
            }
            for (int i = 0; i < 1; i++)
            {
                Console.Write(new string(star, 2 * n));
                Console.Write(new string(space, n));
                Console.WriteLine(new string(star, 2 * n));
            }
        }
    }

