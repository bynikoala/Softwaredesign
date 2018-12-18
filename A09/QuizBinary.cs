using System;

namespace A09 {
    public class QuizBinary : Quizelement {
        private new String callToAction = "\n[W]ahr oder [F]alsch? ";
        private new String question;
        private Boolean truth;

        public QuizBinary(String question, Boolean truth) {
            this.question = question;
            this.truth = truth;
        }


        public override String Show() {
            return question + callToAction;
        }

        public override Boolean IsCorrect(String userInput) {
            switch(userInput.ToUpper()) {
                case "W":
                    return truth == true;
                case "F":
                    return truth == false;
                default:
                    Console.Clear();
                    return false;
            }
        }
        public override void LoadFromJson() {
            
        }
    }
}