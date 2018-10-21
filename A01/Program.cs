using System;

namespace A01
{
    class Program
    {
        static int dec;
        static void Main(string[] args)
        {
            // Get the input Number
            if (Int32.TryParse(args[0], out dec)) {
                if (dec < 1 || dec > 999) {
                    Console.WriteLine("Error: Number ist out of range. (1-999)");
                } else {
                    Console.WriteLine(GetRomanNumber(dec));
                }            
            } else {
                Console.WriteLine("Error: Not an integer.");
            }
        }
        public static String GetRomanNumber(int dec) {
            String roman = "";
            
            roman += GetCenti(dec);
            roman += GetDeci(dec);
            roman += GetUni(dec);

            return roman;
        }
        public static String GetUni(int dec) {
            int digit = dec % 10;
            String symbol = "";

            if(digit % 10 == 9) {
                symbol = "IX";
                digit -= 9;
            }
            if(digit % 5 == 4) {
                symbol = "IV";
                digit -= 4;
            }
            if(digit % 10 >= 5) {
                symbol = "V";
                digit -= 5;
            }
            while(digit % 5 != 0) {
                symbol = symbol + "I";
                digit -= 1;
            }
            return symbol;
        }
        public static String GetDeci(int dec) {
            if(dec.ToString().Length < 2) {
                return "";
            }

            int digit = (dec % 100 - (dec % 10)) / 10;
            String symbol = "";

            if(digit % 10 == 9) {
                symbol = "XC";
                digit -= 9;
            }
            if(digit % 5 == 4) {
                symbol = "XL";
                digit -= 4;
            }
            if(digit % 10 >= 5) {
                symbol = "L";
                digit -= 5;
            }
            while(digit % 5 != 0) {
                symbol = symbol + "X";
                digit -= 1;
            }
            return symbol;
        }
        public static String GetCenti(int dec) {
            if(dec.ToString().Length < 3) {
                return "";
            }

            int digit = (dec - (dec % 100 - (dec % 10))) / 100;
            String symbol = "";

            if(digit % 10 == 9) {
                symbol = "CM";
                digit -= 9;
            }
            if(digit % 5 == 4) {
                symbol = "CD";
                digit -= 4;
            }
            if(digit % 10 >= 5) {
                symbol = "D";
                digit -= 5;
            }
            while(digit % 5 != 0) {
                symbol = symbol + "C";
                digit -= 1;
            }
            return symbol;
        }
    }
}
