using System;

namespace A09 {
    public class QuizGuess : Quizelement {
        private new String callToAction = "\nEnter your estimated value: ";
        private new String question;
        private double tolerance;
        private double rightNumber;

        public QuizGuess(String question, double tolerance, double rightNumber) {
            this.question = question;
            this.tolerance = tolerance;
            this.rightNumber = rightNumber;
        }

        public override String Show() {
            return question + callToAction;
        }

        public override Boolean IsCorrect(String userInput) {
            double upperBound = rightNumber * (1+tolerance / 100);
            double lowerBound = rightNumber * (1-tolerance / 100);
            double userNumber = Double.Parse(userInput);
            
            return lowerBound <= userNumber && userNumber >= upperBound;
        }
        public override void LoadFromJson() {
            
        }
    }
}