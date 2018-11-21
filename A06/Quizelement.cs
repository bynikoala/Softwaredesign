using System;

namespace A06
{
    class Quizelement
    {
        String question;
        String[] answers;
        int rightAnswer;
        static void Main(String[] args) {
            
        }
        public Boolean CheckAnswer(int choice) {
            if (choice == rightAnswer) {
                return true;
            }
            return false;
        }
        public void ShowQuestion() {
            Console.WriteLine(question);
            foreach(var answer in answers) {
                Console.WriteLine(answer);
            }
            Console.WriteLine("");
        }
    }
}