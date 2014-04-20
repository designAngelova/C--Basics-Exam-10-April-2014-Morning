using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class NineDigitMagicNumbers
{
    static void Main()
    {
        int sum = int.Parse(Console.ReadLine());
        int diff = int.Parse(Console.ReadLine());
        int resultsCount = 0;
        
        for (int i = 111; i <= 777; i++)
        {
            int num2 = i + diff;
            int num3 = num2 + diff;
            if ((IsNumber(i) && IsNumber(num2) && IsNumber(num3) && num3 <= 777)
                && (CalculateDigits(i) + CalculateDigits(num2) + CalculateDigits(num3) == sum))
            {
                Console.WriteLine("{0}{1}{2}", i, num2, num3);
                resultsCount++;
            }
           
        }
        if (resultsCount == 0)
        {
            Console.WriteLine("No");
        }
    }

    private static int CalculateDigits(int n)
    {
        int sum = 0;
        while (n > 0)
        {
            sum += n % 10;
            n /= 10;
            
        }
        return sum;
    }
    private static bool IsNumber(int n)
    {
        string numString = n.ToString();
        foreach (var digit in numString)
        {
            if (digit < '1' || digit > '7')
            {
                return false;
            }
        }
        return true;
    }
}
        
    

