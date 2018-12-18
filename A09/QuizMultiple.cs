using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace A09 {
    public class QuizMultiple : Quizelement {
        private new String callToAction = "\nPlease type in the numbers of the correct answers (separated however you want): ";
        private new String question;
        private Answer[] answersArray;

        public QuizMultiple(String question, Answer[] answersArray) {
            this.question = question;
            this.answersArray = answersArray;
        }

        public override String Show() {
            String textToShow = question + "\n\n";
            for (int i = 1; i <= answersArray.Length; i++) {
                textToShow += $"{i}) {answersArray[i-1].text}\n";
            }
            return textToShow + callToAction;
        }

        public override Boolean IsCorrect(String userInput) {
            Boolean correct = false;
            int[] numbers = Regex.Matches(userInput, "(-?[0-9]+)").OfType<Match>().Select(m => int.Parse(m.Value)).ToArray();
            foreach (int number in numbers) {
                correct = true == answersArray[number-1].isTrue(); // Who else loves off by one Errors?
            }
            return correct;
        }
        public override void LoadFromJson() {
            
        }
    }
}