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
            Random rand = new Random();
            int n = answers.Length;
            for (int i = 0; i < n; i++) {
                int r = i + rand.Next (n - i);
                Answer temp = answers[r];
                answers[r] = answers[i];
                answers[i] = temp;
            }
        }
        public void ShowQuestion () {
            Console.Write ($"\n{question}\n\n");

            for (int i = 0; i < answers.Length; i++) {
                Console.WriteLine ($"{i+1}) {answers[i].text}");
            }
        }
    }
}