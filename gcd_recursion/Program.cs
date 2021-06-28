using System;

namespace gcd_recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two positive integers");
            int no1 = Convert.ToInt32(Console.ReadLine());
            int no2 = Convert.ToInt32(Console.ReadLine());

            int ngcd = gcd(no1, no2);

            Console.WriteLine("The GCD of " + no1 + " and " + no2 + " is : " + ngcd);
        }

        static int gcd(int no1, int no2)
        {
            if (no2 != 0)
                return gcd(no2, no1 % no2);
            else
                return no1;
        }
    }
}
