using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace A09 {
    public class QuizMultiple : Quizelement {
        public new String callToAction = "Please type in the numbers of the correct answers (separated however you want): ";
        public new String question;
        private Answer[] answersArray;

        public override String Show() {
            String textToShow = question + "\n\n";
            for (int i = 1; i <= answersArray.Length; i++) {
                textToShow += $"{i}) {answersArray[i-1].text}\n";
            }
            return textToShow;
        }

        public override Boolean IsCorrect(String userInput) {
            Boolean correct = false;
            int[] numbers = Regex.Matches(userInput, "(-?[0-9]+)").OfType<Match>().Select(m => int.Parse(m.Value)).ToArray();
            foreach (int number in numbers) {
                correct = true == answersArray[number].isTrue();
            }
            return correct;
        }
        public override void LoadFromJson() {
            
        }
    }
}