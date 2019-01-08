using System;

namespace L07
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator hello = new Calculator();
            CalculatorWithoutObserver hello2 = new CalculatorWithoutObserver();
            hello.CalculateSomething();
            hello2.CalculateSomething();
        }
    }
}
