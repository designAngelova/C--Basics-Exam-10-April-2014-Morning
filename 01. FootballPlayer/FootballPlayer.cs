using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class FootballPlayer
    {
        static void Main()
        {
            //input
            string isLeap = Console.ReadLine();
            int holidays = int.Parse(Console.ReadLine());
            int homehown = int.Parse(Console.ReadLine());
            int result = 0;
            const int weekends =52;
            int weekPlay = ((weekends * 2) - 2*homehown) / 3 + homehown;
            int holidayPlay = holidays / 2;
            //logic
            if (isLeap == "t")
            {
                result = 3 + holidayPlay + weekPlay;
            }
            else
            {
                result = holidayPlay + weekPlay;
            }
            Console.WriteLine(result);
        }
    }

