using System;

namespace A08 {
    public class QuizSinge : Quizelement {
        private Boolean truth;
        public new String callToAction = "";
        public new String question = "";
        private Answer[] answersArray;

        public override void Show() {
            for (int i=1; i <= answersArray.Length; i++ ) {
                Console.WriteLine($"{i}) {answersArray[i-1]}");
            }
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