using System;

namespace A09 {
    public class QuizBinary : Quizelement {
        public new String callToAction = "[W]ahr oder [F]alsch? ";
        private new String question;
        private Boolean truth;

        public QuizBinary(String question, Boolean truth) {
            this.question = question;
            this.truth = truth;
        }


        public override String Show() {
            return $"{question}";
        }

        public override Boolean IsCorrect(String userInput) {
            switch(userInput) {
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