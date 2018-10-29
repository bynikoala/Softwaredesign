using System;

namespace A02
{
    class Program
    {
        static void Main(string[] args)
        {
            // Datatypes
            var i = 42;
            var pi = 3.141592f;
            var pi2 = 3.141592D;
            var pi3 = (short)3.14;
            var salute = "Hellouw ♥";
            
            Console.WriteLine(i.GetType());
            Console.WriteLine(pi.GetType());
            Console.WriteLine(pi2.GetType());
            Console.WriteLine(pi3.GetType());
            Console.WriteLine(salute.GetType());
            Console.WriteLine("");

            // Arrays
            int[] ia = {1, 0, 2, 9, 3, 8, 4, 7, 5, 6, 0};
            int ergebnis = ia[2] * ia[8] + ia[4];
            Console.WriteLine(ergebnis);
            Console.WriteLine(ia.Length);

            double[] constants = {Math.PI, Math.E, 2.97E-19};
            Console.WriteLine("");

            // Strings
            string meinString = "Dies ist ein String";
            string a1 = "Dies ist ";
            string b1 = "ein String";
            string c1 = a1 + b1;
            string a = "eins";
            string b = "zwei";
            string c = "eins";
            bool a_eq_b = (a == b);
            bool a_eq_c = (a == c);
            char zeichen = meinString[5];

            Console.WriteLine("meinString = " + meinString);
            Console.WriteLine("c1 = " + c1);
            Console.WriteLine("a_eq_b = " + a_eq_b);
            Console.WriteLine("a_eq_c = " + a_eq_c);
            Console.WriteLine("zeichen = " + zeichen);
            Console.WriteLine("");

            // If Else
            int aint = int.Parse(Console.ReadLine());
            int bint = int.Parse(Console.ReadLine());

            if (aint > 3 && bint == 6) {
                Console.WriteLine("Du hast gewonnen");
            } else {
                Console.WriteLine("Du hast verloren");
            }
            Console.WriteLine("");

            // Switch case
            String cases = Console.ReadLine();
            switch (cases) {
            case "1":
                Console.WriteLine("Du hast EINS eingegeben");
                break;
            case "2":
                Console.WriteLine("ZWEI war Deine Wahl");
                break;
            case "3":
                Console.WriteLine("Du tipptest eine DREI");
                break;
            case "42":
                Console.WriteLine("Das muss die Antwort sein");
                break;
            default:
                Console.WriteLine("Die Zahl " + i + " kenne ich nicht");
                break;
            }

            if (cases.Equals("1")) {
                Console.WriteLine("Du hast EINS eingegeben");
            } else if (cases.Equals("2")) {
                Console.WriteLine("ZWEI war Deine Wahl");
            } else if (cases.Equals("3")) {
                Console.WriteLine("Du tipptest eine DREI");
            } else if (cases.Equals("42")) {
                Console.WriteLine("Wieso tu ich das hier überhaupt?");
            } else {
                Console.WriteLine("Die Zahl " + i + " kenne ich nicht");
            }
            Console.WriteLine("");

            // Loops                        
            int t = 1;
            while(t <= 10) {
                Console.WriteLine(t);
                t++;
            }

            string[] someStrings = {
                "Hier",
                "sehen",
                "wir",
                "einen",
                "Array",
                "aus",
                "Strings"
            };
            
            for (int k = 0; k < someStrings.Length; k++) {
                Console.WriteLine(someStrings[k]);
            }
        }
    }
}