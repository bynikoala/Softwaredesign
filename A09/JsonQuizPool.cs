using System;
using System.Collections.Generic;

namespace A09
{
    public class JsonQuizPool
    {
        public String type;
        public String question;
        public Answer[] answers;

        public Quizelement ToQuizelement() {
            switch(type) {
                case "QuizMultiple":
                return ParseQuizMultiple();

                case "QuizSingle":
                return ParseQuizSingle();

                case "QuizFree":
                return ParseQuizFree();

                case "QuizBinary":
                return ParseQuizBinary();

                case "QuizGuess":
                return ParseQuizGuess();

                default:
                break;
            }
            return null;
        }

        public Quizelement ParseQuizMultiple() {
            return new QuizMultiple(question, answers);
        }
        public Quizelement ParseQuizSingle() {
            return new QuizSingle(question, answers);
        }
        public Quizelement ParseQuizFree() {
            return new QuizFree(question, answers[0].text);
        }
        public Quizelement ParseQuizBinary() {
            return new QuizBinary(question, answers[0].isTrue());
        }
        public Quizelement ParseQuizGuess() {
            return new QuizGuess(question, double.Parse(answers[0].text), double.Parse(answers[1].text));
        }
    }
}