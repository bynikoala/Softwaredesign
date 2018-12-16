using System;
using System.Collections.Generic;

namespace A08
{
    public class JsonQuizPool
    {
        public String type {get; set;}
        public String question {get; set;}
        public Answer[] answers {get; set;}

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
            
        }
        public Quizelement ParseQuizSingle() {

        }
        public Quizelement ParseQuizFree() {

        }
        public Quizelement ParseQuizBinary() {

        }  
        public Quizelement ParseQuizGuess() {
            
        }
    }
}