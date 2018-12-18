using System;

namespace A09 {
    public class QuizSingle : Quizelement {
        private new String callToAction = "\nPlease type in the number of the correct answer: ";
        private new String question;
        private Answer[] answersArray;

        public QuizSingle(String question, Answer[] answersArray) {
            this.question = question;
            this.answersArray = answersArray;
        }

        public override String Show() {
            String textToShow = question + "\n\n";
            for (int i=1; i <= answersArray.Length; i++ ) {
                textToShow += $"{i}) {answersArray[i-1].text}\n";
            }
            return textToShow + callToAction;
        }

        public override Boolean IsCorrect(String userInput) {
            return answersArray[Int32.Parse(userInput)-1].isTrue(); // Who else loves off by one Errors?
        }
        public override void LoadFromJson() {
            
        }
    }
}