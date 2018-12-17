using System;

namespace A09 {
    public class QuizFree : Quizelement {
        public new String callToAction = "Please type in your Solution: ";
        private new String question;
        private String solution;
        public QuizFree(String question, String solution) {
            this.question = question;
            this.solution = solution;
        }

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