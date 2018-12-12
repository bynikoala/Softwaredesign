using System;

namespace A08 {
    public class QuizBinary : Quizelement {
        private Boolean truth;

        public override void Show() {
            Console.Clear ();
            Console.Write ($"\n{question} [W]ahr oder [F]alsch?\n> ");

        }

        public override Boolean IsCorrect() {
            String choice = Console.ReadLine ();
            switch(choice) {
                case "W":
                    return truth && true;
                case "F":
                    return truth && false;
                default:
                    Console.Clear();
                    return false;
                    
            }
        }
    }
}