using System;

namespace A08 {
    public class QuizGuess : Quizelement {
        public new String callToAction = "Enter your estimated value: ";
        public new String question;
        private double tolerance;
        private double rightNumber;

        public override String Show() {
            return $"{question}";
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