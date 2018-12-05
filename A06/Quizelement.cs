using System;

namespace A06 {
    class Quizelement {
        public String question;
        public Answer[] answers;

        public Quizelement (String question, Answer[] answers) {
            this.question = question;
            this.answers = answers;
        }
        public void Shuffle () {
            Random rand = new Random ();
            int answerArrayLength = answers.Length;

            for (int i = 0; i < answerArrayLength; i++) {
                int randomAnswer = i + rand.Next (answerArrayLength - i);
                Answer temp = answers[randomAnswer];
                answers[randomAnswer] = answers[i];
                answers[i] = temp;
            }
        }
        public void ShowQuestion () {
            Shuffle ();
            Console.Write ($"\n{question}\n\n");

            for (int i = 0; i < answers.Length; i++) {
                Console.WriteLine ($"{i+1}) {answers[i].text}");
            }
        }
    }
}