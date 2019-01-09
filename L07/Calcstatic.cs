using System;
namespace L07 {

    delegate void ReportProgressMethods(int progress);
    static class Calcstatic {
        public static event ReportProgressMethods ProgressMethod;
        public static void CalculateSomething() {
            ProgressMethod += WriteProgressToConsole;
            ProgressMethod += WritePointsToConsole;
            long a = 0;
            for (int i = 0; i <= 10000000; i++) {
                a += i;

                if (i % 1000000 == 0) {
                    ProgressMethod(i / 100000);
                }
            }
        }
        public static void WriteProgressToConsole(int progress) {
            Console.Write(progress + " %");
        }
        public static void WritePointsToConsole(int progress) {
            Console.Write("...\n");
        }
    }
}