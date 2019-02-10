using System;
namespace L07 {

    public delegate void ReportProgressMethod(int progress);
    public class Calculator {
        public Calculator() {
            ProgressMethod += delegate(int progress) {Console.Write(progress + " %");};
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
        public void WritePointsToConsole(int progress) {
            Console.Write("...\n");
        }
    }
}