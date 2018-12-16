using System;

namespace A08 {
    public class QuizSingle : Quizelement {
        public new String callToAction = "Please type in the number of the correct answer: ";
        public new String question;
        private Answer[] answersArray;

        public override String Show() {
            String textToShow = question + "\n\n";
            for (int i=1; i <= answersArray.Length; i++ ) {
                textToShow += $"{i}) {answersArray[i-1].text}\n";
            }
            return textToShow;
        }

        public override Boolean IsCorrect(String userInput) {
            return answersArray[Int32.Parse(userInput)].isTrue();
        }
        public override void LoadFromJson() {
            
        }
    }
}