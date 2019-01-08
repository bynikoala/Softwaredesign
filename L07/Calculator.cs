using System;
namespace L07 {

    delegate void ReportProgressMethod(int progress);
    class Calculator {
        public Calculator() {
            ProgressMethod += WriteProgressToConsole;
            ProgressMethod += WritePointsToConsole;
        }
        public event ReportProgressMethod ProgressMethod;
        public void CalculateSomething() {
            long a = 0;
            for (int i = 0; i <= 10000000; i++) {
                a += i;

                if (i % 1000000 == 0) {
                    ProgressMethod(i / 100000);
                }
            }
        }
        public void WriteProgressToConsole(int progress) {
            Console.Write(progress + " %");
        }
        public void WritePointsToConsole(int progress) {
            Console.Write("...\n");
        }
    }
}