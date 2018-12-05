using System;

namespace A07 {
    static class Erstellen {        
        public static void FragenErstellen(int i, int score) {
            Console.WriteLine("Tippe deine Frage ein:");
            String fragenEingabe = Console.ReadLine();
            AnzahlAntwortmöglichkeiten(i, score);
        }
        public static void AnzahlAntwortmöglichkeiten(int i, int score) {
            Console.WriteLine("Wie viele Antwortmöglichkeiten willst du?");
            int anzahl = Int32.Parse(Console.ReadLine());
            AntwortErstellen(anzahl, i, score);
        }
        public static void AntwortErstellen(int anzahl, int i, int score) {
            for (int r=0; r < anzahl; r++) {
                Console.WriteLine("Tippe Antwortmöglichkeiten");
                String antwort = Console.ReadLine();
            }
            AbfrageWasErMachenWill(i, score);
        }
        public static void AbfrageWasErMachenWill(int i, int score) {
            Console.WriteLine("Tippe 1: QuizFrage erstellen");
            Console.WriteLine("Tippe 2: Quiz beantwroten");
            Console.WriteLine("Tippe 3: Quiz beenden");

            int eingabe = Int32.Parse(Console.ReadLine());
            if (eingabe==1) {
                Erstellen.FragenErstellen(i, score);
            } else if (eingabe==2) {
                FragenAusgabe(i, score);
            } else if (eingabe==3) {
                Console.WriteLine("Auf wiedersehen");
            }
        }
    }
}