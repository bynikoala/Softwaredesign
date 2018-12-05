using System;

namespace A07 {
    class Program {
        static int score = 0;
        private static int i = 0;
        static void Main (string[] args) {
            Console.WriteLine("Tippe 1: Quizfragen erstellen");
            Console.WriteLine("Tippe 2: Quizfragen beantworten");
        
            int eingabe = Int32.Parse(Console.ReadLine());        
            
            if(eingabe == 1) {
                Erstellen.FragenErstellen(i, score);
            } else if (eingabe == 2) {
                Quizelement.FragenAusgabe(i, score);
            }
        }
    }
}