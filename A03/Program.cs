using System;

namespace A03
{
    class Program
    {
        static void Main(string[] args)
        {
            int number,nbase,ntarget;
            if (args.Length >= 3) {
                number = Int32.Parse(args[0]);
                nbase = Int32.Parse(args[1]);
                ntarget = Int32.Parse(args[2]);
            } else {
                Console.WriteLine("Number: ");
                number = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Number Base: ");
                nbase = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Target Base: ");
                ntarget = Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine(ConvertNumberFromSystemToSystem(number, nbase, ntarget));
        }

        static int ConvertNumberFromSystemToSystem(int number, int fromSystem, int toSystem)
        {
            int result = 0;
            result = OtherToDecimal(number, fromSystem);
            result = DecimalToOther(result, toSystem);
            return result;
        }

        static int DecimalToOther(int dec, int system)
        {
            int result = 0;
            int factor = 1;
            while (dec != 0)
            {
                int digit = dec % system;
                dec /= system;
                result += factor * digit;
                factor *= 10;
            }
            return result;
        }

        static int OtherToDecimal(int other, int system)
        {
            int result = 0;
            int factor = 1;
            while (other != 0)
            {
                int digit = other % 10;
                other /= 10;
                result += factor * digit;
                factor *= system;
            }
            return result;
        }
}
}
