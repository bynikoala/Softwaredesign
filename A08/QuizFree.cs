using System;

namespace A08 {
    public class QuizFree : Quizelement {
        public new String callToAction = "Please type in your Solution: ";
        private new String question;
        private String solution;

        public override String Show() {
            return $"{question}";
        }

        public override Boolean IsCorrect(String userInput) {
            return userInput.Equals(solution);
        }
        public override void LoadFromJson() {
            
        }
    }
}